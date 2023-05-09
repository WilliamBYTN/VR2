using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReParentOnTrigger : MonoBehaviour
{
    public GameObject gorillaRigObject;
    public GameObject gorillaPlayerObject;
    public GameObject rotatingPlatform;
    private bool triggerIsActive;

    void Start()
    {
        triggerIsActive = false;
    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log(transform.name + " -> " + other.transform.name + " [collision stay]");

        Collider[] colliders = gorillaRigObject.GetComponentsInChildren<Collider>();

        for(int i = 0; i < colliders.Length; i++) 
        {
            if (other.transform.name == colliders[i].transform.name)
            {
                triggerIsActive = true;
                gorillaRigObject.transform.SetParent(rotatingPlatform.transform, true);
                break;
            }
        }
    }

    private void FixedUpdate()
    {
        triggerIsActive = false;
    }

    private void LateUpdate()
    {
        if (!triggerIsActive)
        {
            gorillaRigObject.transform.SetParent(null, true);
        }
    }
}
