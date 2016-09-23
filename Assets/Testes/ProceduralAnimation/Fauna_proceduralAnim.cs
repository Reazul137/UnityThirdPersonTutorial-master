using UnityEngine;
using System.Collections;

public class Fauna_proceduralAnim : MonoBehaviour {

	public Transform Tronco;
	public Transform Tronco_GoalPos;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		print(this.transform.GetComponent<Rigidbody>().velocity);


	}
}
