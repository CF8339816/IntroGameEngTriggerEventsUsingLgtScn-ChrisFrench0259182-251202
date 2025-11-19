using UnityEngine;

public class CharacterMovementAudio : MonoBehaviour
{
    public AudioSource footstepAudioSource; // Assign in Inspector

    private bool isMoving;

    void Update()
    {
        // Example: Check if horizontal or vertical input is active
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (Mathf.Abs(horizontalInput) > 0.1f || Mathf.Abs(verticalInput) > 0.1f)
        {
            if (!isMoving)
            {
                footstepAudioSource.Play();
                isMoving = true;
            }
        }
        else
        {
            if (isMoving)
            {
                footstepAudioSource.Stop();
                isMoving = false;
            }
        }
    }
}