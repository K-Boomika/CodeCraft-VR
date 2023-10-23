using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetProgress : MonoBehaviour
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
        
    }

    public void OnClicked() {
        data.SaveLevel(0);
        Renderer renderer1 = level1.GetComponent<Renderer>();
        // Check if a Renderer component is found
        if (renderer1 != null)
        {
            // Change the material of the GameObject to the new material
            renderer1.material = newMaterial;
        }
        else
        {
            // If there is no Renderer component, log a warning
            Debug.LogWarning("Renderer component not found on this GameObject.");
        }
        Renderer renderer2 = level2.GetComponent<Renderer>();
        // Check if a Renderer component is found
        if (renderer2 != null)
        {
            // Change the material of the GameObject to the new material
            renderer2.material = newMaterial;
        }
        else
        {
            // If there is no Renderer component, log a warning
            Debug.LogWarning("Renderer component not found on this GameObject.");
        }
        Renderer renderer3 = level3.GetComponent<Renderer>();
        // Check if a Renderer component is found
        if (renderer3 != null)
        {
            // Change the material of the GameObject to the new material
            renderer3.material = newMaterial;
        }
        else
        {
            // If there is no Renderer component, log a warning
            Debug.LogWarning("Renderer component not found on this GameObject.");
        }
        Renderer renderer4 = level4.GetComponent<Renderer>();
        // Check if a Renderer component is found
        if (renderer1 != null)
        {
            // Change the material of the GameObject to the new material
            renderer4.material = newMaterial;
        }
        else
        {
            // If there is no Renderer component, log a warning
            Debug.LogWarning("Renderer component not found on this GameObject.");
        }
        Renderer renderer5 = level5.GetComponent<Renderer>();
        // Check if a Renderer component is found
        if (renderer5 != null)
        {
            // Change the material of the GameObject to the new material
            renderer5.material = newMaterial;
        }
        else
        {
            // If there is no Renderer component, log a warning
            Debug.LogWarning("Renderer component not found on this GameObject.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
