using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToLobby : MonoBehaviour
{
    public void LoadSceneUsingName(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void ReloadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
