#pragma strict



var OverWorldPositionX : int = 0;
var OverWorldPositionZ : int = 0;

var OverWorldHighRand : float = 1;

var obj : GameObject;

var RegCret_WallsNFoors : GameObject;


var grid : GameObject[,];

var cols : int = 50;
var rows : int = 50;

var simStepNum : int = 1;

var spacing : float = 10;

var coordinateSeed : float = 1;

var fronteiraRandVal : int = 1;
var rA : int = 1;
var rB : int = 2;
var rC : int = 3;
var rX : int = 4;
var rZ : int = 1;
var rEnd : int = 5;

var InstRegCret_WallsNFoors = false;

//private var simOn = false;
private var simOn = true;
var typeNULLcounter : int = 0;

var MinSimTimer : int = 0;





function Start () {

	Random.seed = OverWorldPositionX-10*OverWorldPositionZ*3;
	OverWorldHighRand=((Random.Range (1f, 10f)*Random.Range (1f, 10f))/10f)+0.1f;


//	print(OverWorldHighRand);
	//OverWorldPositionX = this.transform.position.x ;
	//OverWorldPositionZ = this.transform.position.z ;
	createGrid();
	/*
	 for (var child : Transform in transform) {
	 	if(child.GetComponent.<Collider>() != null){
	 		child.GetComponent.<Collider>().enabled = true;
	 	}
	 }
	 */


}



function Awake() { }





function OnMouseDown (){typeNULLcounter = cols*rows+1; MinSimTimer = 60;}
function Update () {

	//Debug.Log(typeNULLcounter);
	
		         
	
	simStep ();


//	print(MinSimTimer+")("+typeNULLcounter);	

	//if(typeNULLcounter >= cols*rows-1 && MinSimTimer>=40){
	if( MinSimTimer>=50){

			print("STOP!!! End");	

			var RegCret_WallsNFoorsClone : GameObject  = Instantiate (RegCret_WallsNFoors, transform.position, transform.rotation);//------------------------------------<<<




				var NewFloor : MapGenerator =RegCret_WallsNFoorsClone.transform.GetChild(1).GetComponent("MapGenerator") as MapGenerator;
				var NewWall : MapGenerator =RegCret_WallsNFoorsClone.transform.GetChild(2).GetComponent("MapGenerator") as MapGenerator;



				NewWall.OverWorldPositionX =OverWorldPositionX+0.1f;
				NewWall.OverWorldPositionZ =OverWorldPositionZ+0.1f;
				NewFloor.OverWorldPositionX =OverWorldPositionX;
				NewFloor.OverWorldPositionZ =OverWorldPositionZ;



				Random.seed = (OverWorldPositionX*10 + OverWorldPositionZ);

				NewFloor.randomFillPercent =  45 +(Mathf.Round(Random.value * 25));



				NewWall.randomFillPercent = 30 + (Mathf.Round(Random.value * 25));

				for (var child : Transform in transform) {
	 				if(child.GetComponent.<Collider>() != null){
	 					child.GetComponent.<Collider>().enabled = true;
	 					}
				}

			//RegCret_WallsNFoorsClone.transform.GetChild(2).gameObject.GetComponent.<MapGenerator>().OverWorldPositionZ = OverWorldPositionZ;
		

			Destroy(this.gameObject);

		
		 var childs : int = transform.childCount;

		
 
		 for (var i = childs - 1; i >= 0; i--)
		 {
		     transform.GetChild(i).gameObject.GetComponent.<Renderer>().enabled=true;


		     
		    Destroy (transform.GetChild(i).GetComponent(caCube));
		  //  Destroy (transform.GetChild(i).gameObject.GetComponent.<Collider>());
		    Destroy (transform.GetChild(i).gameObject.GetComponent.<Rigidbody>());

	
		 }


		 Destroy (this);
	}


	
}


function simStep () {

	if(MinSimTimer<=50){MinSimTimer ++;}


	for (var x : int =0; x< cols; x++){
		for (var z : int =0; z< rows; z++){
		
			
		var  FronteiraWestTipe  : float =  Mathf.PerlinNoise(( OverWorldPositionX-0.5f +10)/3,( OverWorldPositionZ     +10)/3)  *20*  Mathf.PerlinNoise(( OverWorldPositionX-0.5f +100)*3,( OverWorldPositionZ     +100)*3);																										      	 														   							   
		var  FronteiraEastTipe  : float =  Mathf.PerlinNoise(( OverWorldPositionX+0.5f +10)/3,( OverWorldPositionZ     +10)/3)  *20*  Mathf.PerlinNoise(( OverWorldPositionX+0.5f +100)*3,( OverWorldPositionZ     +100)*3);																										      	 														   							   
		var  FronteiraNorthTipe : float =  Mathf.PerlinNoise(( OverWorldPositionX      +10)/3,( OverWorldPositionZ+0.5f+10)/3)  *20*  Mathf.PerlinNoise(( OverWorldPositionX      +100)*3,( OverWorldPositionZ+0.5f+100)*3);																									      	 														   							   
		var  FronteiraSouthTipe : float =  Mathf.PerlinNoise(( OverWorldPositionX      +10)/3,( OverWorldPositionZ-0.5f+10)/3)  *20*  Mathf.PerlinNoise(( OverWorldPositionX      +100)*3,( OverWorldPositionZ-0.5f+100)*3);
                                  
			if(x==0){
				
				
				if(FronteiraWestTipe  <=4){	
					grid[x,z].GetComponent(caCube).futType=1;
				}else{grid[x,z].GetComponent(caCube).futType=2;}
			}
			if(x==cols-1){
				
				
				if(FronteiraEastTipe  <=4){
					grid[x,z].GetComponent(caCube).futType=1;
				}else{grid[x,z].GetComponent(caCube).futType=2;}
			}
			if(z==0 ){
				
				
				if(FronteiraSouthTipe  <=4){
					grid[x,z].GetComponent(caCube).futType=1;
				}else{grid[x,z].GetComponent(caCube).futType=2;}
			}
			if(z==rows-1){
				
								
				if(FronteiraNorthTipe  <=4){
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
						
					if(rEnd < 12){
						if(neighCountBlue > 0){ grid[x,z].GetComponent(caCube).futType = 2;

					
						typeNULLcounter ++;
						}
					}
					if(rEnd < 12){
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


			//grid[x,z].GetComponent(caCube).caCubeColorir();				
		}
	}





}






function createGrid(){

	grid = new GameObject[cols,rows];



	for (var x : int =0; x< cols; x++){
		for (var z : int =0; z< rows; z++){

		
			
			var pos : Vector3 = Vector3(x*spacing + this.transform.position.x-(cols*2), this.transform.position.y, z*spacing + this.transform.position.z-(rows*2));
			var rot : Quaternion =  Quaternion.Euler(90, 0, 0);
			var newObj : GameObject = Instantiate(obj, pos ,rot);
			
			newObj.transform.parent = gameObject.transform;
			newObj.GetComponent.<Collider>().enabled = false;

			newObj.GetComponent(caCube).OverWorldHighRand =OverWorldHighRand;

			newObj.GetComponent(caCube).OverWorldPositionX=OverWorldPositionX;
			newObj.GetComponent(caCube).OverWorldPositionZ=OverWorldPositionX;
			
			Random.seed = ((x * 10) + z);
			rEnd = (Mathf.Round(Random.value * 22))-20;
			//print(rEnd);
			//newObj.GetComponent(caCube).futType = rEnd;
			//newObj.renderer.enabled = false;
			
			
			grid[x,z] = newObj;
			
			
			
			
			
		}
	}
}















