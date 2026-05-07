using UnityEngine;

public class CollisionScript : MonoBehaviour
{
     void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "PlayerCapsule")
        {
            GameManager.collected++;
            print("Collected: " + GameManager.collected);
            Destroy(gameObject);
        }
    }
}
