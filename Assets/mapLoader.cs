using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mapLoader : MonoBehaviour
{
    [SerializeField] public DataStorage data;
    public GameObject level1;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public Material newMaterial; // Assign the new material in the Inspector
    // Start is called before the first frame update
    void Start()
    {
        
        data.LoadLevel();
        Debug.Log("Level: " + data.getLevel());
        if (data.getLevel() > 0) {
            Renderer renderer = level1.GetComponent<Renderer>();
            // Check if a Renderer component is found
            if (renderer != null)
            {
                // Change the material of the GameObject to the new material
                renderer.material = newMaterial;
            }
            else
            {
                // If there is no Renderer component, log a warning
                Debug.LogWarning("Renderer component not found on this GameObject.");
            }
        }
        if (data.getLevel() > 1)
        {
            Renderer renderer = level2.GetComponent<Renderer>();
            // Check if a Renderer component is found
            if (renderer != null)
            {
                // Change the material of the GameObject to the new material
                renderer.material = newMaterial;
            }
            else
            {
                // If there is no Renderer component, log a warning
                Debug.LogWarning("Renderer component not found on this GameObject.");
            }
        }
        if (data.getLevel() > 2)
        {
            Renderer renderer = level3.GetComponent<Renderer>();
            // Check if a Renderer component is found
            if (renderer != null)
            {
                // Change the material of the GameObject to the new material
                renderer.material = newMaterial;
            }
            else
            {
                // If there is no Renderer component, log a warning
                Debug.LogWarning("Renderer component not found on this GameObject.");
            }
        }
        if (data.getLevel() > 3)
        {
            Renderer renderer = level4.GetComponent<Renderer>();
            // Check if a Renderer component is found
            if (renderer != null)
            {
                // Change the material of the GameObject to the new material
                renderer.material = newMaterial;
            }
            else
            {
                // If there is no Renderer component, log a warning
                Debug.LogWarning("Renderer component not found on this GameObject.");
            }
        }
        if (data.getLevel() > 4)
        {
            Renderer renderer = level5.GetComponent<Renderer>();
            // Check if a Renderer component is found
            if (renderer != null)
            {
                // Change the material of the GameObject to the new material
                renderer.material = newMaterial;
            }
            else
            {
                // If there is no Renderer component, log a warning
                Debug.LogWarning("Renderer component not found on this GameObject.");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        data.LoadLevel();
        Debug.Log("Level: " + data.getLevel());
        if (data.getLevel() > 0)
        {
            Renderer renderer = level1.GetComponent<Renderer>();
            // Check if a Renderer component is found
            if (renderer != null)
            {
                // Change the material of the GameObject to the new material
                renderer.material = newMaterial;
            }
            else
            {
                // If there is no Renderer component, log a warning
                Debug.LogWarning("Renderer component not found on this GameObject.");
            }
        }
        if (data.getLevel() > 1)
        {
            Renderer renderer = level2.GetComponent<Renderer>();
            // Check if a Renderer component is found
            if (renderer != null)
            {
                // Change the material of the GameObject to the new material
                renderer.material = newMaterial;
            }
            else
            {
                // If there is no Renderer component, log a warning
                Debug.LogWarning("Renderer component not found on this GameObject.");
            }
        }
        if (data.getLevel() > 2)
        {
            Renderer renderer = level3.GetComponent<Renderer>();
            // Check if a Renderer component is found
            if (renderer != null)
            {
                // Change the material of the GameObject to the new material
                renderer.material = newMaterial;
            }
            else
            {
                // If there is no Renderer component, log a warning
                Debug.LogWarning("Renderer component not found on this GameObject.");
            }
        }
        if (data.getLevel() > 3)
        {
            Renderer renderer = level4.GetComponent<Renderer>();
            // Check if a Renderer component is found
            if (renderer != null)
            {
                // Change the material of the GameObject to the new material
                renderer.material = newMaterial;
            }
            else
            {
                // If there is no Renderer component, log a warning
                Debug.LogWarning("Renderer component not found on this GameObject.");
            }
        }
        if (data.getLevel() > 4)
        {
            Renderer renderer = level5.GetComponent<Renderer>();
            // Check if a Renderer component is found
            if (renderer != null)
            {
                // Change the material of the GameObject to the new material
                renderer.material = newMaterial;
            }
            else
            {
                // If there is no Renderer component, log a warning
                Debug.LogWarning("Renderer component not found on this GameObject.");
            }
        }
    }
}
