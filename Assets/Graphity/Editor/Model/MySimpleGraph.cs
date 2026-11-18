using System.Collections;
using System;
using UnityEditor;
using UnityEngine;
using Unity.GraphToolkit.Editor;

namespace Unity.GraphToolkit.Scripts.Editor
{
    #region SimpleGraph
    [Graph(AssetExtension)]
    [Serializable]
    class MySimpleGraph : Graph
    {
        public const string AssetExtension = "simpleg";

        [MenuItem("Assets/Create/Graphity/Simple Graph", false)]
        static void CreateAssetFile()
        {
            GraphDatabase.PromptInProjectBrowserToCreateNewAsset<MySimpleGraph>();
        }
    }
    #endregion SimpleGraph

    //class MySimpleType : ScriptableObject
    //{
    //}

    #region PlayNode
    [Serializable]
    class PlayNode : Node {}
    #endregion PlayNode

    #region OptionedNode
    [Serializable]
    class OptionedNode : Node
    {
        const string k_PortCountName = "PortCount";

        protected override void OnDefineOptions(IOptionDefinitionContext context)
        {
            context.AddOption<int>(k_PortCountName)
                .WithDisplayName("Port Count")
                .WithDefaultValue(2)
                .Delayed();
        }
        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            var portCountOption = GetNodeOptionByName(k_PortCountName);
            portCountOption.TryGetValue<int>(out var portCount);
            for (var i = 0; i < portCount; i++)
            {
                context.AddInputPort<Vector2>($"{i}").Build();
            }

            context.AddOutputPort<Vector2>("result").Build();
        }
    }
    #endregion OptionedNode

    #region TypedNode
    [Serializable]
    public class TypedNode : Node
    {
        enum PortTypes
        {
            Vec2,
            Vec3
        }
        const string k_PortTypeName = "PortType";

        protected override void OnDefineOptions(IOptionDefinitionContext context)
        {
            context.AddOption<PortTypes>(k_PortTypeName).WithDisplayName("Port Type");
        }
        protected override void OnDefinePorts(IPortDefinitionContext context)
        {

            var portTypeOption = GetNodeOptionByName(k_PortTypeName);
            portTypeOption.TryGetValue<PortTypes>(out var portType);

            if (portType == PortTypes.Vec3)
            {
                context.AddOutputPort<Vector3>("result").Build();
            }
            else
            {
                context.AddOutputPort<Vector2>("result").Build();
            }
        }
    }
    #endregion TypedNode

    #region OptionTypedNode
    // combo of optioned and typed nodes
    [Serializable]
    public class OptionTypedNode : Node
    {
        enum PortTypes
        {
            Vec2,
            Vec3
        }

        const string k_PortCountName = "PortCount";
        const string k_PortTypeName = "PortType";

        protected override void OnDefineOptions(IOptionDefinitionContext context)
        {
            context.AddOption<int>(k_PortCountName)
                .WithDisplayName("Port Count")
                .WithDefaultValue(2)
                .Delayed();
            context.AddOption<PortTypes>(k_PortTypeName);
        }

        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            var portCountOption = GetNodeOptionByName(k_PortCountName);
            portCountOption.TryGetValue<int>(out var portCount);

            var portTypeOption = GetNodeOptionByName(k_PortTypeName);
            portTypeOption.TryGetValue<PortTypes>(out var portType);
            
            for (var i = 0; i < portCount; i++)
            {
                if (portType == PortTypes.Vec3)
                {
                    context.AddInputPort<Vector3>($"{i}").Build();
                }
                else
                {
                    context.AddInputPort<Vector2>($"{i}").Build();
                }
               
            }

            if (portType == PortTypes.Vec3)
            {
                context.AddOutputPort<Vector3>("result").Build();
            }
            else
            {
                context.AddOutputPort<Vector2>("result").Build();
            }
        }
    }
    #endregion OptionTypedNode


    #region SimpleNodeWithPorts
    [Serializable]
    class MySimpleNodeWithPorts : Node
    {
        protected override void OnDefinePorts(IPortDefinitionContext context)
        {
            context.AddInputPort("Input").Build();
            context.AddInputPort<int>("a")
                .WithDisplayName("My Int")
                .WithConnectorUI(PortConnectorUI.Arrowhead)
                .Build();

            context.AddInputPort<float>("Vertical Float")
                .AsVertical()
                .WithTooltip("Vertical float")
                .Build();

            context.AddOutputPort("Output").Build();
            context.AddOutputPort<int>("result").Build();


        }
    }
    #endregion SimpleNodeWithPorts
}