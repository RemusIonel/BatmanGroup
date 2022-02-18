using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDamage : MonoBehaviour
{
    int damageAmount = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageObject damagedObject = collision.gameObject.GetComponent<DamageObject>();

        if(damagedObject != null)
        {
            damagedObject.DealDamage(damageAmount);
            Destroy(gameObject);
        }

        Destroy(gameObject);
    }
}
