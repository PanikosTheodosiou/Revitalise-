using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed = 1;
    public float JumpForce = 75;
    public Rigidbody2D rb;
    public GameObject SpawnPoint;
    public GameObject PlayerProjectile;

    public float ProjectileVelocityMin = 500;
    public float ProjectileVelocityMax = 999;



    //This is for the amount of jumps the player can do
    public int Jumps = 2;

    [Header ("Is Grounded")]
    public bool IsGrounded;

    Vector3 _startPos;

    [Header("DEBUG")]
    public bool DebugMode;
    public Color HistoryColour;
    public float HistoryDuration;
    public bool HistoryPerm = true;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = SpawnPoint.transform.position; 
    }

    // Update is called once per frame
    void Update()
    { //Bullet Spawn
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clonedBullet = Instantiate(PlayerProjectile);
            clonedBullet.transform.position = this.transform.position + new Vector3 (1.6f,0,0);
            clonedBullet.GetComponent<Rigidbody2D>().AddForce(Vector2.right * Random.Range(ProjectileVelocityMin,ProjectileVelocityMax));

        }


        if (DebugMode)
        {
            if(HistoryPerm)
            Debug.DrawLine(transform.position, transform.position + Vector3.up * .2f, HistoryColour, Mathf.Infinity);
            else
                Debug.DrawLine(transform.position, transform.position + Vector3.up * .2f, HistoryColour, HistoryDuration);
        }
        Debug.Log(rb.velocity);

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

    private void OnCollisionExit2D(Collision2D CollisionInfo)
    {
        if (CollisionInfo.gameObject.tag == "Ground")
        {
            IsGrounded = false;
        }
    }

    void OnCollisionEnter2D(Collision2D CollisionInfo)
    {
       
        //ColObject.gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 1);
        //Destroy(ColObject.gameObject);

        if (CollisionInfo.gameObject.tag == "Ground")
        {
            Jumps = 2;
            IsGrounded = true;
            //Debug.Log("OnCollisionEnter2D" + "collided with: " + CollisionInfo.gameObject.name);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Death Barrier")
        {
            //Debug.Log("youdied");
            this.transform.position = SpawnPoint.transform.position;
        }
      
     
    }

}
