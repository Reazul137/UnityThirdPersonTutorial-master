using UnityEngine;
using System.Collections;

public class plataformMoviment : MonoBehaviour {

	
	Rigidbody rigidbody;
	Vector3 velocity;
	public bool MoveX = true;
	public bool MoveY = false;
	public bool MoveZ = false;

	
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
	}
	
	void Update () {


		if(MoveX){
			transform.localPosition = new Vector3(10* Mathf.Cos(Time.time), 0, 0);
		}

		if(MoveY){
			transform.localPosition = new Vector3(this.transform.localPosition.x,5f* Mathf.Cos(Time.time),  this.transform.localPosition.z);
		}
		if(MoveZ){
			transform.localPosition = new Vector3(0, 0, 10* Mathf.Cos(Time.time));
		}



	}
	
}
