using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class WinNext : MonoBehaviour
{
    public Button okButton;
    public YouWin youWinPanel;
    public GameObject Monster;
    public GameObject Attacked;
    public NextLevel next;

    public void okClicked()
    {
        youWinPanel.gameObject.SetActive(false);
        Monster.gameObject.SetActive(false);
        Attacked.gameObject.SetActive(false);
        next.gameObject.SetActive(true);
    }
}
