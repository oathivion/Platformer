using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotationSpeed = 100f; // Degrees per second

    void Update()
    {
        // Rotate the object continuously around the Z-axis (2D rotation)
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}