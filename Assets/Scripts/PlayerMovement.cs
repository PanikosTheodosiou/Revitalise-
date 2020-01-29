﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1;
    public float JumpForce = 75;
    public Rigidbody2D rb;
    public int Jumps = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Speed*Time.deltaTime,0,0);  
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-Speed * Time.deltaTime, 0, 0);
        }

        //"if this is true AND this is true"
        if (Jumps > 0 && Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * JumpForce);
            Jumps--;
        }

       










    }
}
