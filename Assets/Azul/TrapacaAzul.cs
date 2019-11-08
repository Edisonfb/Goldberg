using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapacaAzul : MonoBehaviour
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

    private void OnTriggerStay(Collider other)
    {
        if (other.name == "TrapacaA")
            rb.velocity += new Vector3(-0.3f, 0.0f, 0.0f);
        if (other.name == "TrapacaA2")
            rb.velocity += new Vector3(-0.3f, 0.0f, 0.0f);
    }
}
