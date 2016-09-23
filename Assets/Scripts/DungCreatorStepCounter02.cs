using UnityEngine;
using System.Collections;

public class DungCreatorStepCounter02 : MonoBehaviour {
	public float dungCreatiStep = 0f;




	void Start()
	{

	}
	
	void Update() {
		//This is a coroutine
		if (dungCreatiStep < 11.5) {

			dungCreatiStep = dungCreatiStep + 0.25f;
			//print(dungCreatiStep);
		}
		if (dungCreatiStep >= 9.5) {
			if(GameObject.Find("Room_Dung_Dungeon_-Room_001_Door_001") == null){

				Application.LoadLevel (0);  
			}


		}

	}


}
