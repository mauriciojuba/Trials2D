using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public static string finalScore, finalTime, finalFlip;
    public Text scoreText, timeText, flipText;
    public GameObject panel;

    void Start()
    {
        panel.SetActive(false);
    }

    public void showStatus()
    {
        panel.SetActive(true);
        scoreText.text = finalScore;
        timeText.text = finalTime;
        flipText.text = finalFlip;
    }
    public void hideStatus()
    {
        panel.SetActive(false);
    }
}
