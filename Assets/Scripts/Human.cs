using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Human : MonoBehaviour {

    public UIController ui;
    public ScoreController pontos;
    public static bool paused;
    public static bool dead;
    public static int lifecount = 3;
    public Text lifecountText;
	void Start(){
        paused = false;
        lifecountText.text = "x" + lifecount;
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
            Invoke("Restart", 2f);


        }
        if (hit.CompareTag("star"))
        {
            pontos.scoreUP(1);
            hit.gameObject.SetActive(false);
        }
        if (hit.CompareTag("death"))
        {
            dead = true;
            Invoke("Restart", 0.5f);
        }
    }
	public void Restart(){
        
        if (lifecount == 0)
        {
            SceneManager.LoadScene("Menu");
        }
        else
        {
            lifecount -= 1;
            lifecountText.text = "x" + lifecount;
            SceneManager.LoadScene("prototipo");
            dead = false;

        }
    }
}
