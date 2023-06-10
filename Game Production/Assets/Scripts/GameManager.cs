using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public PlayerMovement player;
    public Speed speed;
    public special special;
    //public shield shield;
    
    ///Game
    public Text MoneyText;
    public Text DistanceText;
    public Text CurrentDistanceText;
    public Text Total_MoneyText;
    public Text Longest_DistanceText;
    //public Text PowerUp_Text;
    public Text Medallion_Text;

   // public Text Shop_moneytext;



    //private float firstLeftClickTime;
    //private float TimeBetweenLeftClick = 0.5f;
    //private bool isTimeCheckAllowed = true;
    //private int LeftClickNum = 0;

    public float distance;
    public float previous_distance;

    //public int powerUp;
    public int money;
    public int moneyShield;
    public int total_money;

    public int shopMoney;

    public int medallion;


    //public GameObject PlayButton;
    public GameObject ReplayButton;
    public GameObject gameOverScreen;
    public GameObject PlayButton;
    public GameObject PauseScreen;
    public GameObject MedallionPAGE;
    public GameObject spawner;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        
        //need move to database
        total_money = 0;
        previous_distance= 0;

        
        gameOverScreen.SetActive(false);
        MedallionPAGE.SetActive(false);
        PauseScreen.SetActive(false);
        Pause();
    }

    public void RePlay()
    {
        money= 0;
        //powerUp = 0;
        distance = 0f;

        MedallionPAGE.SetActive(false);
        PauseScreen.SetActive(false);
        PlayButton.SetActive(false);
        ReplayButton.SetActive(false);
        gameOverScreen.SetActive(false);

        Time.timeScale = 1f;

        player.enabled = true;

        Speed[] waves = FindObjectsOfType<Speed>();


        for (int i =0; i<waves.Length; i++)
        {
            Destroy(waves[i].gameObject);
        }

        special[] special = FindObjectsOfType<special>();
        for (int i = 0; i < special.Length; i++)
        {
            Destroy(special[i].gameObject);
        }
        

        MoneyText.text = money.ToString();
        //PowerUp_Text.text = powerUp.ToString();
        DistanceText.text = distance.ToString();
        CurrentDistanceText.text = distance.ToString();


    }

    public void Pause()
    {
        Time.timeScale = 0f;
        player.enabled = false;
    }

    public void Paused()
    {
        Time.timeScale = 0f;
        player.enabled = false;
        PauseScreen.SetActive(true);
    }

    public void Continue()
    {
        PauseScreen.SetActive(false);
        Time.timeScale = 1f;
        player.enabled = true;
    }

    public void meallionpage()
    {
        MedallionPAGE.SetActive(true);
    }

    public void closemeallionpage()
    {
        MedallionPAGE.SetActive(false);
    }


    public void GameOver()
    {

        if (distance >= previous_distance)
        {
            Longest_DistanceText.text = distance.ToString();
        }


        previous_distance = distance;
        total_money += money;
        medallion += medallion;
        shopMoney += total_money;

        //Shop_moneytext.text = shopMoney.ToString();
        Total_MoneyText.text = total_money.ToString();
        //Debug.Log("Game Over");
        gameOverScreen.SetActive(true);
        ReplayButton.SetActive(true);



        Pause();

    }





    public void IncreaseScore()
    {
        money++;
        //powerUp++;

        //if(powerUp >10)
        //{
        //    moneyShield = 1;
        //}
        //else
        //{
        //    PowerUp_Text.text = powerUp.ToString();
        //}
        
        MoneyText.text = money.ToString();

        
    }

    public void IncreaseMedallion()
    {
        medallion++;
        Medallion_Text.text = medallion.ToString();


    }

    public void IncreaseDistance()
    {
        
        distance ++;
        DistanceText.text = distance.ToString();

        //NEED CHANGE//
////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        if (distance >= 1500f && distance <=2400f)
        {
            //spawner.SetActive(true);
            FindObjectOfType<Speed>().IncreaseSpeed2();
            FindObjectOfType<Spawner>().IncreaseSpawn();
        }
        else if(distance> 2450f && distance < 3400f)
        {
            //spawner.SetActive(true);
            FindObjectOfType<Speed>().IncreaseSpeed3();
            FindObjectOfType<Spawner>().IncreaseSpawn2();
        }
        else if(distance>= 3450 && distance < 4400f)
        {
            FindObjectOfType<Speed>().IncreaseSpeed4();
        }
        else if (distance >= 4450)
        {
            FindObjectOfType<Speed>().IncreaseSpeed5();

            FindObjectOfType<Spawner>().IncreaseSpawn3();
        }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        //////////////////////////////////////////////////////////////////
        if (distance == 3600f || distance == 2600f || distance == 4600f)
        {
            FindObjectOfType<Spawner>().spawn_special();
        }
        ///////////////////////////////////////////////////////////

    }


    private void Update()
    {
        //if (Input.GetMouseButtonUp(0))
        //{
        //    LeftClickNum += 1;
        //}
        //if (LeftClickNum == 1 && isTimeCheckAllowed)
        //{
        //    firstLeftClickTime = Time.time;
        //    StartCoroutine(DetectDoubleLeftClick());

        //}
        if(distance == 1300f)
        {
            spawner.SetActive(false);
        }
        //spawner.SetActive(false);
    }

    //private IEnumerator DetectDoubleLeftClick()
    //{
    //    isTimeCheckAllowed = false;
    //   while (Time.time < firstLeftClickTime + TimeBetweenLeftClick)
    //    {
    //        if (LeftClickNum == 2)
    //        {
    //            Debug.Log("DOUBLE CLICK");
    //
    //            if(moneyShield == 1)
    //            {
    //                powerUp = 0;
    //                moneyShield = 0;
    //                PowerUp_Text.text = powerUp.ToString();
    //                FindObjectOfType<shield>().ShieldUp();
    //
    //                Debug.Log("Shield UP");
    //            }
    //
//
     //           break;
     //       }
     //       yield return new WaitForEndOfFrame();
     //   }
     //
     //   LeftClickNum = 0;
     //   isTimeCheckAllowed = true;

   // }

    public void DestroyEnemie()
    {
        Enemies[] enemies = FindObjectsOfType<Enemies>();



        for (int i = 0; i < enemies.Length; i++)
        {
            Destroy(enemies[i].gameObject);
        }

    }



}
