using UnityEngine;
using System.Collections;

public class ParticlesCrator : MonoBehaviour {
	bool hasParent =false;


	void Start(){

		ChangeSpects ();





	}
	void Update () {
		

		if (hasParent == false &&  GameObject.FindGameObjectWithTag ("MainCamera") == true) {
			parentTo ();

			hasParent =true;
		}
	
	}
	void parentTo () {


		this.transform.parent = GameObject.FindGameObjectWithTag ("MainCamera").transform;

		this.transform.localScale = new Vector3 (1, 1, 1);
		this.transform.localPosition = new Vector3 (0, 0, 0);


	}


	void ChangeSpects () {

		ParticleSystem thisParticle = this.GetComponent<ParticleSystem> ();


		//Random.seed = RegiaoInfo.OverWorldPositionX + RegiaoInfo.OverWorldPositionZ + this.GetInstanceID();

		thisParticle.gravityModifier = Mathf.Cos(    ( (RegiaoInfo.Var_Temperature/100f)*4f ) -1.6f );

		float Part_var_Pop = RegiaoInfo.Var_Population / 100f;

		thisParticle.startSpeed = Mathf.Clamp( ((16f*(Part_var_Pop*Part_var_Pop))-(16f*Part_var_Pop)+4f),0f,5f);

		//print (Mathf.Clamp( ((16f*(Part_var_Pop*Part_var_Pop))-(16f*Part_var_Pop)+4f),0f,5f));





	}
}
