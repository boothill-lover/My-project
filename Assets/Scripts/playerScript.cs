using UnityEngine;

public class playerScript : MonoBehaviour
{
    GameObject currentCollectible;
    AudioSource collectibleAudio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    GameObject currentDoor;
    Door currentDoorScript;
    void Start()
    {
        collectibleAudio = GetComponent<AudioSource>();
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectible")
        {
            currentCollectible = other.gameObject;
        }
        
        Door door = other.GetComponentInParent<Door>();

        if(door != null)
        {
            currentDoor = other.gameObject;
            currentDoorScript = door;
        }
    }

    void OnInteract()
        {
            if(currentCollectible != null)
            {
                Collectible collectible = currentCollectible.GetComponent<Collectible>();
                if (collectible != null)
                {
                    GameManager.totalScore += collectible.score;
                    print("Collected: " + collectible.score + " points. Total score: " + GameManager.totalScore);
                    collectible.Collect();
                    currentCollectible = null;
                }
                
            }

            if(currentDoorScript != null)
            {
                currentDoorScript.Interact();
            }
        }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject == currentCollectible)
        {
            currentCollectible = null;
        }

        if(other.gameObject == currentDoor)
        {
            currentDoor = null;
            currentDoorScript = null;
        }
    }
}
