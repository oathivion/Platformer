using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    public GameObject playerPrefab;
    public Transform respawnPoint;
    private GameObject currentPlayer;
    // Start is called before the first frame update
    void Start()
    {
        RespawnPlayer();
    }

    public void RespawnPlayer()
    {
        if (currentPlayer == null)
        {
            currentPlayer = Instantiate(playerPrefab,respawnPoint.position, Quaternion.identity);
        }
    }

    public void DestroyPlayer()
    {
        if (currentPlayer != null)
        {
            Destroy(currentPlayer);
            Invoke(nameof(RespawnPlayer), 1f);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
