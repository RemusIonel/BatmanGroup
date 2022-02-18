using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinPanel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        TheGameManager.winable = true;
    }
}
