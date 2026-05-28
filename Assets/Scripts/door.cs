using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator anim;
    bool isOpen = false;

    public void Interact()
    {
        if(isOpen)
        {
            anim.SetTrigger("CloseDoor");
        }
        else
        {
            anim.SetTrigger("OpenDoor");
        }

        isOpen = !isOpen;
    }
}