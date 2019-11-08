using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject go;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (go.transform.position.y > 2.8f)
            go.transform.position -= new Vector3(0.0f, 0.008f, 0.0f);
    }
}
