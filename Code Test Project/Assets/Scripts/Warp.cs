using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    public Transform warpTo;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!TheGameManager.justWarped)
        {
            collision.gameObject.transform.position = warpTo.position;
            TheGameManager.justWarped = true;
        }else if (TheGameManager.justWarped)
        {
            TheGameManager.justWarped = false;
        }
    }
}
