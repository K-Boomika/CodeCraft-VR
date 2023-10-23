using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HowToPlayPopUpClick : MonoBehaviour
{
    [SerializeField] public HowToPlayPopUp HTPWindow;
    // Start is called before the first frame update

    public void closePopUp()
    {
        HTPWindow.gameObject.SetActive(false);
    }
    public void openHTPPopUp()
    {
        HTPWindow.gameObject.SetActive(true);
        HTPWindow.close.onClick.AddListener(closePopUp);
    }
}
