using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{   

    [SerializeField] Text scoreText;
    [SerializeField] Text highScoreText;
    private float score;
    private float highScore;

    private void Start() 
    {
        highScore = PlayerPrefs.GetInt("highScore", 0);

        //highScoreText.text = "High Score - " + ((int)score).ToString();
    }

    
    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            score += 1 * Time.deltaTime;

            //issaugo HighScore
            if (highScore < score)
            {
                PlayerPrefs.SetInt("highScore", (int)score);
            }
            
            scoreText.text = ((int)score).ToString();

            highScoreText.text = "High Score - " + ((int)highScore).ToString();
        }
    }
}
