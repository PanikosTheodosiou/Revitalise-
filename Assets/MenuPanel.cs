using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MenuPanel : MonoBehaviour
{
    public RectTransform theMenu;
    public RectTransform startButton;
    public RectTransform optionsButton;
    public RectTransform quitToDesktopButton;
    public UnityEvent buttonsComplete; 
    public float time = 1;
    // Start is called before the first frame update
    void Start()
    {
        startButton.localScale = optionsButton.localScale = quitToDesktopButton.localScale = Vector3.zero;
        LeanTween.move(theMenu, new Vector3(150, 0, 0), time).setEaseInOutElastic().setOnComplete(OnMenuFinish);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void OnMenuFinish()
    {
        LeanTween.scale(startButton, Vector3.one, 1).setEaseInBounce();
        LeanTween.scale(optionsButton, Vector3.one, 1.2f).setEaseInBounce();
        LeanTween.scale(quitToDesktopButton, Vector3.one, 1.4f).setEaseInBounce().setOnComplete(ButtonsComplete); 
    }

    void ButtonsComplete()
    {
        buttonsComplete.Invoke();
    }
}
