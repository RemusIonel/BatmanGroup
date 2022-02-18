using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] Rigidbody2D bullet;
    float bulletSpeed = 20f;
    public Transform spownPoint;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            FireWeapon();
        }
    }

    void FireWeapon()
    {
        Rigidbody2D shot;
        shot = Instantiate(bullet,spownPoint.transform.position,spownPoint.transform.rotation);
        shot.velocity = new Vector3(1.0f, 0f, 0f) * bulletSpeed;
    }
}
