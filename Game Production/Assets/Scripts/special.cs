using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class special : MonoBehaviour
{
    public float speed=3;
    private float leftEdge;

    public float UpEdge;
    public float DownEdge;




    private void Start()
    {
        leftEdge = Camera.main.ScreenToWorldPoint(Vector3.zero).x - 30f;
    }


    private void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" || transform.position.x < leftEdge)
        {
            Destroy(gameObject);
        }
    }
}
