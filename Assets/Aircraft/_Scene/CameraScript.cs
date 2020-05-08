using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject target;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.LookAt(target.transform);

       
        transform.position = 
            Vector3.Lerp(transform.position, target.transform.position+ 
            target.transform.TransformDirection(offset), Time.smoothDeltaTime*5);
    }
}
