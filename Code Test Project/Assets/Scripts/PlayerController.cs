using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D playerRB;
    float horPos;
    float verPos;
    Vector2 velocity;
    float speed = 15f;
    float gravity = -300f;
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
        playerRB.velocity = new Vector2(horPos * speed, verPos);
        Jump();

    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print("jump");
            playerRB.AddForce(transform.up * 18000f);
        }
    }
}
