using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooter : MonoBehaviour
{
public Transform player = null;
public GameObject cannonball = null;

public float minDelay = 1.0f;
public float maxDelay = 4.0f;

private float lastTime = 0.0f;
private float delayTime = 0.0f;


private void Update()
{
    FollowPlayer();
    Shoot();
}

void FollowPlayer ()
{
this.transform.LookAt(player);
}

void Shoot()
{
if (Time.time > lastTime + delayTime )
{
lastTime = Time.time;
delayTime = GetRandomValue();


    GameObject obj;
    obj = Instantiate(cannonball, this.transform.position, this.transform.rotation) as GameObject;
    obj.GetComponent<Rigidbody>().AddForce(transform.forward*3000.0f);
//GameObject obj = Instantiate(cannonball, this.transform.position, this.transform.rotation) as GameObject;

obj.name = "cannonball";
}
}

float GetRandomValue ()
{
return Random.Range(minDelay, maxDelay);
}

}
