using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
public class END : MonoBehaviour
{
    public Canvas endCanvas;
    // Start is called before the first frame update
    void Start()
    {
        endCanvas = GetComponent<Canvas>();
    }

     void OnTriggerEnter2D(Collider2D collision)
    {
        endCanvas.enabled = true;
    }


    // Update is called once per frame
    void Update()
    {
       
    }
}
