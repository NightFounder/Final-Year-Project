using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cross_Road : MonoBehaviour
{
    public Transform Transform;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform.position = new Vector3(Transform.position.x + 0.01f, Transform.position.y, Transform.position.z);
    }
}
