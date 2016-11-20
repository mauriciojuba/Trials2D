using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	public void Jogar()
    {
        SceneManager.LoadScene("LevelSelect");
    }
}
