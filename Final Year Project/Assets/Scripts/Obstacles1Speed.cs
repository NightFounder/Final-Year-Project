using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles1Speed : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardforce = 1000f;
    public float sidewayforce = 350f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(0, 0, forwardforce * Time.deltaTime);
    }
}
