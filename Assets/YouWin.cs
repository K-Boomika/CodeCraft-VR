using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWin : MonoBehaviour
{
    public AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        // Assuming the AudioSource component is attached to the same GameObject as the script
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the GameObject is active
        if (gameObject.activeSelf)
        {
            // Play the sound when the object is active
            if (!audioSource.isPlaying)
            {
                audioSource.Play();
            }
        }
        else
        {
            // Stop the sound when the object is not active
            if (audioSource.isPlaying)
            {
                audioSource.Stop();
            }
        }
    }
}
