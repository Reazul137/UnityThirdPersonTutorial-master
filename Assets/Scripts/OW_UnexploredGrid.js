#pragma strict



var fronteiraPrefab : GameObject;



function Start () {

	for (var x : int =0; x< 20; x++){
			for (var z : int =0; z< 20; z++){
				
				Instantiate (fronteiraPrefab, Vector3((x-10)*100, 0, (z-10)*100), transform.rotation);
				

				}
	}
}


function Update () {

}
