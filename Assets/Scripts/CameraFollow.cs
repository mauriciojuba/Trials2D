using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	float distance = -10f;
	public float zoom;

	void Start(){
		
	}



	void Update(){
		this.transform.position = new Vector3 (target.position.x + 2, target.position.y , distance);
		GetComponent<Camera> ().orthographicSize = zoom;
	}
}
