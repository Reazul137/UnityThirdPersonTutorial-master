using UnityEngine;
using System.Collections;



public class CradorDungeon : MonoBehaviour {

	public bool isTestRandom;

	public int[] RegionPos;
	public int EntranceCode = 0;
	public int EntranceDifficulty = 1;
	public float[] BiomeCode;


	public int[] DungRoomsCode;


	public int NumberOfRooms;
	public int RoomsSise = 50;

	private int item1Room;
	private int Secret1Room;
	private int Secret2Room;
	private int Colecteble1Room;


	public GameObject RoomPrefab;
	public GameObject DoorPrefab;
	public GameObject ElevPrefab;
	public Vector3 RoomCreatorPos;



	void Start() {

		
		RegionPos = new int[2];
		
		RegionPos [0] = 0;
		RegionPos [1] = 0;




		
		BiomeCode = new float[7];
		
		BiomeCode [0] = 5f;
		BiomeCode [1] = 5f;
		BiomeCode [2] = 5f;
		BiomeCode [3] = 5f;
		BiomeCode [4] = 5f;
		BiomeCode [5] = 5f;
		BiomeCode [6] = 5f;



		if(isTestRandom){		


			
			RegionPos [0] = Random.Range(-100, 100);
			RegionPos [1] = Random.Range(-100, 100);			

			EntranceCode = Random.Range(1, 5);
			
			BiomeCode [0] = Random.Range(0F, 10F);
			BiomeCode [1] = Random.Range(0F, 10F);
			BiomeCode [2] =	Random.Range(0F, 10F);
			BiomeCode [3] = Random.Range(0F, 10F);
			BiomeCode [4] = Random.Range(0F, 10F);
			BiomeCode [5] = Random.Range(0F, 10F);
			BiomeCode [6] = Random.Range(0F, 10F);

		}
		RoomGeneration_step001 ();
		Createstep001Visuals ();

	}


	void RoomGeneration_step001 (){


		//Creating Dungeon Random seed based on entrance "position"
		Random.seed = EntranceCode + 100*RegionPos[0]+ 1000000000 *RegionPos[1];



		//Creating coreRooms path
		NumberOfRooms =  Random.Range(10, 30*EntranceDifficulty);

		DungRoomsCode = new int[NumberOfRooms];


		int i = 0;


		while (i < NumberOfRooms) {
			DungRoomsCode[i] = Random.Range(1, 7);

			i++;
		}

//		print(DungRoomsCode.ToString);
		//Creating SpetialRooms path

		item1Room = Random.Range(1, NumberOfRooms); 		
		print("item1Room"+ item1Room);
		
		Colecteble1Room = Random.Range(1, NumberOfRooms); 		
		print("Colecteble1Room"+ Colecteble1Room);

		Secret1Room = Random.Range(1, NumberOfRooms); 		
		print("Secret1Room"+ Secret1Room);

		Secret2Room = Random.Range(1, NumberOfRooms); 		
		print("Secret2Room"+ Secret2Room);





	}

	
	void Createstep001Visuals () {

		RoomCreatorPos = new Vector3 (0, 0, 0);

		for (int i = 0; i < NumberOfRooms; i++) {
			Vector3 oldRoomPos = RoomCreatorPos;

			if(DungRoomsCode[i] == 1){
				Instantiate(DoorPrefab, RoomCreatorPos,  Quaternion.Euler(0, 180, 0));
				RoomCreatorPos.z -= RoomsSise;}
			if(DungRoomsCode[i] == 2){
				Instantiate(DoorPrefab, RoomCreatorPos,  Quaternion.Euler(0, 90, 0));
				RoomCreatorPos.x += RoomsSise;}
			if(DungRoomsCode[i] == 3){
				Instantiate(DoorPrefab, RoomCreatorPos,  Quaternion.Euler(0, 0, 0));
				RoomCreatorPos.z += RoomsSise;}
			if(DungRoomsCode[i] == 4){
				Instantiate(DoorPrefab, RoomCreatorPos,  Quaternion.Euler(0, -90, 0));
				RoomCreatorPos.x -= RoomsSise;}
			if(DungRoomsCode[i] == 5){
				Instantiate(ElevPrefab, RoomCreatorPos,  Quaternion.Euler(0, -90, 0));
				RoomCreatorPos.y += RoomsSise;}
			if(DungRoomsCode[i] == 6){
				Instantiate(ElevPrefab, RoomCreatorPos,  Quaternion.Euler(180, Random.Range(1, 360), 0));
				RoomCreatorPos.y -= RoomsSise;}



			var temp = Instantiate(RoomPrefab, RoomCreatorPos, Quaternion.identity)as GameObject;
			temp.transform.parent = transform;
			temp.name = "Dung_"+this.name+"-Room_"+(i);





			//RoomPrefab.GetComponentInChildren <MeshRenderer> ().sharedMaterial.color = new Color (Random.Range (0f, 1f), Random.Range (0f, 1f), Random.Range (0f, 1f), 1f);




			Debug.DrawLine( new Vector3(RoomCreatorPos.x,RoomCreatorPos.y+3,RoomCreatorPos.z) ,new Vector3( oldRoomPos.x, oldRoomPos.y+4, oldRoomPos.z),new Color(i/30f, 0.2F, 0.2F, 1F), 100f);




		}

		
	}



	void Update () {

	}
}
