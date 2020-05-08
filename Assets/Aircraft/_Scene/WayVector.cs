using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayVector : MonoBehaviour
{

    public Transform[] waypoints;
    // Start is called before the first frame update
    void Start()
    {
       // waypoints = GetComponentsInChildren<Transform>();
       
       for(int i = 1; i <= waypoints.Length; i++)
        {
            Vector3 dir = waypoints[i + 1].position- waypoints[i].position;
            waypoints[i].transform.forward = dir;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
