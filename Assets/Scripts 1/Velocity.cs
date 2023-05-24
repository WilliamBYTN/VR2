using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Velocity : MonoBehaviour
{
    public GameObject gorillaRig;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PendulumBall")
        {
            Debug.Log("Got Enter");
            Rigidbody rb = other.GetComponent<Rigidbody>();
            gorillaRig.transform.Translate(rb.velocity);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.name == "PendulumBall")
        {
            Debug.Log("Got Stay");
            Rigidbody rb = other.GetComponent<Rigidbody>();
            gorillaRig.transform.Translate(rb.velocity);
        }
    }
}

