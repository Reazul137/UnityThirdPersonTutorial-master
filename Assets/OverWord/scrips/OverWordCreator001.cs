using UnityEngine;
using System.Collections;

public class OverWordCreator001 : MonoBehaviour {


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

				Renderer rend = mapNod.GetComponent<Renderer>();

				if(rEnd<=10){
					rend.material.SetColor("_SpecColor", Color.black);//black
				}else if(rEnd<=15){
					rend.material.SetColor("_SpecColor", Color.red);//red;
				}else if(rEnd<=16){
					rend.material.SetColor("_SpecColor", Color.yellow);//yellow;
				}else if(rEnd<=34){
					rend.material.SetColor("_SpecColor", Color.blue);//blue;
				}else if(rEnd<=45){
					rend.material.SetColor("_SpecColor", Color.green);//green;
				}else if(rEnd<=45){
					rend.material.SetColor("_SpecColor", Color.cyan);//cyan;
				}else{
					rend.material.SetColor("_SpecColor", Color.white);//white;
				};



			}
		}
	}
	
	// Update is called once per frame
	void Update () {



		}
	}

