using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float offset;

    void Start()
    {
        offset = (this.transform.position - target.position).z;
    }


    void Update()
    {
        this.transform.position = target.transform.position + new Vector3(0, 0, offset);
    }
}
