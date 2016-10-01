using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {
	public GameObject[] PathAreas;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(GameObject.Find("RegiaoCenter")){
			this.transform.position = GameObject.Find ("RegiaoCenter").transform.position;
			foreach(Transform child in transform){
				child.gameObject.SetActive(true);



				PathAreas = GameObject.FindGameObjectsWithTag("PathArea");
	

				for (int i = 0; i < PathAreas.Length; i++) {
					Destroy (PathAreas[i].gameObject);
				}

			}



		}
	
	}
}
