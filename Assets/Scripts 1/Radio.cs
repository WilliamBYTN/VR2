using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Radio : MonoBehaviour
{
    public AudioSource Music;
    //private bool musicPlaying = true;
    void Start()
    {
        Music = GetComponent<AudioSource>();
        //musicPlaying = true;
        Music.Play(0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.name == "Hand")
        {
            if (Music.isPlaying)
            {
                Music.Stop();
            }
            else
            {
                Music.Play(0);
            }
        }
        //else
        //{
            //musicPlaying = true;
        //}
    }
    //void Update()
    //{
        //if(musicPlaying)
        //{
            //Music.Play(0);
        //}
        //else
        //{
            //Music.Stop();
        //}
    //}
}
