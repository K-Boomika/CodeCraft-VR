using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionPanelClick : MonoBehaviour
{
    [SerializeField] public IntroductionPanel introPanel;
    [SerializeField] public SpellBookWindow spellBookPanel;
    [SerializeField] public GameObject spellBook;
    public void OKClicked()
    {
        introPanel.gameObject.SetActive(false);
        spellBookPanel.gameObject.SetActive(true);
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
