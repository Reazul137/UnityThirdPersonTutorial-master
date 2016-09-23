#pragma strict


var OverWorldPositionX : int = 0;
var OverWorldPositionZ : int = 0;
var OverWorldHighRand : float =1;




var type : int = 0;
var futType : int = 0;

var TypeBemMal : int = 0;

var TypeAlt : int = 0;
var TypeUmid : int = 0;
var TypeTemp : int = 0;

var TypeVeg : int = 0;
var TypeCiv : int = 0;
var TypeEsp : int = 0;


var rend: Renderer;

var PerlinAlt : float = 1;

var VariationAlt : float = 0;


var scale : float =10;
var scale2 : float =21;


function Start() {
	rend = GetComponent.<Renderer>();
	//rend.enabled = false;
	
	//yield WaitForSeconds(5);
	//rend.enabled = true;

	PerlinAlt = (((Mathf.PerlinNoise((this.transform.position.x/scale)+400, (this.transform.position.z/scale)+400)*1.1)*(Mathf.PerlinNoise((this.transform.position.x/scale2)+400, (this.transform.position.z/scale2)+400)*20)) *OverWorldHighRand);



	caCubeColorir ();




}


function Update () {


	

	//print(PerlinAlt+"__"+this);
	
	caCubeColorir ();
}






function caCubeColorir () {




	type = futType;
	
	if(type <= 0){
	futType = 0;
	GetComponent.<Renderer>().material.color =   Color(0, 0, 0, 1); 
	this.transform.position.y = (PerlinAlt*-1)+VariationAlt;	
	}

	if(type == 1){

	GetComponent.<Renderer>().material.color =  Color(0, PerlinAlt/10, 0, PerlinAlt) ; 
	this.transform.position.y = (PerlinAlt*1)+VariationAlt;
	}
	
	if(type == 2){

	GetComponent.<Renderer>().material.color = Color(0, 0, 1, 1) ; 	
	this.transform.position.y = (PerlinAlt*-1)+VariationAlt;
	}
	
	if(type > 2){
	
		futType = 0;
		this.transform.position.y = (PerlinAlt* 1)+VariationAlt;
	}
}