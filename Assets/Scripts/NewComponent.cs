using UnityEngine;
using UnityEngine.UIElements;


public class NewComponent : MonoBehaviour
{

    Vector3 moveUp = new Vector3(0, 0.05f, 0);
    Vector3 moveDown = new Vector3(0, -0.05f, 0);

    bool goingUp = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        print(transform.position.x);
        print(transform.position.y);
        print(transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 50);
        if (goingUp)
    {
        transform.position += moveUp;
        if (transform.position.y > 3.0f)
        {
            goingUp = false;
        }
    }
    else
    {
        transform.position += moveDown;
        if (transform.position.y < -3.0f)
        {
            goingUp = true;
        }
    }
    }
}
