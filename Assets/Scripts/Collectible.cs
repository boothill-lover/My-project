using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int score = 1;

    AudioSource collectibleAudio;

    void Start()
    {
        collectibleAudio = GetComponent<AudioSource>();
    }

    public void Collect()
    {
        if (collectibleAudio != null)
        {
            collectibleAudio.Play();
            Destroy(gameObject, collectibleAudio.clip.length);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}