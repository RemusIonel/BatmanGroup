using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    float horPos;
    float verPos;
    Vector2 velocity;
    float speed = 4f;
    float gravity = -9.81f;
    float jumpHeight = 2f;
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        verPos += gravity * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        horPos = Input.GetAxisRaw("Horizontal");
        Jump();

    }

    void Jump()
    {
       
    }
}
