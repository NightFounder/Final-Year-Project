using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class family_movement2 : MonoBehaviour
{
    public Transform Transform;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform.position = new Vector3(Transform.position.x, Transform.position.y, Transform.position.z - 0.05f);
    }
}
