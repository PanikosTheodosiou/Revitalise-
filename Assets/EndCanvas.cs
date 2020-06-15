using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndCanvas : MonoBehaviour
{
   private Canvas myCanvas;
    // Use this for initialization
    void Start()
    {
        myCanvas = GetComponent<Canvas>();

    }

    void OnTriggerEnter(Collision other)
    {
        myCanvas.enabled = true;
    }

    void OnTriggerExit()
    {
        {
            myCanvas.enabled = false;
        }
    }
}
