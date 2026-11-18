%YAML 1.1
%TAG !u! tag:unity3d.com,2011:
--- !u!114 &1
MonoBehaviour:
  m_ObjectHideFlags: 61
  m_CorrespondingSourceObject: {fileID: 0}
  m_PrefabInstance: {fileID: 0}
  m_PrefabAsset: {fileID: 0}
  m_GameObject: {fileID: 0}
  m_Enabled: 1
  m_EditorHideFlags: 0
  m_Script: {fileID: 12501, guid: 0000000000000000e000000000000000, type: 0}
  m_Name: Test Audio Graph
  m_EditorClassIdentifier: UnityEditor.dll::Unity.GraphToolkit.Editor.Implementation.GraphObjectImp
  m_GraphModel:
    rid: 8736977059536961597
  references:
    version: 2
    RefIds:
    - rid: -2
      type: {class: , ns: , asm: }
    - rid: 8736977059536961597
      type: {class: GraphModelImp, ns: Unity.GraphToolkit.Editor.Implementation, asm: UnityEditor.GraphToolkitModule}
      data:
        m_Guid:
          m_Value0: 9519213990210942272
          m_Value1: 4867194955757295623
        m_HashGuid:
          serializedVersion: 2
          Hash: 40b5736bb00a1b8407987c5606c08b43
        m_Name: 
        m_GraphNodeModels:
        - rid: 8736977059536961600
        m_GraphWireModels: []
        m_GraphStickyNoteModels: []
        m_GraphPlacematModels: []
        m_GraphVariableModels:
        - rid: 8736977059536961606
        - rid: 8736977059536961610
        m_GraphPortalModels: []
        m_SectionModels:
        - rid: 8736977059536961598
        m_LocalSubgraphs: []
        m_LastKnownBounds:
          serializedVersion: 2
          x: 133
          y: 262.5
          width: 289.5
          height: 140
        m_GraphElementMetaData:
        - m_Guid:
            m_Value0: 5667437692901155208
            m_Value1: 2883278622322827727
          m_HashGuid:
            serializedVersion: 2
            Hash: 886108e88dc8a64ecfa10778a1760328
          m_Category: 0
          m_Index: 0
        - m_Guid:
            m_Value0: 5019059058871397237
            m_Value1: 4088384080570335437
          m_HashGuid:
            serializedVersion: 2
            Hash: 756bbc369f47a745cdc0c1fba8dbbc38
          m_Category: 1
          m_Index: 0
        - m_Guid:
            m_Value0: 5213769138342109773
            m_Value1: 12460167847386403218
          m_HashGuid:
            serializedVersion: 2
            Hash: 4da2c65768075b4892d135f1a368ebac
          m_Category: 1
          m_Index: 1
        m_EntryPoint:
          rid: 8736977059536961600
        m_Graph:
          rid: 8736977059536961599
    - rid: 8736977059536961598
      type: {class: SectionModel, ns: Unity.GraphToolkit.Editor, asm: UnityEditor.GraphToolkitModule}
      data:
        m_Guid:
          m_Value0: 9909612866373644604
          m_Value1: 13416935650147589619
        m_HashGuid:
          serializedVersion: 2
          Hash: 3c71d70966048689f35d5249e38732ba
        m_Version: 2
        m_Items:
        - rid: 8736977059536961606
        - rid: 8736977059536961610
        m_Title: 
    - rid: 8736977059536961599
      type: {class: AudioDesignerGraph, ns: Unity.Graphity.Editor.Model, asm: Assembly-CSharp-Editor}
      data: 
    - rid: 8736977059536961600
      type: {class: UserNodeModelImp, ns: Unity.GraphToolkit.Editor.Implementation, asm: UnityEditor.GraphToolkitModule}
      data:
        m_Guid:
          m_Value0: 5667437692901155208
          m_Value1: 2883278622322827727
        m_HashGuid:
          serializedVersion: 2
          Hash: 886108e88dc8a64ecfa10778a1760328
        m_Version: 2
        m_Position: {x: 133.02744, y: 262.64386}
        m_Title: 
        m_Tooltip: 
        m_NodePreviewModel:
          rid: -2
        m_State: 0
        m_InputConstantsById:
          m_KeyList:
          - Play Music
          - Music
          m_ValueList:
          - rid: 8736977059536961601
          - rid: 8736977059536961602
        m_InputPortInfos:
          expandedPortsById:
            m_KeyList: []
            m_ValueList: 
        m_OutputPortInfos:
          expandedPortsById:
            m_KeyList: []
            m_ValueList: 
        m_Collapsed: 0
        m_CurrentModeIndex: 0
        m_ElementColor:
          m_Color: {r: 0, g: 0, b: 0, a: 0}
          m_HasUserColor: 0
        m_Node:
          rid: 8736977059536961603
    - rid: 8736977059536961601
      type: {class: 'Constant`1[[System.Boolean, mscorlib]]', ns: Unity.GraphToolkit.Editor, asm: UnityEditor.GraphToolkitModule}
      data:
        m_Value: 0
    - rid: 8736977059536961602
      type: {class: 'Constant`1[[UnityEngine.AudioClip, UnityEngine.AudioModule]]', ns: Unity.GraphToolkit.Editor, asm: UnityEditor.GraphToolkitModule}
      data:
        m_Value: {fileID: 0}
    - rid: 8736977059536961603
      type: {class: MusicPlayerNode, ns: Unity.GraphToolkit.Graphity.Editor, asm: Assembly-CSharp-Editor}
      data: 
    - rid: 8736977059536961606
      type: {class: VariableDeclarationModel, ns: Unity.GraphToolkit.Editor, asm: UnityEditor.GraphToolkitModule}
      data:
        m_Guid:
          m_Value0: 5019059058871397237
          m_Value1: 4088384080570335437
        m_HashGuid:
          serializedVersion: 2
          Hash: 756bbc369f47a745cdc0c1fba8dbbc38
        m_Version: 2
        m_Name: Play Music
        m_UniqueId: 
        m_DataType:
          m_Identification: System.Boolean, mscorlib
        m_IsExposed: 0
        m_Scope: 0
        m_ShowOnInspectorOnly: 0
        m_Tooltip: 
        m_InitializationValue:
          rid: 8736977059536961607
        m_Modifiers: 0
        m_VariableFlags: 0
    - rid: 8736977059536961607
      type: {class: 'Constant`1[[System.Boolean, mscorlib]]', ns: Unity.GraphToolkit.Editor, asm: UnityEditor.GraphToolkitModule}
      data:
        m_Value: 0
    - rid: 8736977059536961610
      type: {class: VariableDeclarationModel, ns: Unity.GraphToolkit.Editor, asm: UnityEditor.GraphToolkitModule}
      data:
        m_Guid:
          m_Value0: 5213769138342109773
          m_Value1: 12460167847386403218
        m_HashGuid:
          serializedVersion: 2
          Hash: 4da2c65768075b4892d135f1a368ebac
        m_Version: 2
        m_Name: Music
        m_UniqueId: 
        m_DataType:
          m_Identification: UnityEngine.AudioClip, UnityEngine.AudioModule, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
        m_IsExposed: 0
        m_Scope: 0
        m_ShowOnInspectorOnly: 0
        m_Tooltip: 
        m_InitializationValue:
          rid: 8736977059536961611
        m_Modifiers: 0
        m_VariableFlags: 0
    - rid: 8736977059536961611
      type: {class: 'Constant`1[[UnityEngine.AudioClip, UnityEngine.AudioModule]]', ns: Unity.GraphToolkit.Editor, asm: UnityEditor.GraphToolkitModule}
      data:
        m_Value: {fileID: 0}
