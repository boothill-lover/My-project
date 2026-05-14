using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int totalPossibleScore = 0;
    public static int totalScore = 0;

    void Start()
    {
        GameObject[] collectibleObjects = GameObject.FindGameObjectsWithTag("Collectible");
        foreach (GameObject obj in collectibleObjects)
        {
            Collectible collectible = obj.GetComponent<Collectible>();
            if (collectible != null)
            {
                totalPossibleScore += collectible.score;
            }
        }

        print("Total possible score: " + totalPossibleScore);
    }
}
