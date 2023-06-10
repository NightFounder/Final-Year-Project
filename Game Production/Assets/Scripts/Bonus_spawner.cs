using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus_spawner : MonoBehaviour
{

    public GameObject Bonus1;


    private void Start()
    {

        
    }

    public void Spawn_bonus()
    {
        GameObject enemies = Instantiate(Bonus1, transform.position, Quaternion.identity);
        print("Spawn bonus");
    }
}
