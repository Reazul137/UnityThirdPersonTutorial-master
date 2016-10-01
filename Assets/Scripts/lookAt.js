#pragma strict

var cameraControler : GameObject;
var cameraPosDrag :  float = 0.05;
var cameraRotDrag :  float = 0.1;
function Start () {

}

function Update () {
	this.transform.position += (cameraControler.transform.position - this.transform.position)*cameraPosDrag;



	var newCamDir = Vector3.RotateTowards(transform.forward, cameraControler.transform.forward, cameraRotDrag, 0.0);
	this.transform.rotation = Quaternion.LookRotation(newCamDir);

}