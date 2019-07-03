using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrankDown : MonoBehaviour
{
    public Animator animator;
    bool alreadyFalse = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player" && alreadyFalse == false)
        {
            animator.SetBool("IsUp", false);
        }
    }
}
