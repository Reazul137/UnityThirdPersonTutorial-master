using UnityEngine;
using System.Collections;

public class DoorRotation : MonoBehaviour {

	// Use this for initialization

	public int DoorNumber = 0;
	public string DoorNumberName ;
	void Start () {




	}

	void RotateDoor () {

		Vector3 roomDoorDir = this.transform.position - this.transform.parent.transform.position;
		if (Vector3.Angle(roomDoorDir, Vector3.forward) <= 45.0) {
			this.transform.rotation = Quaternion.Euler (0, 0, 0);
		}
		else if (Vector3.Angle(roomDoorDir, Vector3.right) <= 45.0) {
			this.transform.rotation = Quaternion.Euler (0, 90, 0);
		}
		else if (Vector3.Angle(roomDoorDir, Vector3.back) <= 45.0) {
			this.transform.rotation = Quaternion.Euler (0, 180, 0);
		}
		else if (Vector3.Angle(roomDoorDir, Vector3.left) <= 45.0) {
			this.transform.rotation = Quaternion.Euler (0, -90, 0);
		}
	
	}
	
	// Update is called once per frame
	void Update () {


		if (GameObject.Find("Dungeon_").transform.GetComponent<DungCreatorStepCounter02> ().dungCreatiStep == 4) {
			print("4 key _ RotateDoor");
			RotateDoor ();
		}

		if (GameObject.Find("Dungeon_").transform.GetComponent<DungCreatorStepCounter02> ().dungCreatiStep == 10) {
			print("10 key _ DoorEntece?");
			if(this.name == "Room_Dung_Dungeon_-Room_001_Door_001"){

				foreach(Renderer r in GetComponentsInChildren<Renderer>()){
					r.material.color= Color.yellow;
				}

			}
		}
	
	}



}
