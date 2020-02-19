using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public EnemyAi[] enemies;
    public GameObject EnemyOne;
    public GameObject EnemyTwo;
    public float proxone;
    public float proxtwo;
    /*
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("destroybullet" + collision);
        Destroy(this.gameObject);

    }
    */


    void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("GameObject2 collided with " + col.tag);
        if (col.tag != "Player")
        {
            Destroy(this.gameObject);
        }
        
    }


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {


        proxone = Vector2.Distance(this.transform.position, EnemyOne.transform.position);
        proxtwo = Vector2.Distance(this.transform.position, EnemyTwo.transform.position);

        if (proxone < proxtwo)
        {

            Debug.Log("EnemyOne");
            Debug.DrawLine(transform.position, EnemyOne.transform.position, Color.white);
        }
        else
        {
            Debug.Log("EnemyTwo");
            Debug.DrawLine(transform.position, EnemyTwo.transform.position, Color.gray);
        }
    }
}
