using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class CharDungRelation : MonoBehaviour {



	// Use this for initialization
	void Start () {
		

	
	}
	
	
	void Update() {
		
		if (GameObject.Find("Dungeon_").transform.GetComponent<DungCreatorStepCounter02> ().dungCreatiStep == 11) {
			print("11 key _ Char to start");

			if(GameObject.Find("Room_Dung_Dungeon_-Room_001_Door_001") != null){
				
				this.transform.position = GameObject.Find("Room_Dung_Dungeon_-Room_001_Door_001").transform.GetChild(4).transform.position;
			}
		}
		
		
	}


}
