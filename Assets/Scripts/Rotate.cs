using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 100f; // Degrees per second

    void Update()
    {
        //the actual rotation
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}