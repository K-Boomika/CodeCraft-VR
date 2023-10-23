using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterExpClick : MonoBehaviour
{
    public GameObject monsterExp;
    public GameObject nextPanel;
    public GameObject book;
    public void OKClicked()
    {
        monsterExp.gameObject.SetActive(false);
        nextPanel.gameObject.SetActive(true);
        book.gameObject.SetActive(true);
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
