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
    public GameObject target;

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
    void LookAt2D(GameObject target)
    {
        var dir = target.transform.position - transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }
    // Update is called once per frame
    void Update()
    {

        this.transform.Translate(Vector3.right * 5 * Time.deltaTime);
        proxone = Vector2.Distance(this.transform.position, EnemyOne.transform.position);
        proxtwo = Vector2.Distance(this.transform.position, EnemyTwo.transform.position);
        

        if (proxone < proxtwo)
        {
            target = EnemyOne;
            Debug.Log("EnemyOne");
            Debug.DrawLine(transform.position, EnemyOne.transform.position, Color.white);
        }
        else
        {
            target = EnemyTwo;
            Debug.Log("EnemyTwo");
            Debug.DrawLine(transform.position, EnemyTwo.transform.position, Color.gray);
        }
        LookAt2D(target);
    }
}
