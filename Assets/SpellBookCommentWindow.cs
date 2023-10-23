using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellBookCommentWindow : MonoBehaviour
{
    [SerializeField] public SpellBookPrintWindow spellBookPanel;
    [SerializeField] public GameObject BookButton;
    [SerializeField] public GameObject Monster;
    [SerializeField] public GameExpWindow gameExp;
    public void OKClicked()
    {
        spellBookPanel.gameObject.SetActive(false);
        BookButton.gameObject.SetActive(false);
        Monster.gameObject.SetActive(true);
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
