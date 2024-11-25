using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Vector3 respawnPoint; // The point where the player will respawn

    void Start()
    {
        transform.position = respawnPoint;
    }

    public void RespawnPlayer()
    {
        transform.position = respawnPoint;
    }
}
