using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float power;
    int life = 3;


    public Text Life_Text;




    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    

    private void Update()
    {


        //if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began) // Touch
        //if (Input.touchCount > 0)
        //{
        //    acumTime += Input.GetTouch(0).deltaTime;
        //
        //   if (acumTime >= holdTime)
        //    {
        //        //Long tap
        //    }
        //
        //    if (Input.GetTouch(0).phase == TouchPhase.Ended)) 
        //{
        //        acumTime = 0;
        //    }
        //}



        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.Space))
        {
            
            //direction = Vector3.up * strength;
            rb.velocity = Vector2.up * power;

        }

        
        //rection.y += gravity * Time.deltaTime;
        //transform.position += direction * Time.deltaTime;

        FindObjectOfType<GameManager>().IncreaseDistance();

    }

   

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.gameObject.tag == "Obstacles")
        {
          
                life--;
            Life_Text.text = life.ToString();
            print("Life: " +life);
                if (life == 0)
                {
                    life = 3;
                Life_Text.text = life.ToString();   
                FindObjectOfType<GameManager>().GameOver();
                    
            }
          
                Destroy(other.gameObject);
            
        }else if (other.gameObject.tag == "money")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
            //print("SCOREEE");
        }
        else if (other.gameObject.tag == "Special")
        {
            FindObjectOfType<GameManager>().IncreaseMedallion();
            //print("SCOREEE");
        }
       
    }



}
