using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellBookPrintWindowClick : MonoBehaviour
{
    [SerializeField] public SpellBookPrintWindow spellBookPanel;
    [SerializeField] public Button BookButton;
    [SerializeField] public GameExpWindow gameExp;
    public void OKClicked()
    {
        spellBookPanel.gameObject.SetActive(false);
        BookButton.gameObject.SetActive(false);
        gameExp.gameObject.SetActive(true);
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
