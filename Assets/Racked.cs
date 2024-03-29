using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Racked : MonoBehaviour
{
    public float speed = 150.0f;

    private void FixedUpdate()
    {
        float horizontalDirection = Input.GetAxisRaw("Horizontal");

        GetComponent<Rigidbody2D>().velocity = Vector2.right * horizontalDirection * speed;
    }
}
