using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject target;
    public float maxRotationPerSecond = 30.0f;
    private Quaternion quatVar;

    // Start is called before the first frame update
    void Start()
    {
        quatVar = target.transform.localRotation;        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = target.transform.position - transform.position;
        dist.y = transform.position.y;
        quatVar = Quaternion.LookRotation(dist, Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, quatVar, maxRotationPerSecond * Time.deltaTime);        
    }
}
