using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class CastSpell2 : MonoBehaviour
{
    public GameObject level;
    public XRSocketInteractor socket1;
    public XRSocketInteractor socket2;
    public GameObject life1, life2, life3;
    [SerializeField] public Level1 level1;
    [SerializeField] public Level1Data level1Data;
    [SerializeField] public GameOverLO GameOver;
    [SerializeField] public MonsterKill monsterKill;
    [SerializeField] public YouWin gameWin;
    [SerializeField] public DataStorage levelStore;
    private bool livesDecreased = false;

    public void onUpdate()
    {
        if (!livesDecreased)
        {
            bool incorrectAnswer1 = CheckSocket(socket1, "Correct Answer 2");
            bool incorrectAnswer2 = CheckSocket(socket2, "Correct Answer 1");

            if (incorrectAnswer1 || incorrectAnswer2)
            {
                DecreaseLives();
            }
            else
            {
                level1.gameObject.SetActive(false);
                level1Data.gameObject.SetActive(false);
                monsterKill.gameObject.SetActive(true);
                gameWin.gameObject.SetActive(true);
                if (levelStore.getLevel() < 2)
                {
                    levelStore.SaveLevel(2);
                }
            }
        }
    }

    bool CheckSocket(XRSocketInteractor socket, string correctTag)
    {
        try
        {
            IXRSelectInteractable objName = socket.GetOldestInteractableSelected();

            Debug.Log(objName.transform.name + " in socket of " + socket.name);
            if (objName.transform.CompareTag(correctTag))
            {
                Debug.Log("Correct Answer selected: " + objName.transform.tag);
                var objGameObject = objName.transform.gameObject;
                if (objGameObject != null)
                {
                    // Disable the GameObject when a correct answer is selected
                    objGameObject.SetActive(false);
                    return false; // Indicates a correct answer was found
                }
                else
                {
                    // Handle the case when the object is not found or deactivated
                    Debug.LogError("Correct answer object not found or deactivated!");
                    return true; // Treat as incorrect answer to avoid progressing
                }
            }
            else if (objName.transform.CompareTag("Wrong Answer"))
            {
                Debug.Log("Wrong Answer selected: " + objName.transform.tag);
                var objGameObject = objName.transform.gameObject;
                if (objGameObject != null)
                {
                    // Disable the GameObject when a wrong answer is selected
                    // objGameObject.SetActive(false);
                    return true; // Indicates an incorrect answer was found
                }
            }
        }
        catch (Exception e)
        {
            return true; // Treat as incorrect answer in case of any exception
            Debug.Log(level1.lives);
        }

        return false; // Indicates a correct answer was found
    }


    void DecreaseLives()
    {
        level1.lives--;

        if (level1.lives == 2)
        {
            life3.gameObject.SetActive(false);
        }
        else if (level1.lives == 1)
        {
            life2.gameObject.SetActive(false);
        }
        else
        {
            life1.gameObject.SetActive(false);
            level1.gameObject.SetActive(false);
            level1Data.gameObject.SetActive(false);
            GameOver.gameObject.SetActive(true);
            level1.lives = 3;
        }
    }
}
