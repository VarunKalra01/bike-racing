using UnityEngine;

public class AudioBackground : MonoBehaviour
{
    public AudioSource backgroundMusic; // Reference to the AudioSource component
    private bool isMuted = false; // To keep track of the mute state

    void Start()
    {
        // Ensure the backgroundMusic reference is set
        if (backgroundMusic == null)
        {
            backgroundMusic = GetComponent<AudioSource>();
        }

        if (backgroundMusic == null)
        {
            Debug.LogError("AudioSource component missing.");
        }
    }

    // Method to toggle mute state
    public void ToggleMute()
    {
        if (backgroundMusic != null)
        {
            isMuted = !isMuted;
            backgroundMusic.mute = isMuted;
        }
    }
}
