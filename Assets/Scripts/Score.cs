using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    public Text scoreText;
    public Text highScoreText;
    private void Start() {
        highScoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("Highscore").ToString();
    }
    public void ScoreAdd(int amount){
        score = score + amount;
        if(PlayerPrefs.GetInt("Highscore") < score){
            PlayerPrefs.SetInt("Highscore", score);
        }
        scoreText.text = score.ToString();
        highScoreText.text = "HIGHSCORE: " + PlayerPrefs.GetInt("Highscore").ToString();
        Debug.Log("Score: "+ score);
    }
}
