using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public string playerTag = "Player"; // Set the tag of your player character
    public Vector3 respawnPoint; // The point where the player will respawn

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            // Destroy the player character
            Destroy(collision.gameObject);

            // Respawn the player at the specified respawn point after a delay
            Invoke("RespawnPlayer", 1f); // Delay for 1 second (adjust as needed)
        }
    }

    void RespawnPlayer()
    {
        // Assuming you have a way to respawn the player, like instantiating it at the spawn point
        GameObject player = Instantiate(Resources.Load("PlayerPrefab"), respawnPoint, Quaternion.identity) as GameObject;
    }
}
