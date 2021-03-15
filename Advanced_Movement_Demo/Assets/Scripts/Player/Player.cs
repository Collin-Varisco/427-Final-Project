using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public int health;
    public int score;
    public bool safe = false;

    public void Start()
    {
        health = 100;
        score = 0;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("cannonball"))
        {
           health -= 20;
           Destroy(other.gameObject); 
        }


        if(other.gameObject.CompareTag("SafeZone"))
        {
            safe = true;
        } else {
            safe = false;
        }
    }
}