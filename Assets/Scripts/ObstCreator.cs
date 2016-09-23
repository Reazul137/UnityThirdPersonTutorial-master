using UnityEngine;
using System.Collections;

public class ObstCreator : MonoBehaviour {
	public GameObject DoorIn ;
	public GameObject DoorOut;
	public float TipeOfObst;


	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
		Debug.DrawLine(this.transform.position, DoorIn.transform.position,Color.green);
		Debug.DrawLine(this.transform.position, DoorOut.transform.position,Color.red);
	
	}
}
