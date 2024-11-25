using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public string playerTag = "Player"; 
    public Vector3 respawnPoint; 

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(playerTag))
        {
            // Destroy the player character if colliding
            Destroy(collision.gameObject);

       
            Invoke("RespawnPlayer", 1f); // Delay for 1 second 
        }
    }

    void RespawnPlayer()
    {
        // Assuming you have a way to respawn the player, like instantiating it at the spawn point
        GameObject player = Instantiate(Resources.Load("PlayerPrefab"), respawnPoint, Quaternion.identity) as GameObject;
    }
}
