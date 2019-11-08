using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapacaVerde : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rg;
    public GameObject go;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "TrapacaVerde")
        {
            rg.mass = 50;
            go.GetComponent<CameraScript>().enabled = true;
        }
    }
}
