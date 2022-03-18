using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boom : MonoBehaviour {
    //Detect collisions between the GameObjects with Colliders attached

    public bool right=false,left=false;
	public GameObject ball;
	public AudioSource audioSource;

    void OnCollisionEnter(Collision collision)
    {
		Debug.Log("Colliding with "+collision.gameObject.name);

		if(collision.gameObject.name=="RightHand"){
			right = true;

			if(left){ 
				transform.GetChild(0).gameObject.SetActive(true);
				Debug.Log("ON");
			}

		}

		if(collision.gameObject.name=="LeftHand"){
			left = true;

			if(right){
				transform.GetChild(0).gameObject.SetActive(true);
				Debug.Log("ON");
			}
		}

		

		if(collision.gameObject.name=="piso" & right & left){
			
			audioSource.Play();
			Instantiate(ball,this.transform.position, this.transform.rotation);
			right = false;
			left = false;
			transform.GetChild(0).gameObject.SetActive(false);
		}
    }
}
