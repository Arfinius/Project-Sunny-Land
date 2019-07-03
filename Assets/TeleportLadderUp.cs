using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportLadderUp : MonoBehaviour
{
    public GameObject target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            target.transform.position = new Vector3(-13f, -1.073f, 0.3f);
        }
    }
}
