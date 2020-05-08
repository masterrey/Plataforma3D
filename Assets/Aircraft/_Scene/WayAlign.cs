using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayAlign : MonoBehaviour
{


    public WayVector waysScript;
    public Rigidbody rdb;
    public int index;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.forward = waysScript.waypoints[index].forward;
        transform.rotation = Quaternion.Slerp(transform.rotation, waysScript.waypoints[index].rotation, Time.deltaTime*100);
        //rdb.MovePosition(waysScript.waypoints[index].position);
        Vector3 dirtogo = waysScript.waypoints[index].position-transform.position;
        dirtogo = dirtogo - Vector3.Project(dirtogo, waysScript.waypoints[index].forward);
        dirtogo = dirtogo - Vector3.Project(dirtogo, Vector3.up);
        rdb.AddForce(dirtogo*1000);

        if(Vector3.Distance(transform.position, waysScript.waypoints[index + 1].position) < 3)
        {
            index++;
        }
    }
}
