using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;

/// <summary>
/// Managers all the game settings and its storage
/// </summary>
///
[CreateAssetMenu(fileName = "GameSettings", menuName = "ScriptableObjects/GameSettings")]
public class GameSettingsScriptableObject : ScriptableObject
{
    [Header("Audio Settings")]
    [SerializeField]
    [Range(0, 1)]
    public float mainVolume = 1;
    [SerializeField]
    [Range(0, 1)]
    public float fxVolume = 1;
    [SerializeField]
    [Range(0, 1)]
    public float musicVolume = 1;

    [Header("Graphic Settings")]
    [SerializeField]
    [Range(0, 2)]
    public int qualitySetting = 0;

    /// <summary>
    /// Load the Game settings grom the playerprefs
    /// </summary>
    public void LoadSettings()
    {
        Debug.Log("Loading playerPrefs");

        foreach (FieldInfo item in GetType().GetFields())
        {
            if (item.FieldType == typeof(float))
            {
                item.SetValue( this, PlayerPrefs.GetFloat(item.Name, (float)item.GetValue(this)));
            }
            else if (item.FieldType == typeof(int))
            {
                item.SetValue(this, PlayerPrefs.GetInt(item.Name, (int)item.GetValue(this)));
            }
            else
            {
                item.SetValue(this, PlayerPrefs.GetString(item.Name, item.GetValue(this).ToString()));
            }
        }
        Debug.Log("Finished Loading playerprefs");

    }

    public void SaveSettings()
    {
        Debug.Log("Saving playerPrefs");

        foreach (var item in GetType().GetFields())
        {
            if(item.FieldType == typeof(float))
            {
                PlayerPrefs.SetFloat(item.Name, (float)item.GetValue(this));
            }
            else if (item.FieldType == typeof(int))
            {
                PlayerPrefs.SetInt(item.Name, (int)item.GetValue(this));
            }
            else
            {
                PlayerPrefs.SetString(item.Name, item.GetValue(this).ToString());
            }
        }
        PlayerPrefs.Save();
        Debug.Log("Finished Saving playerprefs");
    }
}
