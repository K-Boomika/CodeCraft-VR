using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] public CastSpellWindow castSpellWindow;
    [SerializeField] public Level1 level1;
    [SerializeField] public Level1Data level1Data;
    [SerializeField] public GameOver GameOver;

    private void Start()
    {
        // Starts the timer automatically
        level1.timerIsRunning = true;
    }
    void Update()
    {
        if (level1.timeRemaining > 0)
        {
            level1.timeRemaining -= Time.deltaTime;
            castSpellWindow.timer.text = ""+ level1.timeRemaining;
        }
        else
        {
            Debug.Log("Time has run out!");
            level1.timeRemaining = 0;
            level1.timerIsRunning = false;
            castSpellWindow.timer.text = "" + level1.timeRemaining; 
            level1.gameObject.SetActive(false);
            level1Data.gameObject.SetActive(false);
            GameOver.gameObject.SetActive(true);

        }
    }
}
