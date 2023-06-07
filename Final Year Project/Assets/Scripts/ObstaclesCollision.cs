using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public Obstacles1Speed movement;

    // Start is called before the first frame update
    void OnCollisionEnter(Collision collisioninfo)
    {
        if (collisioninfo.collider.name == "Player")
        {
            movement.enabled = false;
        }

    }
}
