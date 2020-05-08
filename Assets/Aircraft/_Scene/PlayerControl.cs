using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public Rigidbody rdb;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        anim.SetFloat("velocity", rdb.velocity.magnitude);
        float axisforce = Input.GetAxis("Horizontal");
        rdb.AddForce(transform.forward * axisforce * 2000);
    }
}
