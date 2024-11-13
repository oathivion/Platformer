using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsticle : MonoBehaviour
{
    private Respawn gameManager;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            gameManager.DestroyPlayer();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<Respawn>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
