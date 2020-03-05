using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontalInput, 0, verticalInput) * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log("collision");



        if (collision.gameObject.CompareTag("Rob"))
        {
            Debug.Log("My name is Rob");
        }
        else if(collision.gameObject.CompareTag ("Enemy"))
        {
            Debug.Log("I am the Enemy");
        }
    }
}
