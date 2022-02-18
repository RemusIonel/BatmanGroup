using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    [SerializeField] int health = 4;
    public GameObject deathsound;
    public int points;

    public void DealDamage(int damageAmount)
    {
        health -= damageAmount;
        if(health < 0)
        {
            TheGameManager.UpdateScore(points);
            Destroy(gameObject);
            Instantiate(deathsound, transform.position, Quaternion.identity);
        }
    }
}
