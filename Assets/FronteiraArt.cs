using UnityEngine;
using System.Collections;

public class FronteiraArt : MonoBehaviour {


	public int FrontType = 0;

	// Use this for initialization
	void Start () {
		
	}

	public void activate(){

		if (FrontType == 0) {
			this.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1); 
		}

		if (FrontType == 1) {

			this.GetComponent<Renderer>().material.color = new Color(0, 1, 0, 1); 
		}

		if (FrontType == 2) {
			this.GetComponent<Renderer>().material.color = new Color(0, 0, 1, 1); 
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
