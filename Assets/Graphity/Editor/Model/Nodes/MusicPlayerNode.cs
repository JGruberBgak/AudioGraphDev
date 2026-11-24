using System;
using Unity.GraphToolkit.Editor;
using UnityEngine;
using UnityEngine.UIElements;

namespace Unity.GraphToolkit.Graphity.Editor
{
    [Serializable]
    internal class MusicPlayerNode : GraphityNode
    {
        public static readonly string IN_PORT_PLAYMUSIC_NAME = "Play Music";
        public static readonly string IN_PORT_MUSIC_NAME = "Music";

        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            AddInputOutputExecutionPorts(context);

            context.AddInputPort<bool>(IN_PORT_PLAYMUSIC_NAME);
            context.AddInputPort<AudioClip>(IN_PORT_MUSIC_NAME);
                                //AudioSource

            //context.AddOutputPort<>
        }
    }
    
    /*class MusicPlayerNodeView : NodeView<MusicPlayerNode>
    {
        Button m_Button;

        public override void OnViewBuilt()
        {
            m_Button = new Button()
        }
    }*/
}