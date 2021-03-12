using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooter : MonoBehaviour
{
    public Transform player = null;
    public GameObject cannonball = null;

    public float minDelay = 2.0f;
    public float maxDelay = 4.0f;

    private float lastFired = 0.0f;
    private float delay = 0.0f;

    private void Update()
    {
        TrackPlayer();
        ShootCannon();
    }

    void TrackPlayer ()
    {
        this.transform.LookAt(player);
    }

    void ShootCannon()
    {
        if (Time.time > lastFired + delay)
        {
            lastFired = Time.time;
            delay = GetRandom();
            GameObject obj;
            obj = Instantiate(cannonball, this.transform.position, this.transform.rotation) as GameObject;
            obj.GetComponent<Rigidbody>().AddForce(transform.forward*10000.0f);

        }
    }

    float GetRandom()
    {
        return Random.Range(minDelay, maxDelay);
    }

}
