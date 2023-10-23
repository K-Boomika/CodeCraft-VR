using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoGrabTraining : MonoBehaviour
{
    [SerializeField] public GameObject paneltoclose;
    [SerializeField] public GameObject paneltoopen;
    [SerializeField] public GameObject add;
    [SerializeField] public GrabTraining grabpanel;
    public void OKClicked()
    {
        paneltoclose.gameObject.SetActive(false);
        paneltoopen.gameObject.SetActive(true);
        add.gameObject.SetActive(true);
        grabpanel.ResetToOriginalPosition();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
