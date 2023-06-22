using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    public GameObject Player;
    public float speed = 5;
    public bool isFollowing;
    public float step;
    // Start is called before the first frame update
    void Start()
    {
        isFollowing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isFollowing)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, step);
        }
    }
    public void Chase()
    {
        isFollowing = true;
    }
}
