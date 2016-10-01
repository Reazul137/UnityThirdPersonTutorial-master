#pragma strict

var OverWorldPositionX : int = 0;
var OverWorldPositionZ : int = 0;

var obj : GameObject;
var grid : GameObject[,];

var cols : int = 100;
var rows : int = 100;

var simStepNum : int = 1;

var spacing : float = 1;

var coordinateSeed : float = 1;

var fronteiraRandVal : int = 1;
var rA : int = 1;
var rB : int = 2;
var rC : int = 3;
var rX : int = 4;
var rZ : int = 1;
var rEnd : int = 5;

//private var simOn = false;
private var simOn = true;
var typeNULLcounter : int = 0;



function Start () {


 

	OverWorldPositionX = this.transform.position.x ;
	OverWorldPositionZ = this.transform.position.z ;
	createGrid();


}



function OnMouseDown (){typeNULLcounter = cols*rows+1;}
function Update () {

	//Debug.Log(typeNULLcounter);
	
		         
	
	simStep ();

	if(typeNULLcounter >= cols*rows){
				
		
		 var childs : int = transform.childCount;
 
		 for (var i = childs - 1; i >= 0; i--)
		 {
		     transform.GetChild(i).gameObject.GetComponent.<Renderer>().enabled=true;
		     Destroy (transform.GetChild(i).GetComponent(caCube));
		     Destroy (transform.GetChild(i).gameObject.GetComponent.<Collider>());

		     //transform.GetChild(i).gameObject.collider.enabled = false;
		    
		 }
		 Destroy (this);
	}
	
}


function simStep () {
	for (var x : int =0; x< cols; x++){
		for (var z : int =0; z< rows; z++){
		
			
		
			if(x==0){
				Random.seed = (OverWorldPositionX*10 + OverWorldPositionZ);
				
				if(Mathf.Round(Random.value * 4)+1<=2){
					grid[x,z].GetComponent(caCube).futType=1;
				}else{grid[x,z].GetComponent(caCube).futType=2;}
			}
			if(x==cols-1){
				Random.seed = ((OverWorldPositionX+50)*10 + OverWorldPositionZ);
				
				if(Mathf.Round(Random.value * 4)+1<=2){
					grid[x,z].GetComponent(caCube).futType=1;
				}else{grid[x,z].GetComponent(caCube).futType=2;}
			}
			if(z==0 ){
				Random.seed = (OverWorldPositionX*10 + OverWorldPositionZ);
				
				if(Mathf.Round(Random.value * 4)+1<=2){
					grid[x,z].GetComponent(caCube).futType=1;
				}else{grid[x,z].GetComponent(caCube).futType=2;}
			}
			if(z==rows-1){
				Random.seed = (OverWorldPositionX*10 + (OverWorldPositionZ+50));
								
				if(Mathf.Round(Random.value * 4)+1<=2){
					grid[x,z].GetComponent(caCube).futType=1;
				}else{grid[x,z].GetComponent(caCube).futType=2;}
				
			}
			
			
			
			
			if(x>0 && x<cols-1 && z>0 && z<rows-1){
			
				simStepNum ++;

				rX = x + simStepNum;
				rZ = z + simStepNum;

				Random.seed = ((rX * 10) + rZ);
		
				rEnd = Mathf.Round(Random.value * 20);
				
			
			
		
				var neighCountGreen : int = 0;
				var neighCountBlue : int = 0;
				
				if(grid[x-1,z-1].GetComponent(caCube).type == 1) neighCountGreen++;
				if(grid[x-1,z].GetComponent(caCube).type == 1) neighCountGreen++;
				if(grid[x-1,z+1].GetComponent(caCube).type == 1) neighCountGreen++;
				
				if(grid[x,z-1].GetComponent(caCube).type == 1) neighCountGreen++;
				if(grid[x,z+1].GetComponent(caCube).type == 1) neighCountGreen++;
				
				if(grid[x+1,z-1].GetComponent(caCube).type == 1) neighCountGreen++;
				if(grid[x+1,z].GetComponent(caCube).type == 1) neighCountGreen++;
				if(grid[x+1,z+1].GetComponent(caCube).type == 1) neighCountGreen++;
				
				if(grid[x-1,z-1].GetComponent(caCube).type == 2) neighCountBlue++;
				if(grid[x-1,z].GetComponent(caCube).type == 2) neighCountBlue++;
				if(grid[x-1,z+1].GetComponent(caCube).type == 2) neighCountBlue++;
				
				if(grid[x,z-1].GetComponent(caCube).type == 2) neighCountBlue++;
				if(grid[x,z+1].GetComponent(caCube).type == 2) neighCountBlue++;
				
				if(grid[x+1,z-1].GetComponent(caCube).type == 2) neighCountBlue++;
				if(grid[x+1,z].GetComponent(caCube).type == 2) neighCountBlue++;
				if(grid[x+1,z+1].GetComponent(caCube).type == 2) neighCountBlue++;
			
				//rule 1: for cells that are null
				if(grid[x,z].GetComponent(caCube).type == 0){
						
					if(rEnd < 3){
						if(neighCountBlue > 0){ grid[x,z].GetComponent(caCube).futType = 2;
						typeNULLcounter ++;
						}
					}
					if(rEnd < 3){
						if(neighCountGreen > 0){ grid[x,z].GetComponent(caCube).futType = 1;
						typeNULLcounter ++;
						}
					}

				}
			
				//rule 2: for cells that are green
				if(grid[x,z].GetComponent(caCube).type == 1){
					if(neighCountBlue > 5) grid[x,z].GetComponent(caCube).futType = 2;
					
				}	
				
				//rule 3: for cells that are blue
				if(grid[x,z].GetComponent(caCube).type == 2){
					if(neighCountGreen > 5) grid[x,z].GetComponent(caCube).futType = 1;
				}
			}				
		}
	}
}






function createGrid(){

	grid = new GameObject[cols,rows];



	for (var x : int =0; x< cols; x++){
		for (var z : int =0; z< rows; z++){

		
			
			var pos : Vector3 = Vector3(x*spacing + OverWorldPositionX, 0, z*spacing + OverWorldPositionZ);
			var rot : Quaternion =  Quaternion.Euler(90, 0, 0);
			var newObj : GameObject = Instantiate(obj, pos ,rot);
			
			newObj.transform.parent = gameObject.transform;
			
			Random.seed = ((x * 10) + z);
			rEnd = (Mathf.Round(Random.value * 22))-20;
			//print(rEnd);
			//newObj.GetComponent(caCube).futType = rEnd;
			//newObj.renderer.enabled = false;
			
			
			grid[x,z] = newObj;
			
			
			
			
			
		}
	}
}















