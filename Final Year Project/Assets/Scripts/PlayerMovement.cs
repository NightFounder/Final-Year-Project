using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public UDPReceive udpReceive;
    public Rigidbody rb;

    public Transform Transform;

    public float forwardforce = 500f;
    public float sidewayforce = 350f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        ///all combined to average one

        string data = udpReceive.data;
        data = data.Remove(0, 1);
        data = data.Remove(data.Length - 1, 1);
        string[] points = data.Split(',');

        //x = points[0]
        //y = points[1]
        float x = float.Parse(points[9*3]) + 50;
        float y = float.Parse(points[1]);
        //print(y);

        //print (Transform.position.x);

        if (x>=70 && x<=650)
        {
            float new_x = (x * 11.99f / 580.0f) - 1.44f;
            //print (new_x);
            rb.AddForce(0, 0, forwardforce * Time.deltaTime);
            Transform.position = new Vector3 (new_x, Transform.position.y, Transform.position.z);

        }


        //rb.AddForce(0, 0, forwardforce * Time.deltaTime);
        //if(Input.GetKey("d"))
        //if (x<450)
        //{
        //    //rb.AddForce(0, 0, -700 * Time.deltaTime);
        //    rb.AddForce(sidewayforce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        //}

        //if (Input.GetKey("a"))
        //if (x > 750)
        //{
        //    rb.AddForce(-sidewayforce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        //}

        //ForceMode.VelocityChange


        //if (Input.GetKey("s"))
        if (y >=370)
        {
            rb.AddForce(0, 0, -700 * Time.deltaTime);
            //rb.AddForce(sidewayforce * Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }

        FindObjectOfType<GameManager_S>().IncreaseTimer();



    }



}
