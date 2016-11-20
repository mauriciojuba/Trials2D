using UnityEngine;
using System.Collections;

public class testGround : MonoBehaviour {

    public static bool isGround;

    

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("floor"))
        {
            isGround = true;
        }
    }
    void OnTriggerExit2D(Collider2D hit)
    {
        if (hit.CompareTag("floor"))
        {
            isGround = false;
        }
    }
}
