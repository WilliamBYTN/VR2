using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public AudioSource Footstep;
    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;
    public GameObject Level5;
    public GameObject Level6;
    public ParticleSystem Particle;

    private ParticleSystem[] _particles;
    private const int maxParticles = 10;
    void Start()
    {
        _particles= new ParticleSystem[maxParticles];

        for (int i = 0; i < maxParticles; i++)
        {
            _particles[i] = Instantiate(Particle);
        }
        Footstep = GetComponent<AudioSource>();
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
            Level4.SetActive(false);
            Level5.SetActive(false);
            Level6.SetActive(false);
        }
        if (other.transform.name == "Level2")
        {
            Debug.Log("got it");
            Level1.SetActive(false);
            Level2.SetActive(true);
            Level3.SetActive(false);
            Level4.SetActive(false);
            Level5.SetActive(false);
            Level6.SetActive(false);
        }
        if (other.transform.name == "Level3")
        {
            Debug.Log("got it");
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(true);
            Level4.SetActive(false);
            Level5.SetActive(false);
            Level6.SetActive(false);
        }
        if (other.transform.name == "Level4")
        {
            Debug.Log("got it");
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(false);
            Level4.SetActive(true);
            Level5.SetActive(false);
            Level6.SetActive(false);
        }
        if (other.transform.name == "Level5")
        {
            Debug.Log("got it");
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(false);
            Level4.SetActive(false);
            Level5.SetActive(true);
            Level6.SetActive(false);
        }
        if (other.transform.name == "Level6")
        {
            Debug.Log("got it");
            Level1.SetActive(false);
            Level2.SetActive(false);
            Level3.SetActive(false);
            Level4.SetActive(false);
            Level5.SetActive(false);
            Level6.SetActive(true);
        }
        if (other.transform.name == "HELL")
        {
            Debug.Log("got it");
            Level1.SetActive(true);
            Level2.SetActive(true);
            Level3.SetActive(true);
            Level4.SetActive(true);
            Level5.SetActive(true);
            Level6.SetActive(true);
        }
        if (other.transform.tag == "Platform")
        {
            Footstep.Play(0);

            for (int i = 0; i < maxParticles; i++)
            {
                if (_particles[i].gameObject.activeSelf == false)
                {
                    _particles[i].transform.position = transform.position;
                    _particles[i].gameObject.SetActive(true);
                    return;
                }
            }

            
            //Particle.gameObject.SetActive(true);

        }
    }
}
