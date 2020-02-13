using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public bool rapidFire = false; 
    

    /*
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("destroybullet" + collision);
        Destroy(this.gameObject);

    }
    */


    void OnTriggerEnter2D(Collider2D col)
    {
        return;
        /*
        
        if (rapidFire == true)
        {
            Debug.Log("GameObject2 collided with " + col.tag);
            if (col.tag != "Player")
            {
                Destroy(this.gameObject);
            }
        }
       */

    }


    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}
