using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTelGrabText : MonoBehaviour
{
    public GameObject text;

    public void onHover()
    {
        text.SetActive(true);
    }
    public void onHoverExit()
    {
        text.SetActive(false);
    }
}
