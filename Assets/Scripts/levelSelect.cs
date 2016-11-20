using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class levelSelect : MonoBehaviour {
    void Start()
    {
        Human.lifecount = 0;
    }

	public void lvlOne()
    {
        SceneManager.LoadScene("prototipo");
    }
}
