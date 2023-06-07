using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    public bool win_condition2;
    public bool win_condition3;
    public float min5_sec;

    public void Update()
    {
        if (win_condition2 == true)
        {
            min5_sec++;
            if (min5_sec > 400)
            {

                SceneManager.LoadScene("Level2");
                win_condition2 = false;
            }
        }


        if (win_condition3 == true)
        {
            min5_sec++;
            if(min5_sec > 400)
            {

                SceneManager.LoadScene("Level3");
                win_condition3 = false;
            }
        }
        
    }

    // Start is called before the first frame update
    void OnCollisionEnter (Collision collisioninfo)
    {
        if (collisioninfo.collider.tag == "Obstacles")
        {
            Debug.Log("HIT OBSTACLES");
            movement.enabled = false;
            FindObjectOfType<GameManager_S>().GameOver();
        }else if(collisioninfo.collider.tag == "Win")
        {
            movement.enabled = false;
            win_condition2 = true;
            FindObjectOfType<GameManager_S>().Winning();
            
        }else if(collisioninfo.collider.tag == "Win2")
        {
            movement.enabled = false;
            win_condition3 = true;
            FindObjectOfType<GameManager_S>().Winning();
        }
        
    }
}
