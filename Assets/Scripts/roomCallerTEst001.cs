using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class roomCallerTEst001 : MonoBehaviour {



	public GameObject TestRoomPrefab;

	public float[,] CallerDoor_Array ;

	public float[] DoorToAdd ;

	List<float> CallerDoor_list = new List<float>();
	List<string> CallerRooms_list = new List<string>();


	// Use this for initialization
	void Start () {
		CallerRooms_list.Add (this.gameObject.transform.name);
		CallerRooms_list.Add (this.gameObject.transform.name);
	}

	void DetectingOvelapRooms () {

		Ray rayOrigin = new Ray(new Vector3( this.transform.localPosition.x, this.transform.localPosition.y+10, this.transform.localPosition.z),new Vector3(0,-1,0));
		RaycastHit hitInfo;
		//print ("oi 1"+this.name);


		if(Physics.Raycast(rayOrigin,out hitInfo,20f,1 << 9))
		{ 

			//print ("oi 2");
			if(this.transform !=hitInfo.transform){
//				print (this.transform.name + "  and  "+hitInfo.transform.name+ "  are the same... MERGE!!!!  ");

				//Debug.DrawLine(rayOrigin.origin, hitInfo.point,Color.magenta,10f);

				List<float> CallerDoor_list_Helper = hitInfo.transform.GetComponent<roomCallerTEst001>().CallerDoor_list;

				CallerRooms_list.Add (hitInfo.transform.name);
				CallerRooms_list.Add (hitInfo.transform.name);

				for(int iC = 0; iC < hitInfo.transform.childCount; iC++){
					hitInfo.transform.GetChild(iC).parent=this.transform;
				}
				Destroy(hitInfo.transform.gameObject);
				this.transform.name = hitInfo.transform.name;


				this.transform.SetSiblingIndex(hitInfo.transform.GetSiblingIndex());



				

				CallerDoor_list_Helper.AddRange(CallerDoor_list);

				CallerDoor_list.Clear();

				CallerDoor_list=CallerDoor_list_Helper;

			}

			
		}


	}

	public void CallerDoor_AddDoorToList ( int DoorToAdd_direction, int DoorToAdd_Tipe, int DoorToAdd_Pos , int DoorListPos) {

		CallerDoor_list.Add(DoorToAdd_direction);

		

	}



	void RoomCaller () {

		int ListSise = CallerDoor_list.Count;
		CallerDoor_Array = new float[ListSise,3];

		for(int il = 0; il < ListSise; il++){
			CallerDoor_Array[il,0] = CallerDoor_list[il] ;
			CallerDoor_Array[il,1] = 0;

			for(int ill = 0; ill < il; ill++){
				if(CallerDoor_Array[il,0] == CallerDoor_Array[ill,0]){
					while(CallerDoor_Array[il,2] == CallerDoor_Array[ill,2]){
						CallerDoor_Array[il,2] = Random.Range(-2,2);
					}
				}
			}
		}

		var tempRoom = Instantiate(TestRoomPrefab,this.transform.position,Quaternion.Euler(0,0,0))as GameObject;

		tempRoom.name = this.name ;
		tempRoom.transform.parent = this.transform.parent;

		tempRoom.GetComponent<Dung_RoomCreator> ().CallerRooms_list = CallerRooms_list;

		tempRoom.GetComponent<Dung_RoomCreator> ().RandomUseSeedForTest = false;

		tempRoom.GetComponent<Dung_RoomCreator>().UseCallerSeed = true;



		tempRoom.GetComponent<Dung_RoomCreator> ().RoomRandomSeed =   this.transform.name.GetHashCode();//00;//Dungeon seed*roomNumber
		

		tempRoom.GetComponent<Dung_RoomCreator> ().DungDoor_list = CallerDoor_Array;


		for (int i=this.transform.childCount-1; i >= 0; --i) {
			Transform child = this.transform.GetChild(i);
			//Debug.Log("moving object: " + child.name);
			child.SetParent(tempRoom.transform, false);
		}
		Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update() {
		if (GameObject.Find("Dungeon_").transform.GetComponent<DungCreatorStepCounter02> ().dungCreatiStep == 1) {
			print("1 key _ Detecting Ovelap Rooms");
			DetectingOvelapRooms ();
		}
		if (GameObject.Find("Dungeon_").transform.GetComponent<DungCreatorStepCounter02> ().dungCreatiStep == 2) {
			print("2 key _  RoomCaller create Room");
			RoomCaller ();
		}


	}
}
