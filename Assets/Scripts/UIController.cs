using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

    public static string finalScore, finalTime;
    public Text scoreText, timeText;
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
    }
    public void hideStatus()
    {
        panel.SetActive(false);
    }
}
