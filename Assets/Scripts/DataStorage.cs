using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DataStorage : MonoBehaviour
{
    // Integer variable to store the data
    private int level;

    // Example method to save the integer to PlayerPrefs
    public void SaveLevel(int newLevel)
    {
        level = newLevel;
        PlayerPrefs.SetInt("Level", level);
        PlayerPrefs.Save();
        Debug.Log("Level saved: " + level);
    }

    public void LoadLevel()
    {
        if (PlayerPrefs.HasKey("Level"))
        {
            level = PlayerPrefs.GetInt("Level");
            Debug.Log("Level loaded: " + level);
        }
        else
        {
            level = 0;
            Debug.LogWarning("No Level data found.");
        }
    }


    public int getLevel()
    {
        return level;
    }
}
