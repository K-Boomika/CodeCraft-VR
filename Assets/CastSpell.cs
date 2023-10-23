using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class CastSpell : MonoBehaviour
{
    public GameObject level;
    public XRSocketInteractor socket;
    public GameObject life1, life2, life3;
    [SerializeField] public Level1 level1;
    [SerializeField] public Level1Data level1Data;
    [SerializeField] public GameOverLO GameOver;
    [SerializeField] public MonsterKill monsterKill;
    [SerializeField] public YouWin gameWin;
    [SerializeField] public DataStorage levelStore;

    public void socketCheck(int level)
    {
        try
        {
            IXRSelectInteractable objName = socket.GetOldestInteractableSelected();

            Debug.Log(objName.transform.name + " in socket of " + transform.name);
            if (objName.transform.tag == "Wrong Answer")
            {
                Debug.Log("Wrong Answer selected");
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
                    level1.lives = 3;
                    level1.gameObject.SetActive(false);
                    level1Data.gameObject.SetActive(false);
                    GameOver.gameObject.SetActive(true);
                }
                Debug.Log(level1.lives);
                var objGameObject = objName.transform.gameObject;
                if (objGameObject != null)
                {
                    // Disable the GameObject when a wrong answer is selected
                    //objGameObject.SetActive(false);
                }
            }
            else
            {
                level1.gameObject.SetActive(false); 
                level1Data.gameObject.SetActive(false);
                monsterKill.gameObject.SetActive(true);
                gameWin.gameObject.SetActive(true);
                if (levelStore.getLevel() < level)
                {
                    levelStore.SaveLevel(level);
                }
                Debug.Log("Correct Answer selected" + objName.transform.tag);
            }
        }
        catch (Exception e)
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
            Debug.Log(level1.lives);
        }
    }
    private TextMeshPro FindTextMeshProInChildren(GameObject parent)
    {
        TextMeshPro textMeshPro = parent.GetComponent<TextMeshPro>();
        if (textMeshPro != null)
        {
            return textMeshPro;
        }

        foreach (Transform child in parent.transform)
        {
            textMeshPro = child.GetComponent<TextMeshPro>();
            if (textMeshPro != null)
            {
                return textMeshPro;
            }

            // Recursively search in children's children
            TextMeshPro childTextMeshPro = FindTextMeshProInChildren(child.gameObject);
            if (childTextMeshPro != null)
            {
                return childTextMeshPro;
            }
        }

        // TextMeshPro component not found in children
        return null;
    }
}
