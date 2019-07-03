using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTeleport : MonoBehaviour
{
    public GameObject target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            target.transform.position = new Vector3(-8.206f, -3.803f, 0.3f);
        }
    }
}
