﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed = 18;
    Rigidbody2D rbody;
    Animator anim;

    // Use this for initialization
    void Start()
    {

        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();


    }

    void Update()
    {

        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed * Time.fixedDeltaTime;

        if (movement_vector != Vector2.zero)
        {
            anim.SetBool("iswalking", true);
            anim.SetFloat("Input_x", movement_vector.x);
            anim.SetFloat("Input_y", movement_vector.y);
        }
        else
        {
            anim.SetBool("iswalking", false);
        }
        rbody.MovePosition(rbody.position + movement_vector);
    }
}

