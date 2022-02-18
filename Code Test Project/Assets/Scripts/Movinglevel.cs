using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movinglevel : MonoBehaviour
{
    public Vector2 pos1 = new Vector2(213, -3);
    public Vector2 pos2 = new Vector2(213, 38);
    public float speed = 1.0f;
    

    void Update()
    {
        transform.position = Vector2.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}