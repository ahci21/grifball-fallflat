using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomPorteria : MonoBehaviour {
    //Detect collisions between the GameObjects with Colliders attached

    public bool right=false,left=false;
	public GameObject ball;


    void OnCollisionEnter(Collision collision)
    {
		Debug.Log("Colliding with "+collision.gameObject.name);


		if(collision.gameObject.name=="GameBall"){

			Instantiate(ball,this.transform.position, this.transform.rotation);
		}
    }
}
