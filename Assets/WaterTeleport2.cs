using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterTeleport2 : MonoBehaviour
{
    public GameObject target;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            target.transform.position = new Vector3(-3.5f, 1f, 0.3f);
        }
    }
}
