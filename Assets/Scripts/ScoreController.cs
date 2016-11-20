using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public Text scoreText;
    int scoreNum;
    public Text flipText;
    int flipNum;
    public Text timeText;
    float seconds = 0;
    int minutes, hours;

    void Start () {
        minutes = 0;
        hours = 0;
        scoreNum = 0;
        scoreText.text = "" + scoreNum;
	}
    void Update()
    {
        
        UIController.finalTime = timeText.text;
        UIController.finalScore = scoreText.text;
        UIController.finalFlip = flipText.text;
        if (!Human.dead)
        {
            timeCount();
        }
        
    }
    public void timeCount()
    {
        seconds += Time.deltaTime;
        if (Mathf.CeilToInt(seconds) >= 60)
        {
            seconds = 0;
            minutes++;
        }
        if(minutes == 60)
        {
            minutes = 0;
            hours++;
        }
        timeText.text = hours + "h " + minutes + "m " + Mathf.CeilToInt(seconds)+"s";
        
    }

	public void scoreUP (int scoreAmount) {
        scoreNum += scoreAmount;
        scoreText.text = "" + scoreNum;
	}
    public void flipUP()
    {
        flipNum += 1;
        flipText.text = "" + flipNum;
    }
}
