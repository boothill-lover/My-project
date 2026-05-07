using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int collectibles = 0;
    public static int collected = 0;

    void Start()
    {
        collectibles = GameObject.FindGameObjectsWithTag("Collectible").Length;

        print("Total collectibles: " + collectibles);
    }
}
