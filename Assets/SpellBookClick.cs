using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellBookClick : MonoBehaviour
{
    [SerializeField] public SpellBookPrintWindow spellBookPanel;
    [SerializeField] public Button BookButton;
    [SerializeField] public GameObject Book;

    public void OKClicked()
    {
        spellBookPanel.gameObject.SetActive(true);
        BookButton.gameObject.SetActive(false);
        Book.gameObject.SetActive(false);
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
