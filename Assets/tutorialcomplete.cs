using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialcomplete : MonoBehaviour
{
    public GameObject paneltoclose;
    public GameObject paneltoopen;
    public GameObject add;
    [SerializeField] public GrabTrainingSocket grabpanel;
    public void OKClicked()
    {
        paneltoclose.gameObject.SetActive(false);
        paneltoopen.gameObject.SetActive(true);
        add.gameObject.SetActive(false);
        grabpanel.ResetToOriginalPosition();
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
