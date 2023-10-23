using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAgainLO : MonoBehaviour
{
    [SerializeField] public GameOverLO gameOver;
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
