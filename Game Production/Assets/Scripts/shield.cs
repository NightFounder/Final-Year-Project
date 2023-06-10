using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<BoxCollider2D>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShieldUp()
    {
        GetComponent<BoxCollider2D>().enabled = true;
    }
    


    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == "Obstacles")
        {

            print("Destryoed an enemie");
            FindObjectOfType<GameManager>().DestroyEnemie();
            GetComponent<BoxCollider2D>().enabled = false;

        }
    }



}
