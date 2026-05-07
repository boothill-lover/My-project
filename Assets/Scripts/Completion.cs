using UnityEngine;

public class Completion : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "PlayerCapsule")
        {
            if(GameManager.collected == GameManager.collectibles)
            {
                print("Complete");
            }
            else
            {
                print("Collect all items first!");
            }
        }
    }
}
