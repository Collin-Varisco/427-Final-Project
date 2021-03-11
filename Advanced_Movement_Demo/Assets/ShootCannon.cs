using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootCannon : MonoBehaviour
{
    public GameObject player;
    public GameObject cannonball;
    private float timer = 0.0f;
    public float fire_rate = 3.0f;

    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        //Aim(); 
        timer += Time.deltaTime;
        if(timer >= 2.0f){
            timer = 0;
        
            GameObject obj;
            obj = Instantiate(cannonball, this.transform.position, this.transform.rotation) as GameObject;
            obj.GetComponent<Rigidbody>().AddForce(transform.forward*3000.0f);
        
        }
    }
}
