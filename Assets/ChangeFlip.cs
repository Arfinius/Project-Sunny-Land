using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeFlip : MonoBehaviour
{
    public SpriteRenderer SP;

    public void FlipXTrue()
    {
        SP.flipX = true;
    }

    public void FlipXFalse()
    {
        SP.flipX = false;
    }
}
