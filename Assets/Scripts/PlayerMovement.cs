using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1;
    public float JumpForce = 75;
    public Rigidbody2D rb;
 
    //This is for the amount of jumps the player can do
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
            this.transform.Translate(Speed *Time.deltaTime,0,0);  
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

    void OnCollisionEnter2D(Collision2D ColObject)
    {
        Debug.Log("OnCollisionEnter2D" + "collided with: " + ColObject.gameObject.name);
        Jumps = 2;
    }

}
