#pragma strict
var regiaoPrefab : GameObject;
var FronteiraPrefab : GameObject;
var MoodCreator : GameObject;

var OverWorldPositionX: int = 0;
var OverWorldPositionZ: int= 0;	

function Start () {

	yield WaitForSeconds (1);

	OverWorldPositionX = RegiaoInfo.OverWorldPositionX;
	OverWorldPositionZ = RegiaoInfo.OverWorldPositionZ;



	var regiaoPrefab:GameObject = Instantiate (regiaoPrefab, transform.position, transform.rotation);
	regiaoPrefab.GetComponent.<CA>().OverWorldPositionX=OverWorldPositionX;
	regiaoPrefab.GetComponent.<CA>().OverWorldPositionZ=OverWorldPositionZ;


	var NewFronteiraPrefab:GameObject = Instantiate (FronteiraPrefab, transform.position, transform.rotation);
	var MoodCreator:GameObject = Instantiate (MoodCreator, transform.position, transform.rotation);




	Destroy(this.gameObject);

}

function Update () {
		/*/if(Input.GetMouseButtonDown(0))
			//Debug.Log("Pressed left click."+this);
   if (Input.GetButtonDown ("0")) 
   {
   
   	var ray : Ray = Camera.main.ScreenPointToRay(Input.MousePosition);

      Raycasthit hit;
      //this if checks, a detection of hit in an GameObject with the mouse on screen
      if(Physics.Raycast(ray, hit))
      {

         Debug.Log("Pressed left click."+this);
      }
   }	*/
}

function OnMouseDown ()
{

}