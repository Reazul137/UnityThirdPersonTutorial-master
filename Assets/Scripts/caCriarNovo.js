#pragma strict

var regiaoPrefab : GameObject;

function Start () {

}

function Update () {

}



function OnTriggerEnter (OWcameraFrame : Collider) {
     if (OWcameraFrame.gameObject.tag == "OWcameraFrameWest") {
         Instantiate (regiaoPrefab, Vector3(transform.position.x + 150, transform.position.y, transform.position.z), transform.rotation);
     }
     
      if (OWcameraFrame.gameObject.tag == "OWcameraFrameEast") {
        
         transform.position.x -= 150;
     }
          
      if (OWcameraFrame.gameObject.tag == "OWcameraFrameSouth") {
         
         transform.position.z += 100;
     }
          
      if (OWcameraFrame.gameObject.tag == "OWcameraFrameNorth") {
        
         transform.position.z -= 100;
     }
 }
