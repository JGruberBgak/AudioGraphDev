using System.Collections;
using System;
using UnityEditor;
using UnityEngine;
using Unity.GraphToolkit.Editor;

namespace Unity.Graphity.Editor.Model
{
    #region AudioDesignerGraph
    [Graph(AssetExtension)]
    [Serializable]
    internal class AudioDesignerGraph : Graph
    {
        public const string AssetExtension = "dsp";
        [MenuItem("Assets/Create/Graphity/Audio Designer Graph", false)]
        static void CreateAssetFile()
        {
            GraphDatabase.PromptInProjectBrowserToCreateNewAsset<AudioDesignerGraph>();
        }
    }
    #endregion AudioDesignerGraph
}