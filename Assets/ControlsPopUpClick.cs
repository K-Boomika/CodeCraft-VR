using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlsPopUpClick : MonoBehaviour
{
    [SerializeField] public ControlsPopUp ControlsWindow;
    [SerializeField] public DataStorage data;
    public GameObject playgame;
    public GameObject controls;
    public GameObject quitgame;
    public GameObject howtoplay;
    public GameObject playgametext;
    public GameObject controlstext;
    public GameObject quitgametext;
    public GameObject howtoplaytext;

    public void closePopUp()
    {
        ControlsWindow.gameObject.SetActive(false);
        playgame.gameObject.SetActive(true);
        controls.gameObject.SetActive(true);
        quitgame.gameObject.SetActive(true);
        howtoplay.gameObject.SetActive(true);
        playgametext.gameObject.SetActive(true);
        controlstext.gameObject.SetActive(true);
        quitgametext.gameObject.SetActive(true);
        howtoplaytext.gameObject.SetActive(true);
        data.LoadLevel();
        Debug.Log("Level: " + data.getLevel());
    }
    public void openHTPPopUp()
    {
        ControlsWindow.gameObject.SetActive(true);
        playgame.gameObject.SetActive(false);
        controls.gameObject.SetActive(false);
        quitgame.gameObject.SetActive(false);
        howtoplay.gameObject.SetActive(false);
        playgametext.gameObject.SetActive(false);
        controlstext.gameObject.SetActive(false);
        quitgametext.gameObject.SetActive(false);
        howtoplaytext.gameObject.SetActive(false);
        ControlsWindow.close.onClick.AddListener(closePopUp);
        data.LoadLevel();
        Debug.Log("Level: " + data.getLevel());
    }
}
