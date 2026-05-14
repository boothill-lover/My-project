using UnityEngine;

public class playerScript : MonoBehaviour
{
    GameObject currentCollectible;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectible")
        {
            currentCollectible = other.gameObject;
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
                }
                Destroy(currentCollectible);
            }
        }
    void OnTriggerExit(Collider other)
    {
        if(other.gameObject == currentCollectible)
        {
            currentCollectible = null;
        }
    }
}
