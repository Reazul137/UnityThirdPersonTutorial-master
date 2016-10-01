using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Dung_RoomCreator : MonoBehaviour {

	public bool RandomUseSeedForTest = false;
	public bool UseCallerSeed;
	public int RoomRandomSeed;
	public int RoomDificulte = 1;
	public FloorTipe RoomFloorTipe =	FloorTipe.bottomlessPit;
	public int RoomObstMidHigth =	0;



	public GameObject DungDoor;
	public GameObject DungDoorUp;
	public GameObject DungDoorDw;
	public GameObject DungObst;

	public GameObject DungPit;
	public GameObject DungFloor;
	public GameObject DungRoof;


	int nDoors = 0;

	public float [,] DungDoor_list  ;


	public int DoorNumber;

	int nDoorsNorte = 0;
	int nDoorsOeste = 0;
	int nDoorsSul = 0;
	int nDoorsLeste = 0;
	int nDoorsTeto = 0;
	int nDoorsChao = 0;

	int DNn=0;
	int DOn=0;
	int DSn=0;
	int DLn=0;
	int DUpn=0;
	int DDwn=0;
	int PlataformSise;


	public List<string> CallerRooms_list = new List<string>();
	

	void Start() {
	
			}

	void Update() {

		if (GameObject.Find("Dungeon_").transform.GetComponent<DungCreatorStepCounter02> ().dungCreatiStep == 3) {
				print ("3 key _create Rooms!!!");

	

			if (RandomUseSeedForTest) {

				nDoors = Random.Range (1, 4) * 2;
				//nDoors = Mathf.Abs( (Random.Range(1,4) * Random.Range(1,4))-4)*2;
			
				DungDoor_list = new float[nDoors, 3];
			
				for (int i = 0; i < nDoors; i++) {
					DungDoor_list [i, 0] = Random.Range (1, 7);
					DungDoor_list [i, 2] = Random.Range (-4, 4);
				
				
					if ((i) % 2 == 0) {
						DungDoor_list [i, 1] = 0;
					
					} else {
						DungDoor_list [i, 1] = Random.Range (1, 4);
					}
				}
			


			} else {
				Random.seed = RoomRandomSeed;

			}


			if (UseCallerSeed) {


				Random.seed = RoomRandomSeed;



				nDoors = DungDoor_list.GetLength (0);
		



			}





			CreateDoorsList ();


			CreateDoorsGameObj ();

			}

		if (GameObject.Find("Dungeon_").transform.GetComponent<DungCreatorStepCounter02> ().dungCreatiStep == 5) {
			print("5 key _ ObstAndPaths");
			CreateObstGameObj ();
			
			CreateFloor ();
			CreateRoof ();

		}
	}

	public enum FloorTipe
	{
		lowerPathWalkable,
		bottomlessPit


	}

	void CreateFloor (){
		if( Random.Range(1,10) < 5){

			RoomFloorTipe = FloorTipe.lowerPathWalkable;
		}else{
			RoomFloorTipe = FloorTipe.bottomlessPit;
		}


		switch (RoomFloorTipe) {
		case FloorTipe.lowerPathWalkable:
			Destroy (DungPit);

			DungFloor.transform.localPosition = new Vector3(0,GameObject.Find(this.name + "/RoomObst_1to2").transform.localPosition.y,0);

			
			break;
		case FloorTipe.bottomlessPit:
			Destroy (DungFloor);	
			break;
		}

	}


	void CreateRoof (){

		DungRoof.transform.localPosition = new Vector3(0,Random.Range( nDoors*4f ,25) ,0);
	}



	void CreateDoorsList (){



		for(int i = 0; i < nDoors; i++)
		{
			if (DungDoor_list [i,0] == 1){

				nDoorsNorte ++;

			}
			if (DungDoor_list [i,0] == 2){

				nDoorsOeste ++;		
			}
			if (DungDoor_list [i,0] == 3){

				nDoorsSul ++;
			}
			if (DungDoor_list [i,0] == 4){

				nDoorsLeste ++;
			}
			if (DungDoor_list [i,0] == 5){

				nDoorsTeto ++;
			}
			if (DungDoor_list [i,0] == 6){
				nDoorsChao ++;
			}


		

		}
		//print("N_"+nDoorsNorte+"--O_"+nDoorsOeste+"--S_"+nDoorsSul+"--L_"+nDoorsLeste+"--Up_"+nDoorsTeto+"--Dw_"+nDoorsChao); 
	}
	public List<GameObject> TempDoor_gameObjects = new List<GameObject>();


	void CreateDoorsGameObj (){

		
		for (int iGC = this.transform.childCount-1 ; iGC >= 0; --iGC)
		{
			if(transform.GetChild(iGC).name.Substring(0,1)=="t"){

				TempDoor_gameObjects.Add(transform.GetChild(iGC).gameObject);

			}
		}


		var TempDoor_gameObjects_sortedList = TempDoor_gameObjects.OrderBy(go=>go.name).ToList();
		for (int i = 0; i < nDoors; i++) {

			if(i%2==0){


				var tempPos = TempDoor_gameObjects_sortedList[i/2].transform.position;
				
				var temp = Instantiate (DungDoor,  tempPos, Quaternion.Euler (0, 0, 0))as GameObject;
				temp.transform.parent = transform;

				temp.name = "Room_" + this.name + "_Door_" + ((i + 1).ToString ("000"));


				DungDoor.GetComponent<DoorRotation>().DoorNumberName = TempDoor_gameObjects_sortedList[i/2].transform.name;



			}

			if(i%2==1){
				
				var tempPos = new Vector3(0,0,0);

				//print ( TempDoor_gameObjects_sortedList[i/2].transform.name.Substring(9,3));

				int result = 0;
				int.TryParse( TempDoor_gameObjects_sortedList[i/2].transform.name.Substring(9,3), out result);

				//print(  "tempDoor_"+ ((result)+1).ToString ("000"));

				if(GameObject.Find(  "tempDoor_"+ ((result)+1).ToString ("000")) ==null){


					tempPos = this.transform.position + new Vector3(Random.Range(-10,10),6,Random.Range(-10,10));

				}else{
					tempPos.x =GameObject.Find(  "tempDoor_"+ ((result)+1).ToString ("000")).transform.position.x;
					tempPos.z =GameObject.Find(  "tempDoor_"+ ((result)+1).ToString ("000")).transform.position.z;
					tempPos.y =this.transform.position.y;
				}

				var temp = Instantiate (DungDoor,  tempPos, Quaternion.Euler (0, 0, 0))as GameObject;
				temp.transform.parent = transform;
				temp.name = "Room_" + this.name + "_Door_" + ((i + 1).ToString ("000"));




			
			}



		}
	}
	
	
	/*
	void CreateDoorsGameObj (){
	
	
		for (int i = 0; i < nDoors; i++) {
			
			if (DungDoor_list [i,0] == 1){
				var temp = Instantiate(DungDoor,new Vector3( 0, 0 , 25) + this.transform.position,Quaternion.Euler(0, 0, 0))as GameObject;
				temp.transform.parent = transform;
				temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
			}
			if (DungDoor_list [i,0] == 2){
				var temp = Instantiate(DungDoor,new Vector3( 25, 0 , 0) + this.transform.position, Quaternion.Euler(0, 90, 0))as GameObject;
				temp.transform.parent = transform;
				temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
			}
			if (DungDoor_list [i,0] == 3){
				var temp = Instantiate(DungDoor,new Vector3( 0, 0 , -25) + this.transform.position,Quaternion.Euler(0, 180, 0))as GameObject;
				temp.transform.parent = transform;
				temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
			}
			if (DungDoor_list [i,0] == 4){
				var temp = Instantiate(DungDoor,new Vector3( -25, 0 , 0) + this.transform.position, Quaternion.Euler(0, 270, 0))as GameObject;
				temp.transform.parent = transform;
				temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
			}
			if (DungDoor_list [i,0] == 5){
				var onWallTipe = Random.Range(1,4);
				var tempDoorPos = new Vector3(0,0,0) ;
				
				
				
				if(onWallTipe == 1 ){ 
					tempDoorPos =new Vector3( 0, 0 , 25);
					var temp = Instantiate(DungDoorUp,tempDoorPos + this.transform.position, Quaternion.Euler(0, 0, 0))as GameObject;
					temp.transform.parent = transform;
					temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
				}
				
				
				if(onWallTipe == 2 ){ 
					tempDoorPos =new Vector3( 25, 0 , 0);
					var temp = Instantiate(DungDoorUp,tempDoorPos + this.transform.position, Quaternion.Euler(0, 90, 0))as GameObject;
					temp.transform.parent = transform;
					temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
				}
				if(onWallTipe == 3 ){ 
					tempDoorPos =new Vector3(0, 0 , -25);
					var temp = Instantiate(DungDoorUp,tempDoorPos + this.transform.position, Quaternion.Euler(0, 180, 0))as GameObject;
					temp.transform.parent = transform;
					temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
				}
				if(onWallTipe == 4 ){ 
					tempDoorPos =new Vector3( -25, 0 , 0);
					var temp = Instantiate(DungDoorUp,tempDoorPos + this.transform.position, Quaternion.Euler(0, 270, 0))as GameObject;
					temp.transform.parent = transform;
					temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
				}
				
				
				
			}
			if (DungDoor_list [i,0] == 6){
				var onWallTipe = Random.Range(1,4);
				var tempDoorPos = new Vector3(0,0,0) ;
				
				if(onWallTipe == 1 ){
					tempDoorPos =new Vector3( 0, 0 , 25);
					var temp = Instantiate(DungDoorDw,tempDoorPos + this.transform.position, Quaternion.Euler(0, 0, 0))as GameObject;
					temp.transform.parent = transform;
					temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
				}
				if(onWallTipe == 2 ){
					tempDoorPos =new Vector3( 25, 0 , 0);
					var temp = Instantiate(DungDoorDw,tempDoorPos + this.transform.position, Quaternion.Euler(0, 90, 0))as GameObject;
					temp.transform.parent = transform;
					temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
				}
				if(onWallTipe == 3 ){
					tempDoorPos =new Vector3(0, 0 , -25);
					var temp = Instantiate(DungDoorDw,tempDoorPos + this.transform.position, Quaternion.Euler(0, 180, 0))as GameObject;
					temp.transform.parent = transform;
					temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
				}
				if(onWallTipe == 4 ){ 
					tempDoorPos =new Vector3( -25, 0 , 0);
					var temp = Instantiate(DungDoorDw,tempDoorPos + this.transform.position, Quaternion.Euler(0, 270, 0))as GameObject;
					temp.transform.parent = transform;
					temp.name = "Room_"+this.name+"_Door_"+((i+1).ToString("000"));
				}			
				
			}	


		}
	}*/



	void CreateObstGameObj(){
		for (int i = 1; i < nDoors+1; i++) {

			if(i>1 && i%2==0 ){

			GameObject temp = Instantiate(DungObst,new Vector3( Random.Range(-10,10), (-3)+ (((i) -(nDoors/2))*2)*1.5f, Random.Range(-10,10)) + this.transform.position	, Quaternion.Euler(0, 0, 0)) as GameObject;
			temp.transform.parent = transform;
				temp.gameObject.GetComponent<ObstCreator>().DoorIn = GameObject.Find(  "Room_"+this.name+"_Door_"+((i-1).ToString("000")));
				temp.gameObject.GetComponent<ObstCreator>().DoorOut = GameObject.Find(  "Room_"+this.name+"_Door_"+((i).ToString("000")));
			//temp.gameObject.GetComponent<ObstCreator>().TipeOfObst = DungDoor_list [i,1] ;


			temp.name = "RoomObst_"+(i-1)+"to"+(i);

				PlataformSise = Random.Range(1,4);

				temp.transform.GetChild(0).localScale =new Vector3( PlataformSise,1,PlataformSise);

			}
		

		}
	
	}
		



}




















