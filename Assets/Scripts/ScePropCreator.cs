using UnityEngine;
using System.Collections;

public class ScePropCreator : MonoBehaviour {

	public bool isRandom;
	public GameObject Prop ;
	public GameObject PropMester ;
	public Component[] MesterPeacesScript;


	public float AreaRadius;

	public float Spacing;
	public float PosVariant;
	public float RotVariant;
	public float PropAmount;

	public float PropSise=1;
	public float SiseVariant=1;

	public float OverWorldPositionX=0;

	public float OverWorldPositionZ=0;


	public bool isBio;








	// Use this for initialization
	void Start () {

		OverWorldPositionX = RegiaoInfo.OverWorldPositionX;
		OverWorldPositionZ = RegiaoInfo.OverWorldPositionZ;

			CreatMaster( Prop);

		if (isRandom) {
			Random.seed = (int)(12 + OverWorldPositionX * OverWorldPositionZ +this.name.GetHashCode());
			SiseVariant = Random.Range (0, 2) + Random.Range (0, 2);
			AreaRadius = Random.Range (10, 40) * Random.Range (10, 20);

			if (isBio) {
				PropAmount = RegiaoInfo.Var_Flora*Random.Range (10, 100f) ;
				//print (PropAmount);
			} else { PropAmount = (Random.Range (1f, 1000f) + Random.Range (1f, 2000f));
			}

			PropSise = Random.Range (0.1f, 2) + Random.Range (0, 2);
			RotVariant = RegiaoInfo.Var_Variety;
		}



		for(int i = 0; i < PropAmount; i++)
		{
			CreateNewProp (i);
		}
		Destroy (this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void CreateNewProp(int PropNumb){

		Random.seed = PropNumb *(int)((OverWorldPositionX+100)+OverWorldPositionZ);
		RaycastHit hit;
		
		Vector3 NewPosRand =new Vector3(Random.Range(-AreaRadius,AreaRadius)*Random.Range(0.01f,1.01f),-200,Random.Range(-AreaRadius,AreaRadius)*Random.Range(0.01f,1.01f));


		if (Physics.Raycast (transform.position, NewPosRand,out hit, Mathf.Infinity)){

			Debug.DrawLine (transform.position,hit.point, Color.red, 2 );
			if (hit.collider.tag == "Terrain") {

				//Random.seed = PropNumb+100;
				GameObject newProp = Instantiate (PropMester, hit.point, Quaternion.Euler (0, Random.Range (-RotVariant * 180, RotVariant * 180), 0)) as GameObject;
				newProp.transform.localRotation = Quaternion.Euler (0, Random.Range (RotVariant*(-180) , RotVariant*180 ), 0);
				newProp.transform.localScale = new Vector3 (PropSise,PropSise,PropSise);

				Char_BodyMeshMorph	newPropScript = newProp.GetComponent<Char_BodyMeshMorph>();


				newProp.transform.parent = this.transform;


				//print (hit.point);
			}
					
		}
			

	}

	void CreatMaster (GameObject Prop){

		PropMester = Instantiate (Prop, this.transform.position, this.transform.rotation) as GameObject;

		MesterPeacesScript =  PropMester.GetComponentsInChildren<Char_BodyMeshMorph> ();


		foreach (Char_BodyMeshMorph peaceScript in MesterPeacesScript) {


			int PropMesterSeed= Mathf.RoundToInt( (this.name.GetHashCode())+this.transform.position.x+this.transform.position.z+ (this.OverWorldPositionX+100)+this.OverWorldPositionZ)+1;
			//print (PropMesterSeed);
			peaceScript.ActivadeRandom (PropMesterSeed);
			peaceScript.isRandom = false;
			peaceScript.isColorRandom = false;

		}

			                                                             

	}
}
