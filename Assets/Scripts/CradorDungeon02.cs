using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;



public class CradorDungeon02 : MonoBehaviour {

	public int[] RegionPos = new int[]{0,0};

	public int entreceDoorTipe = 1;

	//dungeon Biome Seed			       	  { Nunber,Dificut,Sise/,Temp,Umid,Alti/,Nat,Civ,Esp/,BemMal,Age}
	public int[] dungeonBiomeSeed = new int[] {      1,      1,   5,    5,   5,   5,   5,  5,  5,      5,  5};

	public GameObject RoomPrefab;
	public GameObject TestRoomPrefab;
	public GameObject TestDoorPrefab;

	public GameObject MapPanel;
	public GameObject MapRoom;

	public bool isRegionPosSeedRandom;
	public bool isdungeonBiomeSeedRandom;


	int[] roomsStepsList;
	int NumberOfRoomsSteps;

	public int[] roomsStepsListTEST;


	
	void Start() {




		if (isRegionPosSeedRandom) {

			RegionPos = new int[]{
				Random.Range (0, 1000),
				Random.Range (0, 1000)
			};

			entreceDoorTipe = Random.Range (1, 7);
		}

		if (isdungeonBiomeSeedRandom) {
			dungeonBiomeSeed = new int[] {      
				Random.Range(1, 10)*Random.Range(1, 10),
				Random.Range(1, 10)*Random.Range(1, 10),
				Random.Range(1, 10)*Random.Range(1, 10),

				Random.Range(1, 10)*Random.Range(1, 10),
				Random.Range(1, 10)*Random.Range(1, 10),
				Random.Range(1, 10)*Random.Range(1, 10),

				Random.Range(1, 10)*Random.Range(1, 10),
				Random.Range(1, 10)*Random.Range(1, 10),
				Random.Range(1, 10)*Random.Range(1, 10),

				Random.Range(1, 10)*Random.Range(1, 10),
				Random.Range(1, 10)*Random.Range(1, 10)
			};

		} 

		Random.seed = dungeonBiomeSeed[0] + 100*RegionPos[0]+ 1000000000 *RegionPos[1];

		RoomGeneration_step001 ();
		roomsStepsList_2D_Vizualiser ();
		roomsStepsList_3D_Vizualiser ();
		//RoomsList_Full ();
		
	}


	void RoomGeneration_step001 (){

		NumberOfRoomsSteps =  Random.Range(9, 9+(dungeonBiomeSeed[2]));

		roomsStepsList = new int[NumberOfRoomsSteps+1];


		roomsStepsList[0] = entreceDoorTipe;


		//print ("NumberOfRoomsSteps-"+ NumberOfRoomsSteps);
		//print ("Door-"+0+":_"+roomsStepsList[0]);


		int i = 1;
		while (i < NumberOfRoomsSteps) {

			Random.seed = (dungeonBiomeSeed[0] + 100*RegionPos[0]+ 1000000000 *RegionPos[1])*i;
			roomsStepsList[i] = Random.Range(1, 7);
			//print ("Door-"+i+":_"+roomsStepsList[i]);

			i++;

		}


	}

	void roomsStepsList_2D_Vizualiser (){

		Vector3 InstPos = new Vector3(0,0,0);


		for (int iv = 0; iv < NumberOfRoomsSteps ; iv++) {
			//print(roomsStepsList[iv]);

		}

		for (int iv = 0; iv < NumberOfRoomsSteps; iv++) {

			if(roomsStepsList[iv] == 1){
				InstPos.y += 1;
			}
			if(roomsStepsList[iv] == 2){
				InstPos.x += 1;
			}
			if(roomsStepsList[iv] == 3){
				InstPos.y -= 1;
			}
			if(roomsStepsList[iv] == 4){
				InstPos.x -= 1;
			}
			if(roomsStepsList[iv] == 5){
				InstPos.z += 1;
			}
			if(roomsStepsList[iv] == 6){
				InstPos.z -= 1;
			}

			var temp = Instantiate(MapRoom,Vector3.zero,Quaternion.Euler(0,0,0))as GameObject;

			temp.transform.parent = MapPanel.transform;
			temp.transform.localPosition = InstPos;


			temp.name = "Dung_"+this.name+"-Room_"+((iv+1).ToString("000"));



			
		}
	
	}
	void roomsStepsList_3D_Vizualiser (){
		
		Vector3 InstPos = new Vector3(0,0,0);
		Vector3 InstDoorPos = new Vector3(0,0,0);
		
		
		for (int iv = 0; iv < NumberOfRoomsSteps; iv++) {
			
			if(roomsStepsList[iv] == 1){
				InstPos.z -= 50;
				InstDoorPos = InstPos;
				InstDoorPos.z += 25;
			}
			if(roomsStepsList[iv] == 2){
				InstPos.x -= 50;
				InstDoorPos = InstPos;
				InstDoorPos.x += 25;
			}
			if(roomsStepsList[iv] == 3){
				InstPos.z += 50;
				InstDoorPos = InstPos;
				InstDoorPos.z -= 25;
			}
			if(roomsStepsList[iv] == 4){
				InstPos.x += 50;
				InstDoorPos = InstPos;
				InstDoorPos.x -= 25;
			}
			if(roomsStepsList[iv] == 5){
				InstPos.y -= 50;
				InstDoorPos = InstPos;

				int RandDoorWallDir =Random.Range(1,4);
				if(RandDoorWallDir==1){
					InstDoorPos.z -= 25;
				}else if(RandDoorWallDir==2){
					InstDoorPos.x -= 25;
				}else if(RandDoorWallDir==3){
					InstDoorPos.z += 25;
				}else if(RandDoorWallDir==4){
					InstDoorPos.x += 25;
				}

			}
			if(roomsStepsList[iv] == 6){
				InstPos.y += 50;
				InstDoorPos = InstPos;
				
				int RandDoorWallDir =Random.Range(1,4);
				if(RandDoorWallDir==1){
					InstDoorPos.z -= 25;
				}else if(RandDoorWallDir==2){
					InstDoorPos.x -= 25;
				}else if(RandDoorWallDir==3){
					InstDoorPos.z += 25;
				}else if(RandDoorWallDir==4){
					InstDoorPos.x += 25;
				}


			}
			
			var temp = Instantiate(TestRoomPrefab,Vector3.zero,Quaternion.Euler(0,0,0))as GameObject;
			var tempDoor = Instantiate(TestDoorPrefab,Vector3.zero,Quaternion.Euler(0,0,0))as GameObject;

			tempDoor.transform.parent = this.transform;
			temp.transform.parent = this.transform;


			temp.transform.localPosition = InstPos;
			tempDoor.transform.localPosition = InstDoorPos;


			temp.name = "Dung_"+this.name+"-Room_"+((iv+1).ToString("000"));
			tempDoor.name = "tempDoor_"+((iv).ToString ("000"));

			 
			int[] WallFreePos= new int[7];
			WallFreePos[0]=-3;
			WallFreePos[1]=-2;
			WallFreePos[2]=-1;
			WallFreePos[3]=0;
			WallFreePos[4]=1;
			WallFreePos[5]=2;
			WallFreePos[6]=3;

			Ray rayOrigin = new Ray(temp.transform.position,tempDoor.transform.position-temp.transform.position);
			RaycastHit hitInfo;


			while(Physics.Raycast(rayOrigin,out hitInfo,30f,1 << 8))
			{

				//print("TempDoor Overlap_"+iv);
				Random.seed +=  (int)(1+InstDoorPos.x+InstDoorPos.y+InstDoorPos.z)  ;
				int DoorWallPosH = Random.Range(0,WallFreePos.Length);



				Vector3 roomDoorDir = InstDoorPos - InstPos;
				if (Vector3.Angle(roomDoorDir, Vector3.forward) <= 45.0) {
					InstDoorPos.x = InstPos.x + 6*WallFreePos[DoorWallPosH];

				}
				else if (Vector3.Angle(roomDoorDir, Vector3.right) <= 45.0) {
					InstDoorPos.z = InstPos.z + 6*WallFreePos[DoorWallPosH];
				}
				else if (Vector3.Angle(roomDoorDir, Vector3.back) <= 45.0) {
					InstDoorPos.x = InstPos.x +  6*WallFreePos[DoorWallPosH];
				}
				else if (Vector3.Angle(roomDoorDir, Vector3.left) <= 45.0) {
					InstDoorPos.z = InstPos.z +6*WallFreePos[DoorWallPosH];
				}
				//print("___--_"+DoorWallPosH);

				tempDoor.transform.localPosition = InstDoorPos;

				rayOrigin = new Ray(this.transform.localPosition,tempDoor.transform.position);

			}



			Debug.DrawRay (temp.transform.position, tempDoor.transform.position-temp.transform.position, Color.green,1000f);		
			tempDoor.transform.gameObject.layer = 8 ;

		



			if(iv == 0 ){
				temp.GetComponent<roomCallerTEst001> ().CallerDoor_AddDoorToList(6,0,0,iv);

				int NextRoomDoor = 1;
				if(roomsStepsList[iv+1] == 1){NextRoomDoor=3;}
				if(roomsStepsList[iv+1] == 2){NextRoomDoor=4;}
				if(roomsStepsList[iv+1] == 3){NextRoomDoor=1;}
				if(roomsStepsList[iv+1] == 4){NextRoomDoor=2;}
				if(roomsStepsList[iv+1] == 5){NextRoomDoor=6;}
				if(roomsStepsList[iv+1] == 6){NextRoomDoor=5;}

				temp.GetComponent<roomCallerTEst001> ().CallerDoor_AddDoorToList(NextRoomDoor,0,0,iv);

			}else if(iv == NumberOfRoomsSteps ){


			}else{

				temp.GetComponent<roomCallerTEst001> ().CallerDoor_AddDoorToList(roomsStepsList[iv],0,0,iv);
				int NextRoomDoor= 1;
				if(roomsStepsList[iv+1] == 1){NextRoomDoor=3;}
				if(roomsStepsList[iv+1] == 2){NextRoomDoor=4;}
				if(roomsStepsList[iv+1] == 3){NextRoomDoor=1;}
				if(roomsStepsList[iv+1] == 4){NextRoomDoor=2;}
				if(roomsStepsList[iv+1] == 5){NextRoomDoor=6;}
				if(roomsStepsList[iv+1] == 6){NextRoomDoor=5;}
				
				temp.GetComponent<roomCallerTEst001> ().CallerDoor_AddDoorToList(NextRoomDoor,0,0,iv);
			}




			tempDoor.transform.parent = temp.transform;
				
			
			
		}
		
	}


	/*
	void RoomsList_Full (){


		roomsStepsListTEST[0] = 0;
		roomsStepsListTEST[1] = 1;
		roomsStepsListTEST[2] = 2;
		roomsStepsListTEST[3] = 3;
		roomsStepsListTEST[4] = 4;
		roomsStepsListTEST[5] = 5;
		roomsStepsListTEST[6] = 6;
		roomsStepsListTEST[7] = 0;

		ArrayList RoomsList_Door = new ArrayList();
		ArrayList RoomsList_Pos = new ArrayList();

		Vector3 RoomsList_InstPos = new Vector3(0,0,0);

		for (int iR = 0; iR < roomsStepsListTEST.Length; iR++) {


			//--
			if(roomsStepsListTEST[iR] == 1){
				RoomsList_InstPos.z ++;
			}
			if(roomsStepsListTEST[iR] == 2){
				RoomsList_InstPos.x ++;
			}
			if(roomsStepsListTEST[iR] == 3){
				RoomsList_InstPos.z --;
			}
			if(roomsStepsListTEST[iR] == 4){
				RoomsList_InstPos.x --;
			}
			if(roomsStepsListTEST[iR] == 5){
				RoomsList_InstPos.y ++;
			}
			if(roomsStepsListTEST[iR] == 6){
				RoomsList_InstPos.y --;
			}

			RoomsList_Pos.Add(RoomsList_InstPos);
			//----



			//---
			float[,]DungDoor_list  = new float[,]{ 	
				
				{ roomsStepsListTEST[iR], 0, 0},
				{ roomsStepsListTEST[iR+1], 0, 0}}; 
			
			
			RoomsList_Door.Add(DungDoor_list);
			//--
			

		}


		
	}
	public IList<GameObject> EvemDoorsList = new List<GameObject>();
	public IList<GameObject> OddDoorsList = new List<GameObject>();
	public IList<GameObject> AllDoors = new List<GameObject>();
	//public IList<GameObject> AllDoorsLinst002 = new List<GameObject>();

	void RoomConectionsList (){



		AllDoors = GameObject.FindGameObjectsWithTag("Door").OrderBy( go => go.name ).ToList();
	
		for (int i = 0; i < AllDoors.Count ; i++) {
			print (AllDoors[i]+"______all____________-----________________--");
			//print (AllDoorsLinst002[i]+"______AllDoorsLinst002________________--");
			/*
			if(i%2 ==0){
				OddDoorsList.Add(AllDoors[i]);
				print (AllDoors[i]+"__________________-----___Odd_______--");
			}
			if(i%2 !=0){
				EvemDoorsList.Add(AllDoors[i]);
				print (AllDoors[i]+"__________________-----___Evem_______--"+i+"_____evem");

				print (EvemDoorsList[i].name+"_____evem");


			}
			
		}
	}
	int iSeedHelper=0;
	void DoorToPosition(){
	

		for (int i = 0; i <=  AllDoors.Count; i++) {
		


			if(i%2 !=0 && i!=0 && i!=AllDoors.Count){
				Ray rayOrigin = new Ray(AllDoors[i].transform.parent.transform.position,AllDoors[i].transform.localPosition);
				RaycastHit hitInfo;


				int iSeedHelper=0;

				if(Physics.Raycast(rayOrigin,out hitInfo,30f,1 << 8) & AllDoors[i].transform != hitInfo.transform)
				{
					print(AllDoors[i].transform.eulerAngles);
					Vector3 Norte= new Vector3(0,0,0);
					Vector3 Leste= new Vector3(0,90,0);
					Vector3 Sul= new Vector3(0,180,0);
					Vector3 Oeste= new Vector3(0,-90,0);

					Debug.DrawLine(rayOrigin.origin, hitInfo.point,Color.magenta,100f);

					iSeedHelper++;
					Random.seed = iSeedHelper;

					Vector2 moveNewPos = new Vector2(Random.Range(-4,4),Mathf.Round(Random.Range(0,1001)/1000));
					Vector2 moveNewPosZero = new Vector2(0,0);
					Vector2 moveNewPosNew = new Vector2(-2,0);

					if(moveNewPos == moveNewPosZero ){ moveNewPos = moveNewPosZero;}

					if(AllDoors[i].transform.eulerAngles == Norte){
								
						AllDoors[i].transform.localPosition = new Vector3(moveNewPos.x*5,moveNewPos.y*5,AllDoors[i].transform.localPosition.z);

					}else if(AllDoors[i].transform.eulerAngles == Leste){
						AllDoors[i].transform.localPosition = new Vector3(AllDoors[i].transform.localPosition.x,moveNewPos.y*5,moveNewPos.x*5);	
						
					}else if(AllDoors[i].transform.eulerAngles == Sul){
						AllDoors[i].transform.localPosition = new Vector3(moveNewPos.x*5,moveNewPos.y*5,AllDoors[i].transform.localPosition.z);							
							
					}else if(AllDoors[i].transform.eulerAngles == Oeste){
							
						AllDoors[i].transform.localPosition = new Vector3(AllDoors[i].transform.localPosition.x,moveNewPos.y*5,moveNewPos.x*5);	
					}

				}

			}else if(i%2 ==0 && i!=0 && i!=AllDoors.Count ){

				if(Mathf.Abs(AllDoors[i].transform.position.y - AllDoors[i-1].transform.position.x)>30){
					//upDown
					AllDoors[i].transform.position =new Vector3( AllDoors[i-1].transform.position.x ,AllDoors[i].transform.position.y,AllDoors[i-1].transform.position.z);
					AllDoors[i].transform.rotation = AllDoors[i-1].transform.rotation;

				}else{
					//sides
					AllDoors[i].transform.position = AllDoors[i-1].transform.position;
				}



				
			}
			
		}	
		
	}
	
	*/
	
	

	void Update() {

		if (GameObject.Find("Dungeon_").transform.GetComponent<DungCreatorStepCounter02> ().dungCreatiStep == 4) {
			print("4 key _ REarenging room list");
			//RoomConectionsList ();

			
			//DoorToPosition();
		}
		
		
	}


}

















