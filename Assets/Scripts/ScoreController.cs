using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour {

    public Human human;
    public Text scoreText;
    static int scoreNum;
    public int scoreLimit;
    public Text flipText;
    static int flipNum;
    public int flipLimit;
    public Text timeText;
    float seconds = 30;
    int minutes, hours;

    void Start () {
        minutes = 0;
        hours = 0;
        if (Human.lifecount == 3)
        {
            scoreNum = 0;
            flipNum = 0;
        }
        scoreText.text = scoreNum + "/" +scoreLimit;
        flipText.text = flipNum + "/"+flipLimit;
        if (flipNum >= flipLimit)
        {
            flipText.color = new Color(0, 1, 0);
        }
        if (scoreNum >= scoreLimit)
        {
            scoreText.color = new Color(0, 1, 0);
        }
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
        seconds -= Time.deltaTime;
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
        if(seconds <= 0)
        {
            human.Restart();
            seconds = 30;
        }
        
    }

	public void scoreUP (int scoreAmount) {
        scoreNum += scoreAmount;
        scoreText.text = scoreNum + "/" + scoreLimit;
        if(scoreNum >= scoreLimit)
        {
            scoreText.color = new Color(0, 1, 0);
        }
	}
    public void flipUP()
    {
        flipNum += 1;
        flipText.text = flipNum + "/" + flipLimit;
        if (flipNum >= flipLimit)
        {
            flipText.color = new Color(0, 1, 0);
        }
    }
}
