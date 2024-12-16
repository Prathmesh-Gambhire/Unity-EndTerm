using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // Speed of movement

    void Update()
    {
        // Get input from WASD keys or arrow keys
        float horizontal = Input.GetAxis("Horizontal"); // A/D or Left/Right
        float vertical = Input.GetAxis("Vertical");     // W/S or Up/Down

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        // Normalize to ensure consistent movement speed in all directions
        if (movement.magnitude > 1f)
        {
            movement.Normalize();
        }

        // Move the capsule
        transform.Translate(movement * moveSpeed * Time.deltaTime, Space.World);
    }
}
