using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour {
    //Detect collisions between the GameObjects with Colliders attached

    public bool right=false,left=false;
	public GameObject ball;


    void OnCollisionEnter(Collision collision)
    {
		Debug.Log("Colliding with "+collision.gameObject.name);

		if(collision.gameObject.name=="RightHand"){
			right = true;
		}

		if(collision.gameObject.name=="LeftHand"){
			left = true;
		}

		if(collision.gameObject.name=="piso" & right & left){
			Debug.Log("bola gigante");

			Instantiate(ball, GameObject.FindGameObjectsWithTag("Martillo")[0].transform.position, GameObject.FindGameObjectsWithTag("Martillo")[0].transform.rotation);

			right = false;
			left = false;
		}
    }
}
