using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public EnemyAi[] enemies;
    public float destroyTime;
    public float velocity;
    public float speed;
    Renderer m_Renderer;
    public float distanceTrack = 10;
    bool lockOn = false;

    //public List<EnemyAi>
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
        m_Renderer = GetComponent<Renderer>();

        enemies = GameObject.FindObjectsOfType<EnemyAi>();

        if (enemies.Length < 1)
        {
            return;
        }

        //Pick out a enemy to compare others agaisnt
        GameObject closestEnemy = enemies[0].gameObject;

        //A for loop to cycle through each enemy within the list if theres 5 enemies this will loop 5 times , 
        //the int i will also increment each loop "i++ is the same as +1"

        for (int i = 0; i < enemies.Length; i++)
        {
            //if the closest Enemy is not the same to the current element within the enemies list

            if (enemies[i].gameObject != closestEnemy)
            {
                //we find the distance between the current closest enemy and the currently cycled element

                float closestEnemyDistance = Vector2.Distance(this.transform.position, closestEnemy.transform.position);
                float nextEnemyDistance = Vector2.Distance(this.transform.position, enemies[i].transform.position);


                if (!(closestEnemyDistance < nextEnemyDistance))
                {
                    closestEnemy = enemies[i].gameObject;
                }


                // now from the distance values pick which enemy is the closest then assign it as the current target

                Debug.Log("closestEnemyDistance :" + closestEnemyDistance.ToString() + "  nextEnemyDistance :" + nextEnemyDistance.ToString());


            }



        }


        Debug.DrawLine(transform.position, closestEnemy.transform.position, Color.yellow);

        if (Vector2.Distance(transform.position, closestEnemy.transform.position) < distanceTrack)
        {
            LookAt2D(closestEnemy);
        }

    }
    //  Destroy(this.gameObject, destroyTime);


    void LookAt2D(GameObject target)
    {
        var dir = target.transform.position - transform.position;
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

    }
    // Update is called once per frame
    void Update()
    {

  

        this.transform.Translate(Vector3.right * speed * Time.deltaTime);




        //proxone = Vector2.Distance(this.transform.position, EnemyOne.transform.position);
        //proxtwo = Vector2.Distance(this.transform.position, EnemyTwo.transform.position);


        //if (proxone < proxtwo)
        //{
        //    target = EnemyOne;
        //    Debug.Log("EnemyOne");
        //    Debug.DrawLine(transform.position, EnemyOne.transform.position, Color.white);
        //}
        //else
        //{
        //    target = EnemyTwo;
        //    Debug.Log("EnemyTwo");
        //    Debug.DrawLine(transform.position, EnemyTwo.transform.position, Color.gray);
        //}


    }
}
