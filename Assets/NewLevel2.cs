using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewLevel2 : MonoBehaviour
{
    public Button okButton;
    public GameObject stone1;
    public GameObject stone2;
    public GameObject wand;
    public NextLevel popUp;
    public GameObject nextLevel;

    public void okClicked()
    {
        stone2.gameObject.SetActive(true);
        stone1.gameObject.SetActive(false);
        popUp.gameObject.SetActive(false);
        wand.gameObject.SetActive(false);
    }
}
