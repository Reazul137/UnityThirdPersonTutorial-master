#pragma strict

function Start () {

}

function Update () {

}

 function OnTriggerEnter (other : Collider) {



 		//print(other);
		if(other != false && other.gameObject.tag == "RegCre_higthMap"){



		//Debug.Log(other.gameObject.name);	
		if(other.GetComponent(caCube).VariationAlt != null){ 
	 	other.GetComponent(caCube).VariationAlt  += 10;
	 	Debug.DrawLine ( Vector3 (other.transform.position.x, 0, other.transform.position.z),Vector3 (other.transform.position.x, 200, other.transform.position.z), Color.white, 5 );
	 	}






 		}
 	
 
 }