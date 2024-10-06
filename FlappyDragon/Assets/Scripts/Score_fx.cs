using UnityEngine;

public class Score_fx : MonoBehaviour
{

    [SerializeField] private AudioClip AudioScore;
    private AudioSource audioSource;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SoundManager.Instance.PlaySound(AudioScore);
            Debug.Log("AudioScore Played");
        }
    }
}
