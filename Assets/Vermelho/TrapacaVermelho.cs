using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapacaVermelho : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public Rigidbody rb2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "TrapacaV")
            rb.velocity += new Vector3(0.4f, 0.0f, 0.0f);
        if (other.name == "TrapacaV2")
            rb.mass = 1000;
        if (other.name == "TrapacaV4")
            rb.velocity += new Vector3(-0.25f, 0.0f, 0.0f);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "TrapacaV3")
        {
            rb.mass = 100;
            rb2.AddForce(200, 250, 0, ForceMode.Impulse);
        }
    }
}
