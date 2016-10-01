#pragma strict



var corRandom : int = 0;

function  Update () {
	// If you comment out the following line, the sequence of random
	// values will be different each time you run. However, the sequence
	// will always be the same for any particular seed value.
		Random.seed = ((this.transform.position.x * 10) + this.transform.position.z);
		
		corRandom = Mathf.Round(Random.value * 10);
		print(corRandom);
		
		
		if(corRandom == 0){
			GetComponent.<Renderer>().material.color = Color.black;	
		}else if(corRandom == 1){
			GetComponent.<Renderer>().material.color = Color.blue;
		}else if(corRandom == 2){
			GetComponent.<Renderer>().material.color = Color.cyan;
		}else if(corRandom == 3){
			GetComponent.<Renderer>().material.color = Color.gray;
		}else if(corRandom == 4){
			GetComponent.<Renderer>().material.color = Color.green;
		}else if(corRandom == 5){
			GetComponent.<Renderer>().material.color = Color.magenta;
		}else if(corRandom == 6){
			GetComponent.<Renderer>().material.color = Color.red;
		}else if(corRandom == 7){
			GetComponent.<Renderer>().material.color = Color.white;
		}else if(corRandom == 8){
			GetComponent.<Renderer>().material.color = Color.yellow;
		}else if(corRandom == 9){
			GetComponent.<Renderer>().material.color = Color.clear;
		}else if(corRandom == 10){
			GetComponent.<Renderer>().material.color = Color.grey;
		}
	
}