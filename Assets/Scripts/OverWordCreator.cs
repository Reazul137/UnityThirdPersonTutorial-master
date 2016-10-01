using UnityEngine;
using System.Collections;

public class OverWordCreator : MonoBehaviour {


	private float rA = 1F;
	private float rB = 2F;
	private float rC = 3F;
	private float rX = 4F;
	private float rZ = 5F;

	private float rEnd = 5F;
	//private float WorldyFake = 0;
	
	void Start() {
		for (int z = 0; z < 20; z++) {
			for (int x = 0; x < 20; x++) {


				GameObject mapNod = GameObject.CreatePrimitive(PrimitiveType.Quad);
				mapNod.transform.position = new Vector3(x, 0, z);
				mapNod.transform.Rotate(90,0,0);

				rX = mapNod.transform.position.x + 1.1f;
				rZ = mapNod.transform.position.z + 1.1f;


				rA = (Mathf.Sin( rX / (rZ * 33)+1) *  Mathf.Sin( (rZ * (rX * 3)))+1);
				rB = (Mathf.Cos( rX / (rZ * 42)+1) *  Mathf.Cos( (rZ * (rX * 42)))+1);
				rC = (Mathf.Cos( rX / (rZ * 100)+1) *  Mathf.Sin( (rZ * (rX* 100)))+1);


				rEnd = Mathf.Round((rA +  rB + rC)*10);


				print(rEnd);

				if(rEnd<=10){
					mapNod.GetComponent<Renderer>().material.color =  Color.black;
				}else if(rEnd<=15){
					mapNod.GetComponent<Renderer>().material.color =  Color.red;
				}else if(rEnd<=16){
					mapNod.GetComponent<Renderer>().material.color =  Color.yellow;
				}else if(rEnd<=34){
					mapNod.GetComponent<Renderer>().material.color =  Color.blue;
				}else if(rEnd<=45){
					mapNod.GetComponent<Renderer>().material.color = Color.green;
				}else if(rEnd<=45){
					mapNod.GetComponent<Renderer>().material.color =  Color.cyan;
				}else{
					mapNod.GetComponent<Renderer>().material.color =  Color.white;
				};



			}
		}
	}
	
	// Update is called once per frame
	void Update () {



		}
	}

