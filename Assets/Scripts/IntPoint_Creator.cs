using UnityEngine;
using System.Collections;

public class IntPoint_Creator : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown("1")){
			GenerateIntPoint();
			
		}
	
	}

	void GenerateIntPoint() {
		print("interestPoint");
				
	}
}
