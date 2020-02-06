using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proj : MonoBehaviour
{
    private List<GameObject> Projectiles = new List<GameObject>();
    public GameObject Projectile;
    public float ProjectileVelocity;

    public Vector3 CapsuleDirection2D { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CapsuleDirection2D = Input.mousePosition;
        CapsuleDirection2D = Camera.main.ScreenToWorldPoint(CapsuleDirection2D);
        CapsuleDirection2D = CapsuleDirection2D - transform.position;
        if (Input.GetMouseButtonDown(0))
        {
            GameObject 
        }




      
        
    }
}
