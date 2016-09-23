using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class FronteirasCreator : MonoBehaviour {

	public int OverWorldPositionX = 0;
	public int OverWorldPositionZ = 0;

	public GameObject FronteiraWestObj  ;
	public GameObject FronteiraEastObj  ;
	public GameObject FronteiraNorthObj ;
	public GameObject FronteiraSouthObj ;

	public bool useRealPos;




	// Use this for initialization
	void Start () {

		OverWorldPositionX = RegiaoInfo.OverWorldPositionX;

		OverWorldPositionZ = RegiaoInfo.OverWorldPositionZ;



		if(useRealPos){
			OverWorldPositionX = Mathf.RoundToInt( this.transform.position.x);
			OverWorldPositionZ = Mathf.RoundToInt( this.transform.position.z);
		}

		createFronteiras ();
	}
	
	// Update is called once per frame
	void Update () {






		if(useRealPos){
			OverWorldPositionX = Mathf.RoundToInt( this.transform.position.x)/1000;
			OverWorldPositionZ = Mathf.RoundToInt( this.transform.position.z)/1000;

			createFronteiras ();
		}






	
	}

	void createFronteiras () {
		/*
		Random.seed =    (((OverWorldPositionX*2)-1)) + (((OverWorldPositionZ*2)+0));
		float FronteiraWestTipe = Mathf.Round (Random.value * 10);

		Random.seed =   (((OverWorldPositionX*2)+1)) + (((OverWorldPositionZ*2)+0));
		float FronteiraEastTipe = Mathf.Round (Random.value * 10);

		Random.seed =    (((OverWorldPositionX*2)+0)) + (((OverWorldPositionZ*2)-1));
		float FronteiraNorthTipe = Mathf.Round (Random.value * 10);

		Random.seed =    (((OverWorldPositionX*2)+0)) + (((OverWorldPositionZ*2)+1));
		float FronteiraSouthTipe = Mathf.Round (Random.value * 10);

		*/


		float FronteiraWestTipe =   Mathf.PerlinNoise(( OverWorldPositionX-0.5f +10)/3,( OverWorldPositionZ     +10)/3)  *20*  Mathf.PerlinNoise(( OverWorldPositionX-0.5f +100)*3,( OverWorldPositionZ     +100)*3);																										      	 														   							   
		float FronteiraEastTipe =   Mathf.PerlinNoise(( OverWorldPositionX+0.5f +10)/3,( OverWorldPositionZ     +10)/3)  *20*  Mathf.PerlinNoise(( OverWorldPositionX+0.5f +100)*3,( OverWorldPositionZ     +100)*3);																										      	 														   							   
		float FronteiraNorthTipe =  Mathf.PerlinNoise(( OverWorldPositionX      +10)/3,( OverWorldPositionZ+0.5f+10)/3)  *20*  Mathf.PerlinNoise(( OverWorldPositionX      +100)*3,( OverWorldPositionZ+0.5f+100)*3);																									      	 														   							   
		float FronteiraSouthTipe =  Mathf.PerlinNoise(( OverWorldPositionX      +10)/3,( OverWorldPositionZ-0.5f+10)/3)  *20*  Mathf.PerlinNoise(( OverWorldPositionX      +100)*3,( OverWorldPositionZ-0.5f+100)*3);




		if(FronteiraWestTipe  <=4){	
			FronteiraWestObj.gameObject.GetComponent<FronteiraArt>().FrontType = 1 ; 
		}else{FronteiraWestObj.gameObject.GetComponent<FronteiraArt>().FrontType = 2 ; 
		}

		if(FronteiraEastTipe  <=4){
			FronteiraEastObj.gameObject.GetComponent<FronteiraArt>().FrontType = 1 ; 
		}else{FronteiraEastObj.gameObject.GetComponent<FronteiraArt>().FrontType = 2 ; 
		}

		if(FronteiraNorthTipe  <=4){
			FronteiraNorthObj.gameObject.GetComponent<FronteiraArt>().FrontType = 1 ; 
		}else{FronteiraNorthObj.gameObject.GetComponent<FronteiraArt>().FrontType = 2 ; 
		}

		if(FronteiraSouthTipe  <=4){
			FronteiraSouthObj.gameObject.GetComponent<FronteiraArt>().FrontType = 1 ; 
		}else{FronteiraSouthObj.gameObject.GetComponent<FronteiraArt>().FrontType = 2 ; 
		}



		FronteiraWestObj.gameObject.GetComponent<FronteiraArt>().activate() ; 
		FronteiraEastObj.gameObject.GetComponent<FronteiraArt>().activate() ; 
		FronteiraNorthObj.gameObject.GetComponent<FronteiraArt>().activate() ; 
		FronteiraSouthObj.gameObject.GetComponent<FronteiraArt>().activate() ; 
}

}
