
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    public GameObject prefab4;
    public GameObject prefab5;
    public GameObject prefab6;

    public GameObject Special;

    public float minHeight = -2f;
    public float maxHeight = 2f;



    public float spawnRate;



    private void OnEnable()
    {
        //float randomNumber = randomNumber.Range(1, 5);

        //float count = 1* randomNumber;
        //print(count);


        InvokeRepeating(nameof(Spawn), 1, spawnRate);
    }


    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }


    private void Spawn()
    {
        int random = Random.Range(1, 6);

        //int count = 0;

        //print(random);


        if (random == 1)
        {
            GameObject enemies = Instantiate(prefab1, transform.position, Quaternion.identity);
        }else if (random == 2)
        {
            GameObject enemies = Instantiate(prefab2, transform.position, Quaternion.identity);
        }else if(random ==3)
        {
            GameObject enemies = Instantiate(prefab3, transform.position, Quaternion.identity);
        }
        else if (random == 4)
        {
            GameObject enemies = Instantiate(prefab4, transform.position, Quaternion.identity);
        }
        else if (random == 5)
        {
            GameObject enemies = Instantiate(prefab5, transform.position, Quaternion.identity);
        }
        else if (random == 6)
        {
            //count++;
            //if(count/2 == 0 )
            //{
                GameObject enemies = Instantiate(prefab6, transform.position, Quaternion.identity);
            //}
            
        }

    }

    public void spawn_special()
    {
        print("SPECIAL");
        GameObject special = Instantiate(Special, transform.position, Quaternion.identity);
        special.transform.position += Vector3.up * Random.Range(minHeight,maxHeight);
    }

    public void IncreaseSpawn()
    {
        spawnRate = 5.5f;
    }

    public void IncreaseSpawn2()
    {
        spawnRate = 4.75f;
    }
    public void IncreaseSpawn3()
    {
        spawnRate = 3.75f;
    }

}
