using UnityEngine;
using System.Collections;

public class ParticlesCrator : MonoBehaviour {
	bool hasParent =false;


	void Start(){
	}
	void Update () {

		if (hasParent == false &&  GameObject.FindGameObjectWithTag ("Player") == true) {
			parentTo ();

			hasParent =true;
		}
	
	}
	void parentTo () {


		this.transform.parent = GameObject.FindGameObjectWithTag ("Player").transform;

		this.transform.localScale = new Vector3 (1, 1, 1);
		this.transform.localPosition = new Vector3 (0, 0, 0);


	}
}
