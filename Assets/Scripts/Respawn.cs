using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 respawnPoint; // The point where the player will respawn

    void Start()
    {
        // Optionally, set the initial respawn point at the start of the game
        transform.position = respawnPoint;
    }

    public void RespawnPlayer()
    {
        // Set the player position to the respawn point
        transform.position = respawnPoint;
    }
}
