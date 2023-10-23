using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HTPIntroductionClick : MonoBehaviour
{
    public IntroductionPanel introPanel;
    public GameObject grabScreen;
    public GameObject grabObjects;
    public void OKClicked()
    {
        introPanel.gameObject.SetActive(false);
        grabScreen.gameObject.SetActive(true);
        grabObjects.gameObject.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
