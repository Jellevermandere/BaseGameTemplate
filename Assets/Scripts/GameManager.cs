using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    public UnityEvent levelStartEvent = new UnityEvent();
    public UnityEvent gamePauseEvent = new UnityEvent();
    public UnityEvent gameUnPauseEvent = new UnityEvent();
    public UnityEvent gameFinishEvent = new UnityEvent();


    // Start is called before the first frame update
    void Start()
    {
        levelStartEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PauseGame()
    {
        gamePauseEvent.Invoke();
        Time.timeScale = 0;
    }

    public void UnPauseGame()
    {
        gameUnPauseEvent.Invoke();
        Time.timeScale = 1;
    }

    public void FinishGame()
    {
        gameFinishEvent.Invoke();
    }
}
