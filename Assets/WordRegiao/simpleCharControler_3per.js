#pragma strict
var charIdleSpeed : float = 1;
var charIdleTurnSpeed : float = 1;
var charIdleJump : float = 0.1;

var cameraControler : GameObject;

private var charMoveSpeed : float = 1;



function Start () {

}

function Update () {
if(Input.GetAxis("gameLeftStickx") || Input.GetAxis("gameLeftSticky")){
	var CharImputMoviment = Vector3(Input.GetAxis("gameLeftStickx"), 0, Input.GetAxis("gameLeftSticky")*-1);
	
	charMoveSpeed = CharImputMoviment.magnitude * charIdleSpeed;
	//print(charMoveSpeed);
	
	this.transform.position += this.transform.forward * charMoveSpeed;
	
	Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y +2, this.transform.position.z), CharImputMoviment, Color.green);
	Debug.DrawRay(cameraControler.transform.position, CharImputMoviment, Color.red);
	
		var targetDir = CharImputMoviment - transform.position;
		
	    // The step size is equal to speed times frame time.
	    var step = 1 ;
	    
	    var newDir = Vector3.RotateTowards(transform.forward, CharImputMoviment, step, 0.0);

	    // Move our position a step closer to the target.
	    transform.rotation = Quaternion.LookRotation(newDir);
}	
	
		if(Input.GetButton("gameBot0")){
			this.transform.position += this.transform.up * charIdleJump;
		
		}
	
	/*
	if(Input.GetAxis("gameBot0")){print("gameBot0_"+Input.GetAxis("gameBot0"));}
	if(Input.GetAxis("gameBot1")){print("gameBot1_"+Input.GetAxis("gameBot1"));}
	if(Input.GetAxis("gameBot2")){print("gameBot2_"+Input.GetAxis("gameBot2"));}
	if(Input.GetAxis("gameBot3")){print("gameBot3_"+Input.GetAxis("gameBot3"));}
	
	if(Input.GetAxis("gameBot11")){print("gameBot11_"+Input.GetAxis("gameBot11"));}
	
	
	if(Input.GetAxis("gameLeftStickx")){print("Leftx_"+Input.GetAxis("gameLeftStickx"));}
	if(Input.GetAxis("gameLeftSticky")){print("Lefty_"+Input.GetAxis("gameLeftSticky"));}
	if(Input.GetAxis("gameRighStickx")){print("Righx_"+Input.GetAxis("gameRighStickx"));}
	if(Input.GetAxis("gameRighSticky")){print("Righy_"+Input.GetAxis("gameRighSticky"));}
	*/
}