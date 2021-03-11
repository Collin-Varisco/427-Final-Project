using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    public Transform player = null;

    void Update()
    {
        this.transform.LookAt(player);        
    }
}
