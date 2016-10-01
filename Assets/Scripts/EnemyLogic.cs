using UnityEngine;
using System.Collections;

public class EnemyLogic : MonoBehaviour {


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}



	void OnCollisionEnter(Collision collision) {

		if(collision.collider.tag == "Blade"){
			print (collision.relativeVelocity.magnitude);
			if (collision.relativeVelocity.magnitude > 0.2f){
				
				Destroy (this.gameObject);
			}
			
		}

		
	}
}
