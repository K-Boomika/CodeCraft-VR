using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellBookWindowClick : MonoBehaviour
{
    [SerializeField] public SpellBookWindow spellBookPanel;
    [SerializeField] public Button BookButton;
    public void OKClicked()
    {
        spellBookPanel.gameObject.SetActive(false);
        BookButton.gameObject.SetActive(true);
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
