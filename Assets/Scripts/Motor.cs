using UnityEngine;
using System.Collections;

public class Motor : MonoBehaviour {

    
	public float acel;
    float vel;
    float secs;
	Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) && testGround.isGround) {
            secs += Time.deltaTime*10;
            rb.AddForce(new Vector2(vel, 0));
		}
        else
        {
            secs = 0;
        }
        vel = acel * secs;
    }
}
