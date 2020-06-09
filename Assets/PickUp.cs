using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.gameObject.tag == "Pick Up")
        {
            Destroy(target.gameObject);

        }

        else if (target.gameObject.tag == "Pick Up 2")
        {
            Destroy(target.gameObject);
        }

        else if (target.gameObject.tag == "Pick Up 3")
        {
            Destroy(target.gameObject);
        }




    }
}
