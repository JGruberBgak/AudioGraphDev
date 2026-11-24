using UnityEngine;
using UnityEngine.Audio;
using Unity.IntegerTime;
using static UnityEngine.Audio.ProcessorInstance;

//[CreateAssetMenu(fileName = "ClipPlayer", menuName = "Audio/Generators/Clip Player")]
public class ClipPlayerGenerator : MonoBehaviour, IAudioGenerator
{
    public AudioClip clip;

    public bool isFinite => clip != null && ((IAudioGenerator)clip).isFinite;
    public bool isRealtime => false;
    public DiscreteTime? length => clip != null ? ((IAudioGenerator)clip).length : null;

    public GeneratorInstance CreateInstance(
        ControlContext context,
        AudioFormat? nestedFormat,
        CreationParameters creationParameters)
    {
        if (clip == null)
            return default;

        // Create a child generator instance from the AudioClip
        var clipInstance = clip.CreateInstance(context, nestedFormat, creationParameters);

        return context.AllocateGenerator(
            new Realtime(clipInstance, clip),
            new Control(clipInstance),
            nestedFormat,
            creationParameters);
    }

    struct Control : GeneratorInstance.IControl<Realtime>
    {
        GeneratorInstance m_ClipInstance;

        public Control(GeneratorInstance clipInstance)
        {
            m_ClipInstance = clipInstance;
        }

        public void Configure(
            ControlContext context,
            ref Realtime realtime,
            in AudioFormat format,
            out GeneratorInstance.Setup setup,
            ref GeneratorInstance.Properties properties)
        {
            // Configure the child and use its setup
            context.Configure(m_ClipInstance, format);
            var childConfig = context.GetConfiguration(m_ClipInstance);
            setup = childConfig.setup;
        }

        public void Update(ControlContext context, Pipe pipe)
        {
            // Forward update to the child generator
            context.Update(m_ClipInstance);
        }

        public Response OnMessage(ControlContext context, Pipe pipe, Message message)
        {
            return Response.Unhandled;
        }

        public void Dispose(ControlContext context, ref Realtime realtime)
        {
            // Clean up the child generator
            context.Destroy(m_ClipInstance);
        }
    }

    struct Realtime : GeneratorInstance.IRealtime
    {
        GeneratorInstance m_ClipInstance;
        readonly bool m_IsFinite;
        readonly bool m_IsRealtime;
        readonly DiscreteTime? m_Length;

        public Realtime(GeneratorInstance clipInstance, IAudioGenerator source)
        {
            m_ClipInstance = clipInstance;
            m_IsFinite = source.isFinite;
            m_IsRealtime = source.isRealtime;
            m_Length = source.length;
        }

        public bool isFinite => m_IsFinite;
        public bool isRealtime => m_IsRealtime;
        public DiscreteTime? length => m_Length;

        public void Update(UpdatedDataContext context, Pipe pipe) { }

        public GeneratorInstance.Result Process(
            in RealtimeContext context,
            Pipe pipe,
            ChannelBuffer buffer,
            GeneratorInstance.Arguments args)
        {
            // Process the child generator to fill the buffer
            return context.Process(m_ClipInstance, buffer, args);
        }
    }
}
