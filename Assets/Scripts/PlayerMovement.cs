using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    //public float speed = 2000f;
    public float sidewaySpeed = 500f;
    public float fbSpeed = 500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, speed * Time.deltaTime);

        if (Input.GetKey("d")){
            rb.AddForce(sidewaySpeed, 0, 0 * Time.deltaTime);
        }

        if (Input.GetKey("a")){
            rb.AddForce(-sidewaySpeed, 0, 0 * Time.deltaTime);
        }

        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, fbSpeed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -fbSpeed * Time.deltaTime);
        }
    }
}
