using UnityEngine;

public class TeleportationPanelController : MonoBehaviour
{
    public GameObject teleportationPanel;

    private void OnTriggerEnter(Collider other)
    {
            teleportationPanel.SetActive(true); // Activate the panel when the player enters the teleportation area
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Assuming the player has a "Player" tag
        {
            teleportationPanel.SetActive(false); // Deactivate the panel when the player exits the teleportation area
        }
    }
}

