using UnityEngine;
using System.Collections;

public class doorGanbiarra : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	
	}



	void OnTriggerEnter(Collider other) {


		other.transform.position = new Vector3(this.transform.position.x - (this.transform.position.x - other.transform.position.x),other.transform.position.y, this.transform.position.z - (this.transform.position.z - other.transform.position.z));

	}
}
