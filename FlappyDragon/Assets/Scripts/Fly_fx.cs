using UnityEngine;

public class Fly_fx : MonoBehaviour
{
    [SerializeField] private AudioClip AudioFly;
    private AudioSource audioSource;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((Input.GetKeyDown(KeyCode.Space)) || (Input.GetMouseButtonDown(0)))
        {
            SoundManager.Instance.PlaySound(AudioFly);

            
        }
    }
}
