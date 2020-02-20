using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAudio : MonoBehaviour
{
    public AudioClip soundOne;
    public AudioClip soundTwo;
    public AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        myAudioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myAudioSource.clip = soundOne;
            myAudioSource.Play();
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            myAudioSource.clip = soundTwo;
            myAudioSource.Play();
        }
    }
}
