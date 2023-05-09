using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log(transform.name + " " + other.transform.name);
        if(other.transform.name == "Level1")
        {
            Debug.Log("got it");
            Level1.SetActive(true);
            Level2.SetActive(false);
            Level3.SetActive(false);
        }
        if (other.transform.name == "Level2")
        {
            Debug.Log("got it");
            Level1.SetActive(false);
            Level2.SetActive(true);
            Level3.SetActive(false);
        }
        if (other.transform.name == "Level3")
        {
            Debug.Log("got it");
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(true);
        }
        if (other.transform.name == "HELL")
        {
            Debug.Log("got it");
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(true);
        }
    }
}
