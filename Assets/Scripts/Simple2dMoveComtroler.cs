using UnityEngine;
using System.Collections;

public class Simple2dMoveComtroler : MonoBehaviour {
	private float MoveVelo = 0.2f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow))
		{
			this.transform.position +=  Vector3.left *MoveVelo;

		}
		if (Input.GetKey(KeyCode.RightArrow))
		{
			this.transform.position +=  Vector3.right *MoveVelo;
		}
		if (Input.GetKey(KeyCode.UpArrow))
		{
			this.transform.position +=  Vector3.forward *MoveVelo;
		}
		if (Input.GetKey(KeyCode.DownArrow))
		{
			this.transform.position +=  Vector3.back *MoveVelo;
		}
	}
}
