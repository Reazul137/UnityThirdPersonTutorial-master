using UnityEngine;
using System.Collections;

public class CdTParent1 : MonoBehaviour {


	public bool Mestre;
	
	public GameObject objCreadordeTrees1	 ;

	public float WoldSize = 1.0F;
	public float HighSise = 1.0F;
	public float whideSise = 1.0F;


	public float DivercidadeClone = 0.5F;


	RaycastHit hit;

	// Use this for initialization
	void Start () {

		DivercidadeClone =  Random.Range(0.9F, 1.1F);


		if (Physics.Raycast (transform.position, -Vector3.up, out hit)) {
			if (hit.collider.tag == "Terrain") {
				transform.position = new Vector3 (transform.position.x, transform.position.y - hit.distance, transform.position.z);
			}else { Destroy (gameObject);}
		}
		

		
	}


	
	// Update is called once per frame
	void Update () {
		if(objCreadordeTrees1.GetComponent<CreadordeTrees1>().AllRandomIsOn){

		WoldSize = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().WoldSize) * DivercidadeClone;
		HighSise = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().HighSise)* DivercidadeClone;
		whideSise = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().whideSise)* DivercidadeClone;

		transform.localScale = new Vector3( whideSise * (WoldSize) , HighSise * (WoldSize),whideSise * (WoldSize));	
		transform.eulerAngles = new Vector3(0, (380 * 10 *(0.9f-DivercidadeClone)), 0);



		}
	}
}
