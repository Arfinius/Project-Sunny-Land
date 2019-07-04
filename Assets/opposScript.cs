using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opposScript : MonoBehaviour
{
    public HpBar hpBar;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            hpBar.HpSubstractionWhenK();
        }
    }
}
