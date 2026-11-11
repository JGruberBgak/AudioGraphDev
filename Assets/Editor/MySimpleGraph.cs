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

        [MenuItem("Assets/Create/Graph Toolkit Samples/Simple Graph", false)]
        static void CreateAssetFile()
        {
            GraphDatabase.PromptInProjectBrowserToCreateNewAsset<MySimpleGraph>();
        }
    }
    #endregion SimpleGraph

    class MyCustomType : ScriptableObject
    {
    }

    #region PlayNode
    [Serializable]
    class PlayNode : Node {}
    #endregion PlayNode

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

            context.AddOutputPort("Output").Build();
            context.AddOutputPort<int>("result").Build();
        }
    }
    #endregion SimpleNodeWithPorts
}