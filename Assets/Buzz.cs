using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buzz : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go;
    public GameObject go1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.name == "buzz")
        {
            go.GetComponent<MeshRenderer>().enabled = true;
            go1.transform.position = new Vector3(-0.32f, 5.67f, -21.76f);
            go1.GetComponent<CameraScript>().enabled = false;
        }
    }
}
