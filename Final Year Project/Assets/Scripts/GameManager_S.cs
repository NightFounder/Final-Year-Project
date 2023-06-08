using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager_S : MonoBehaviour
{
    public Text timer_score_text;
    public float timer_score;
    public float timer_score2;

    public GameObject GameOver_Screen;
    public GameObject Win_Screen;

    public Text Fastest_Time_text;
    public Text Final_Time_text;

    public float Final_Score;
    public float Best_Score;

    public float min5_sec;
    
    
    public bool lose_condition;


    private void Awake()
    {
        Application.targetFrameRate = 60;
        Best_Score= 20;
        lose_condition = false;

        GameOver_Screen.SetActive(false);
        Win_Screen.SetActive(false);
    }

    public void Replay()
    {
        GameOver_Screen.SetActive(false);
    }

    public void Update()
    {


        if (lose_condition == true)
        {
            min5_sec++;
            //print(min5_sec);
            if (min5_sec > 400)
            {
                print("After 5 sec, you Lose.");
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
                //Clears all of the caches
                bool success = Caching.ClearCache();


                lose_condition = false;
            }

        }


    }


    public void IncreaseTimer()
    {
        timer_score = timer_score + 2;

        timer_score2 = timer_score / 100f;
        Final_Score = timer_score2;


        timer_score_text.text = timer_score2.ToString();

    }


    public void GameOver()
    {
        lose_condition = true;

        //Time.timeScale = 0f;
        print("GAME OVER!!!!");

        ///NEED SET TO TRUE///NEED SET TO TRUE///NEED SET TO TRUE///NEED SET TO TRUE
        
        //GameOver_Screen.SetActive(true);
    }

    public void Winning()
    {
        
        
        timer_score_text.text = timer_score2.ToString();

        if (Final_Score <= Best_Score)
        {
            Fastest_Time_text.text = Final_Score.ToString();
            Final_Time_text.text = Final_Score.ToString();
        }
        else
        {
            Final_Time_text.text = Final_Score.ToString();
        }

        Win_Screen.SetActive(true);


    }


}
