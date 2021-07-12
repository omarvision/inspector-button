using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; //for Editor

// IMPORTANT!!! place script in Editor folder

[CustomEditor(typeof(GroundScript))]
public class GroundEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GroundScript script = (GroundScript)target;
        if (GUILayout.Button("Spawn My Prefab") == true)
        {
            script.SpawnPrefab();
        }
    }
}