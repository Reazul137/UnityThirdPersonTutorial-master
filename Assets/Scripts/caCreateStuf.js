

#pragma strict

var InterestPoint : GameObject;
var CaParent : GameObject;

var OverWorldPositionX : int = 0;
var OverWorldPositionZ : int = 0;

var DivTerra : int = 10;

var moveToX : int = 0;
var moveToZ : int = 0;

var cols : int = 0;
var rows : int = 0;	

var createStep : int = 0;	

var createType : int = 0;




function Start () {

	OverWorldPositionX = this.transform.parent.gameObject.GetComponent(CA).OverWorldPositionX;
	OverWorldPositionZ = this.transform.parent.gameObject.GetComponent(CA).OverWorldPositionZ;
	cols = this.transform.parent.gameObject.GetComponent(CA).cols;
	rows = this.transform.parent.gameObject.GetComponent(CA).rows;

	Random.seed = (((this.transform.position.x + OverWorldPositionX) * 10) + (this.transform.position.z + OverWorldPositionZ +0.1f));
	DivTerra  = Mathf.Round(( Random.value * 50)*( Random.value * 1)) + 10;



}

function Update () {

//print("_"+createStep);
	
	//Destroy (gameObject, 5);
	
	if(createStep >= DivTerra){Destroy (this.gameObject);}

 if (Time.timeSinceLevelLoad >= 1)
     {
		for (var u : int =0; u< DivTerra; u++){
			Random.seed = (((this.transform.position.x + OverWorldPositionX) * 10) + (this.transform.position.z + OverWorldPositionZ +u));
			var ThisPositionx : int = Mathf.Round( Random.value * ((cols*0.8f) -1)) + (cols*0.1f);   ///var ThisPositionx : int = Mathf.Round( Random.value * ((cols/2) -1)) + (cols/4);


			Random.seed = (((this.transform.position.x + OverWorldPositionX) * 10) + (this.transform.position.z + OverWorldPositionZ)+1 +u);
			var ThisPositionZ : int = Mathf.Round( Random.value * ((rows*0.8f) -1)) + (rows*0.1f);    ///var ThisPositionZ : int = Mathf.Round( Random.value * ((rows/2) -1)) + (cols/4);



			Random.seed = ((this.transform.localPosition.x*10 + this.transform.localPosition.z)+ OverWorldPositionX*10 + OverWorldPositionZ);
			createType  = (Mathf.Round(Random.value * 1)+1);

			this.transform.localPosition.x = ((ThisPositionx)-(cols/2))*4;
			this.transform.localPosition.z = ((ThisPositionZ)-(rows/2))*4;



			//print( CaParent.name);

			if(u ==0){createType  = 1;}
			var GridCAcube : Collider = ( CaParent.GetComponent(CA).grid[ThisPositionx,ThisPositionZ].GetComponent.<Collider>() );

			ChangeCAcube (GridCAcube);



			createStep++;
			//print(u);
			//if (u >= DivTerra-1){Destroy (gameObject);}
		}
	}
	

}
/*
 function OnTriggerEnter (other : Collider) {

 	ChangeCAcube (other);

 }
*/


 function ChangeCAcube (other : Collider ) {



 		//print(other);
		if(other != false && other.gameObject.tag == "RegCre_higthMap"){



		//Debug.Log(other.gameObject.name);	

		if(other.gameObject.GetComponent(caCube).type != null){ 

			
	 		other.gameObject.GetComponent(caCube).futType =createType; 

	 	}

	 	if(createType == 1){	Debug.DrawLine ( Vector3 (this.transform.position.x, 0, this.transform.position.z),Vector3 (this.transform.position.x, 100, this.transform.position.z), Color.green, 200 );
							 	Instantiate (InterestPoint, this.transform.position, this.transform.rotation);
	 	}
	 	if(createType == 2)	Debug.DrawLine ( Vector3 (this.transform.position.x, 0, this.transform.position.z),Vector3 (this.transform.position.x, 100, this.transform.position.z), Color.blue, 200 );


	 	//Instantiate (InterestPoint, this.transform.position, this.transform.rotation);
	 	//InterestPoint.GetComponent.<Renderer>().material.color = Color.black;


 		}
 	

 	//Destroy (other.GetComponent.<Collider>());

 	
 
 }