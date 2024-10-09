using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMover : MonoBehaviour
{

    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity != new Vector3(0,0,0))
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += new Vector3(1,0,0);
            } 
            else if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position -= new Vector3(1, 0, 0);
            }
        }
    }
}
