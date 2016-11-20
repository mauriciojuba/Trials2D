using UnityEngine;
using System.Collections;

public class Motor : MonoBehaviour {

    
	public float vel;
	Rigidbody2D rb;
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space) && testGround.isGround) {
			rb.AddForce(new Vector2(vel,0));
		}
	}
}
