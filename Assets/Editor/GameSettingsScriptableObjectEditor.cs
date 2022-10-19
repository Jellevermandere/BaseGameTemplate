using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(GameSettingsScriptableObject))]
public class GameSettingsScriptableObjectEditor : Editor
{
    GameSettingsScriptableObject settings;

    public override void OnInspectorGUI()
    {
        DrawDefaultInspector();

        GUILayout.Space(50);

        if (GUILayout.Button("Save Settings"))
        {
            settings.SaveSettings();
        }
        if (GUILayout.Button("Load Settings"))
        {
            settings.LoadSettings();
        }
        
    }
    private void OnEnable()
    {
        settings = (GameSettingsScriptableObject)target;
    }
}
