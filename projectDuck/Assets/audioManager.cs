using UnityEngine;

public class audioManager : MonoBehaviour
{
    public AudioClip[] sounds;
    private AudioSource playSound;
 
    private void Start()
    {
        playSound = gameObject.GetComponent<AudioSource>();
    }

}
