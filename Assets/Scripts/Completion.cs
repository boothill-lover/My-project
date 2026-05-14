using UnityEngine;

public class Completion : MonoBehaviour
{
     void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "PlayerCapsule")
        {
            if(GameManager.totalScore >= GameManager.totalPossibleScore)
            {
                print("Complete");
            }
            else
            {
                print("Collect all items first! Current score: " + GameManager.totalScore + "/" + GameManager.totalPossibleScore);
            }
        }
    }
}
