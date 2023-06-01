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
    public GameObject Hand1;
    public GameObject Hand2;
    public Material Red;
    public Material Orange;
    public Material Yellow;
    public Material Lime;
    public Material Green;
    public Material DarkGreen;
    public Material DarkBlue;
    public Material Blue;
    public Material LightBlue;
    public Material Pink;
    public Material Magenta;
    public Material Purple;
    public Material Black;
    public Material DarkGray;
    public Material Gray;
    public Material White;

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
        if (other.tag == "Red")
        {
            Hand1.GetComponent<MeshRenderer>().material = Red;
            Hand2.GetComponent<MeshRenderer>().material = Red;
        }
        if (other.tag == "Orange")
        {
            Hand1.GetComponent<MeshRenderer>().material = Orange;
            Hand2.GetComponent<MeshRenderer>().material = Orange;
        }
        if (other.tag == "Yellow")
        {
            Hand1.GetComponent<MeshRenderer>().material = Yellow;
            Hand2.GetComponent<MeshRenderer>().material = Yellow;
        }
        if (other.tag == "Lime")
        {
            Hand1.GetComponent<MeshRenderer>().material = Lime;
            Hand2.GetComponent<MeshRenderer>().material = Lime;
        }
        if (other.tag == "Green")
        {
            Hand1.GetComponent<MeshRenderer>().material = Green;
            Hand2.GetComponent<MeshRenderer>().material = Green;
        }
        if (other.tag == "Dark Green")
        {
            Hand1.GetComponent<MeshRenderer>().material = DarkGreen;
            Hand2.GetComponent<MeshRenderer>().material = DarkGreen;
        }
        if (other.tag == "Dark Blue")
        {
            Hand1.GetComponent<MeshRenderer>().material = DarkBlue;
            Hand2.GetComponent<MeshRenderer>().material = DarkBlue;
        }
        if (other.tag == "Blue")
        {
            Hand1.GetComponent<MeshRenderer>().material = Blue;
            Hand2.GetComponent<MeshRenderer>().material = Blue;
        }
        if (other.tag == "Light Blue")
        {
            Hand1.GetComponent<MeshRenderer>().material = LightBlue;
            Hand2.GetComponent<MeshRenderer>().material = LightBlue;
        }
        if (other.tag == "Pink")
        {
            Hand1.GetComponent<MeshRenderer>().material = Pink;
            Hand2.GetComponent<MeshRenderer>().material = Pink;
        }
        if (other.tag == "Magenta")
        {
            Hand1.GetComponent<MeshRenderer>().material = Magenta;
            Hand2.GetComponent<MeshRenderer>().material = Magenta;
        }
        if (other.tag == "Purple")
        {
            Hand1.GetComponent<MeshRenderer>().material = Purple;
            Hand2.GetComponent<MeshRenderer>().material = Purple;
        }
        if (other.tag == "Black")
        {
            Hand1.GetComponent<MeshRenderer>().material = Black;
            Hand2.GetComponent<MeshRenderer>().material = Black;
        }
        if (other.tag == "Dark Gray")
        {
            Hand1.GetComponent<MeshRenderer>().material = DarkGray;
            Hand2.GetComponent<MeshRenderer>().material = DarkGray;
        }
        if (other.tag == "Gray")
        {
            Hand1.GetComponent<MeshRenderer>().material = Gray;
            Hand2.GetComponent<MeshRenderer>().material = Gray;
        }
        if (other.tag == "White")
        {
            Hand1.GetComponent<MeshRenderer>().material = White;
            Hand2.GetComponent<MeshRenderer>().material = White;
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
