using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayAgain : MonoBehaviour
{
    [SerializeField] public GameOver gameOver;
    [SerializeField] public Level1 level1;
    [SerializeField] public Level1Data level1Data;
    public void OKClicked()
    {
        gameOver.gameObject.SetActive(false);
        level1.gameObject.SetActive(true);
        level1Data.gameObject.SetActive(true);
        level1.resetData();
    }
}
