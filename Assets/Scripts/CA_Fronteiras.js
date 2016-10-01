#pragma strict
var OverWorldPositionX : int = 0;
var OverWorldPositionZ : int = 0;


var FronteiraWest  : int = 0;
var FronteiraEast  : int = 0;
var FronteiraNorth : int = 0;
var FronteiraSouth : int = 0;




function Start () {
	OverWorldPositionX = this.transform.position.x ;
	OverWorldPositionZ = this.transform.position.z ;
	
	///createFronteiras();


}

function createFronteiras () {

		Random.seed = (OverWorldPositionX*10 + OverWorldPositionZ);
		
			FronteiraWest  = (Mathf.Round(Random.value * 1)+1);
			FronteiraEast  = (Mathf.Round(Random.value * 1)+1);
			FronteiraNorth = (Mathf.Round(Random.value * 1)+1);
			FronteiraSouth = (Mathf.Round(Random.value * 1)+1);

		print(FronteiraWest+"_"+FronteiraEast+"_"+FronteiraNorth+"_"+FronteiraSouth);	

				
		
		/*
		Random.seed = ((OverWorldPositionX/ 50) );
		FronteiraNorth = (Mathf.Round(Random.value * 1)+1);		
		Random.seed = ((OverWorldPositionX/ 50 + 1) );
		FronteiraSouth = (Mathf.Round(Random.value * 1)+1);		
		Random.seed = ((OverWorldPositionZ/ 50 ) );
		FronteiraWest = (Mathf.Round(Random.value * 1)+1);		
		Random.seed = ((OverWorldPositionZ/ 50 + 1) );
		FronteiraEast = (Mathf.Round(Random.value * 1)+1);		

		// this.GameObject.Find("FronteiraWest").transform.renderer.material.color = Color.green;		
		*/
		
}


function Update () {
	
}