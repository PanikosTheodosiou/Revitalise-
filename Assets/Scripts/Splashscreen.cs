using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splashscreen : MonoBehaviour
{
    public float speed;
    public bool animationComplete = false;

    public RectTransform spalshText;
    // Start is called before the first frame update
    void Start()
    {
        spalshText.localScale = Vector3.zero;
        LeanTween.scale(spalshText, Vector3.one, speed).setEaseOutQuad().setOnComplete(ButtonsComplete);

    }

    // Update is called once per frame
    void Update()
    {
        if (animationComplete == true)
        {
            if(Input.GetKey(KeyCode.Return))
            {
                Application.LoadLevel(1);
            }
        }
    }

    void ButtonsComplete()
    {
        animationComplete = true;
    }
}
