using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportLadder : MonoBehaviour
{
    public GameObject target;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            target.transform.position = new Vector3(-13.103f, -3.952f, 0.3f);
        }
    }
}
