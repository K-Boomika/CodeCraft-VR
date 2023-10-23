using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameExpWindowClick : MonoBehaviour
{
    [SerializeField] public GameExpWindow spellBookPanel;
    [SerializeField] public GameObject Monster;
    [SerializeField] public GameObject Level;
    [SerializeField] public Level1Data level1Data;
    public void OKClicked()
    {
        spellBookPanel.gameObject.SetActive(false);
        Monster.gameObject.SetActive(true);
        Level.gameObject.SetActive(true);
        level1Data.gameObject.SetActive(true);
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
