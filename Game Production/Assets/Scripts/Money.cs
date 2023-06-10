using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
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


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }


    


}
