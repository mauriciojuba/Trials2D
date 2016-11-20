using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Human : MonoBehaviour {

    public UIController ui;
    public ScoreController pontos;
    public static bool paused;
    public static bool dead;
	void Start(){
        paused = false;
	}

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            paused = !paused;

            if (paused)
            {
                ui.showStatus();
                Time.timeScale = 0;
                
            }
            else
            {
                ui.hideStatus();
                Time.timeScale = 1;
            }
        }
        if (dead)
        {
            ui.showStatus();
        }
    }
    
	void OnTriggerEnter2D(Collider2D hit){
		if(hit.CompareTag("floor")){
			GetComponent<Animator> ().enabled = true;

			//nao passa do chçao
			GetComponent<BoxCollider2D> ().isTrigger = false;
			//gravidade
			Rigidbody2D rb = gameObject.AddComponent<Rigidbody2D> ();
			//desligar a fisica
			rb.isKinematic = true;
			//solta da moto
			transform.SetParent (null);
			//rotação Sprite volta pra zero
			//transform.rotation = Quaternion.identity;
			transform.up = hit.transform.up;
            dead = true;
            
			Invoke ("Restart", 2f);
		}
        if (hit.CompareTag("star"))
        {
            pontos.scoreUP(1);
            hit.gameObject.SetActive(false);
        }
    }
	void Restart(){
		//SceneManager.LoadScene("prototipo");
	}
}
