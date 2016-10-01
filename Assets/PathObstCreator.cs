using UnityEngine;
using System.Collections;

public class PathObstCreator : MonoBehaviour {


	public GameObject[] InterestPoints;

	public GameObject RegiaoCenter;
	public GameObject DungEntrance;
	public GameObject Crator_Tree;
	public GameObject Crator_Grass;
	public GameObject Crator_Rock;
	public GameObject Crator_Pott;
	public int[] InterestPointsTipelist;
	// Use this for initialization
	void Start () {


		InterestPoints = GameObject.FindGameObjectsWithTag("InterencePoint");

		InterestPointsTipelist = new int[ InterestPoints.Length];

		print(InterestPointsTipelist.Length);

		if (InterestPoints.Length > 6) {
			AssinInterestPointToPropCretor (1, RegiaoCenter, 0);

			AssinInterestPointToPropCretor (3, DungEntrance, 4);
			AssinInterestPointToPropCretor (3, DungEntrance, 5);
			AssinInterestPointToPropCretor (3, DungEntrance, 6);

			AssinInterestPointToPropCretor (2, Crator_Grass, 1);
			AssinInterestPointToPropCretor (2, Crator_Rock, 2);
			AssinInterestPointToPropCretor (2, Crator_Tree, 3);


		}

		///

		//--tipes
		//---1-CenterHub
		//---2-seneryProp
		//---3-MainDungEntrece
		//---4-Secret
		//---5-sideDung          

	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void AssinInterestPointToPropCretor(int tipe, GameObject Cretor, int arrayPos){

		if(tipe==1){
			Vector3 IntPostion = InterestPoints [arrayPos].transform.position;
			IntPostion.y = 1000;
			//InterestPoints [arrayPos].gameObject.SetActive (false);
			RaycastHit hit;
			if (Physics.Raycast (IntPostion, Vector3.down,out hit, Mathf.Infinity)){
		
				Debug.DrawLine (transform.position,hit.point, Color.red, 2 );

					GameObject IntPot = Instantiate (Cretor, hit.point, Quaternion.Euler (0, 0, 0)) as GameObject;
					IntPot.name = "RegiaoCenter";
			}
		}


		if(tipe==2){
			Vector3 IntPostion = InterestPoints [arrayPos].transform.position;
			IntPostion.y = 1000;
			//InterestPoints [arrayPos].gameObject.SetActive (false);
			RaycastHit hit;
			if (Physics.Raycast (IntPostion, Vector3.down,out hit, Mathf.Infinity)){

				Debug.DrawLine (transform.position,hit.point, Color.red, 2 );


					Vector3 CretorPos = hit.point;
					CretorPos.y = 1000;
					GameObject IntPot = Instantiate (Cretor, CretorPos, Quaternion.Euler(0,0,0)) as GameObject;


			}
		}



		if(tipe==3){
			Vector3 IntPostion = InterestPoints [arrayPos].transform.position;
			IntPostion.y = 1000;
			//InterestPoints [arrayPos].gameObject.SetActive (false);
			RaycastHit hit;
			if (Physics.Raycast (IntPostion, Vector3.down, out hit, Mathf.Infinity)) {


				Vector3 hitPlus = hit.point;
				hitPlus.y += 1;
				Random.seed = RegiaoInfo.OverWorldPositionX + RegiaoInfo.OverWorldPositionZ + this.name.GetHashCode ();

				Vector3 randDir = new Vector3 (Random.Range (-5, 5), 0, Random.Range (-5, 5));
				RaycastHit hit2;
				if (Physics.Raycast (hitPlus, randDir, out hit2, Mathf.Infinity)) {
						
					Debug.DrawLine (hitPlus, hit2.point, Color.cyan, 2);
					Vector3 normalDir = hit2.normal;
					normalDir.y = 0;

					GameObject IntPot = Instantiate (Cretor, hit2.point, Quaternion.LookRotation (normalDir)) as GameObject;


					print ("Wall_!!");


				} else {
					print ("noWall");
					Debug.DrawLine (transform.position, hit.point, Color.cyan, 2);
					GameObject IntPot = Instantiate (Cretor, hit.point, Quaternion.Euler (0, 0, 0)) as GameObject;
				}

				
			}
		}
	}

}
