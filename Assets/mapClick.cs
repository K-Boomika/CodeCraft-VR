using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapClick : MonoBehaviour
{
    [SerializeField] public DataStorage data;
    [SerializeField] public GameObject target;
    public LoadScene load;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void onClicked(int level)
    {
        Debug.Log("Level: " + data.getLevel());
        if (data.getLevel() >= level)
        {
            if (level == 1)
            {
                load.LoadSceneUsingName("MainGame");
            }
            else if (level == 2)
            {
                load.LoadSceneUsingName("MainGame2");
            }
            else if (level == 3)
            {
                load.LoadSceneUsingName("MainGame3");
            }
            else if (level == 4)
            {
                load.LoadSceneUsingName("MainGame4");
            }
            else if (level == 5)
            {
                load.LoadSceneUsingName("MainGame5");
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
