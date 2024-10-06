using UnityEngine;

public class Death_fx : MonoBehaviour
{
    [SerializeField] private AudioClip AudioDeath;
    private AudioSource audioSource;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            SoundManager.Instance.PlaySound(AudioDeath);
            Debug.Log("AudioDeath Played");
        }
    }
}
