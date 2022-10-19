using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using JelleVer.ExtensionTools;

public class SceneController : MonoBehaviour
{
    [SerializeField]
    [Scene]
    private string startScene;
    [SerializeField]
    [Scene]
    private string endScene;

    public void loadStartScene()
    {
        if (startScene == null) return;
        SceneManager.LoadScene(startScene);
    }

    public void loadEndScene()
    {
        if (endScene == null) return;
        SceneManager.LoadScene(endScene);
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ResetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadScene(int nr)
    {
        SceneManager.LoadScene(nr);
    }

    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}
