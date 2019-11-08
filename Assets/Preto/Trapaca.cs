using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapaca : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnCollisionStay(Collision collision)
    {
       // if(collision.GetContact(0))
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "TrapacaP")
            rb.velocity += new Vector3(-0.28f, 0.0f, 0.0f);
        if (other.name == "TrapacaP2")
            rb.velocity += new Vector3(-0.1f, 0.0f, 0.0f);
        if (other.name == "TrapacaP3")
            rb.velocity += new Vector3(0.1f, 0.0f, 0.0f);
    }
}
