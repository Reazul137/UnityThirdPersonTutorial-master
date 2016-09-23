	#pragma strict
var currentPos : Vector3;


var  leftX : float = 0;
var  leftY : float = 0;
	
function Start () {

}

function Update () {

	leftX = Input.GetAxis("Horizontal");
	leftY = Input.GetAxis("Vertical");
	
	this.transform.position.x +=leftX;
	this.transform.position.z +=leftY;
	
	


}
