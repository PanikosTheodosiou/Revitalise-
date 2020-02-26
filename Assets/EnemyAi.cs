using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAi : MonoBehaviour
{
    public float speed;
    public bool movingRight = true;
    public float SwitchDistance = 2;

    public GameObject WayPointA;
    public GameObject WayPointB;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       // Debug.Log(Vector2.Distance(this.transform.position, WayPointA.transform.position));

        if (movingRight == true)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            Debug.Log(Vector2.Distance(this.transform.position, WayPointA.transform.position));
            if (Vector2.Distance(this.transform.position, WayPointA.transform.position) <= SwitchDistance)
            {
                movingRight = false;
            }
        }
        else
        {
            transform.Translate(Vector2.right * -speed * Time.deltaTime);

            if (Vector2.Distance(this.transform.position, WayPointB.transform.position) <= SwitchDistance)
            {
                movingRight = true;
            }
        }

      
    }
}

