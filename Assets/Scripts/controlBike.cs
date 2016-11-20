using UnityEngine;
using System.Collections;

public class controlBike : MonoBehaviour {
    public ScoreController pontos;
	Rigidbody2D frontWheel;
    public Transform head, rear, front;
	float force;
    bool frontUP, upsidedown;

	void Start () {
		frontWheel = GetComponent<Rigidbody2D> ();
	}

	void Update () {
		force = Input.GetAxisRaw ("Horizontal");
		if(!frontUP) frontWheel.AddForce(new Vector2(0, -force*10));
        else frontWheel.AddForce(new Vector2(0, force * 10));
        checkFlip();
        if (upsidedown)
        {
            testFlip();
        }
	}
    void checkFlip()
    {
        if(head.position.y < front.position.y)
        {
            frontUP = true;
            if (head.position.y < rear.position.y)
            {
                upsidedown = true;
            }
        }
        else
        {
            frontUP = false;
        }
        
    }
    void testFlip()
    {
        if (head.position.x > rear.position.x && upsidedown && !frontUP)
        {
            flipou();
            upsidedown = false;
        }
    }
    public void flipou()
    {
        pontos.flipUP();
    }
}
