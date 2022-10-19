using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicController : MonoBehaviour
{

    [SerializeField]
    private AudioSource audio;

    #region Singleton
    public static MusicController Singleton { get; private set; }

    protected virtual void Awake()
    {
        if (Singleton != null)
        {
            Destroy(gameObject);
            return;
        }

        Singleton = this;
        audio = GetComponent<AudioSource>();
        DontDestroyOnLoad(gameObject);
    }

    private void OnDestroy()
    {

    }
    #endregion

    public void ToggleMusic()
    {
        if (!audio.isPlaying) audio.Play();
        else audio.Pause();
    }
}
