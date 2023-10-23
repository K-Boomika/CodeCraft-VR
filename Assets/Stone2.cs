using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stone2 : MonoBehaviour
{
    public NewMonster monsterpopup;
    public GameObject monster;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void landed(string nextLevel)
    {

        SceneManager.LoadScene(nextLevel);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
