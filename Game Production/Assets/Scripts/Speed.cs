using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : MonoBehaviour
{
    

    public float speed;
    private float leftEdge;


    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 30f;
    }


    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if (transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }


    }

    public void IncreaseSpeed2()
    {
        speed = 2;
    }

    public void IncreaseSpeed3()
    {
        speed = 3;
    }

    public void IncreaseSpeed4()
    {
        speed = 4;
    }

    public void IncreaseSpeed5()
    {
        speed = 5;
    }



}
