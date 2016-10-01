using UnityEngine;
using System.Collections;

public class CreadordeTrees1 : MonoBehaviour
{
		

	public float RandomButtonHigth = 0.0F;

	public bool WoldSizeIsRandom = false;
	public float WoldSizeAmountMin = 1.0F;
	public float WoldSizeAmountMax = 1.0F;
	public bool LocalScalesIsRandom = false;
	public bool LocalRotationIsRandom = false;





	public bool ShowThisGui = true;


	public float ProblabilityPower = 1.0F;
		public float WoldSize = 1.0F;
		public float HighSise = 1.0F;
		public float whideSise = 1.0F;
		public float MeshBlend01 = 50.0F;
		public float Divercidade = 0.0F;

		public GameObject RegiaoCoordenates ;
		public GameObject copa ;
		public GameObject tronco ;
		public GameObject rais ;




	//----copa
	public float cMeshBlend01 = 0.0F;
	public float cMeshBlend02 = 0.0F;
	public float cMeshBlend03 = 0.0F;
	public float cMeshBlend04 = 0.0F;
	public float cMeshBlend05 = 0.0F;
	public float cMeshBlend06 = 0.0F;
	public float cMeshBlend07 = 0.0F;
	public float cMeshBlend08 = 0.0F;
	public float cMeshBlend09 = 0.0F;
	public float cMeshBlend10 = 0.0F;
	public float cMeshBlend11 = 0.0F;
	public float cMeshBlend12 = 0.0F;
	public float cMeshBlend13 = 0.0F;
	public float cuvXpos = 200.0F;
	public float cuvYpos = 200.0F;




	//-----tronco

	public float tMeshBlend01 = 0.0F;
	public float tMeshBlend02 = 0.0F;
	public float tMeshBlend03 = 0.0F;
	public float tMeshBlend04 = 0.0F;
	public float tMeshBlend05 = 0.0F;
	public float tMeshBlend06 = 0.0F;
	public float tuvXpos = 200.0F;
	public float tuvYpos = 200.0F;



	public float tRotX = 0.0F;
	public float tRoty = 0.0F;
	public float tRotZ = 0.0F;

	public float LocalScaleAll = 0.0F;
	public float LocalScaleX = 0.0F;
	public float LocalScaleY = 0.0F;
	public float LocalScaleZ = 0.0F;

	public float LocalRotX = 0.0F;
	public float LocalRotY = 0.0F;
	public float LocalRotZ = 0.0F;

	public float LocalPosX = 0.0F;
	public float LocalPosY = 0.0F;
	public float LocalPosZ = 0.0F;


	//----rais
	public float rMeshBlend01 = 0.0F;
	public float rMeshBlend02 = 0.0F;
	public float rMeshBlend03 = 0.0F;
	public float rMeshBlend04 = 0.0F;
	public float rMeshBlend05 = 0.0F;
	public float rMeshBlend06 = 0.0F;
	




	public bool AllRandomIsOn =false;

		//private  SkinnedMeshRenderer skinMeshRenderer;

		void Start ()
		{
		Random.seed = Mathf.FloorToInt ((RegiaoCoordenates.transform.position.x * 100000) + (RegiaoCoordenates.transform.position.y * 100) + RandomButtonHigth);


		//GameObject myObject = transform.gameObject;
		//skinMeshRenderer = myObject.GetComponent<SkinnedMeshRenderer>();
		AllRandom ();
	}

		void OnGUI ()
		{



		if (GUI.Button (new Rect (Screen.width - 71, 30*RandomButtonHigth, 60, 30), "Random")) {
			AllRandom ();
			AllRandomIsOn = true;
		} else {
			AllRandomIsOn =false;
		}

		if (GUI.Button (new Rect (Screen.width - 10, 30*RandomButtonHigth, 10, 30), "Button")) {
			ShowThisGui = !ShowThisGui;
		} 
		if(ShowThisGui){


					WoldSize = GUI.HorizontalSlider (new Rect (250, 20, 100, 20), WoldSize, 1.0F, 1.0F);
					HighSise = GUI.HorizontalSlider (new Rect (250, 40, 100, 20), HighSise, 0.5F, 1.5F);
					whideSise = GUI.HorizontalSlider (new Rect (250, 60, 100, 20), whideSise, 0.5F, 1.5F);
					Divercidade = GUI.HorizontalSlider (new Rect (250, 80, 100, 20), Divercidade, 0.0F, 1.0F);

					


			//---copa
			cMeshBlend01 = GUI.HorizontalSlider(new Rect(20,60, 100, 20), cMeshBlend01, 0.0f, 10.0F);
			cMeshBlend02 = GUI.HorizontalSlider(new Rect(20,80, 100, 20), cMeshBlend02, 0.0F, 10.0F);
			cMeshBlend03 = GUI.HorizontalSlider(new Rect(20,100, 100, 20), cMeshBlend03, 0.0F, 10.0F);
			cMeshBlend04 = GUI.HorizontalSlider(new Rect(20,120, 100, 20), cMeshBlend04, 0.0F, 10.0F);
			cMeshBlend05 = GUI.HorizontalSlider(new Rect(20,140, 100, 20), cMeshBlend05, 0.0F, 10.0F);
			cMeshBlend06 = GUI.HorizontalSlider(new Rect(20,160, 100, 20), cMeshBlend06, 0.0F, 10.0F);
			cMeshBlend07 = GUI.HorizontalSlider(new Rect(20,180, 100, 20), cMeshBlend07, 0.0F, 10.0F);
			cMeshBlend08 = GUI.HorizontalSlider(new Rect(20,200, 100, 20), cMeshBlend08, 0.0F, 10.0F);
			cMeshBlend09 = GUI.HorizontalSlider(new Rect(20,220, 100, 20), cMeshBlend09, 0.0F, 10.0F);
			cMeshBlend10 = GUI.HorizontalSlider(new Rect(20,240, 100, 20), cMeshBlend10, 0.0F, 10.0F);
			cMeshBlend11 = GUI.HorizontalSlider(new Rect(20,260, 100, 20), cMeshBlend11, 0.0F, 10.0F);
			cMeshBlend12 = GUI.HorizontalSlider(new Rect(20,280, 100, 20), cMeshBlend12, 0.0F, 10.0F);
			cMeshBlend13 = GUI.HorizontalSlider(new Rect(20,300, 100, 20), cMeshBlend13, 0.0F, 10.0F);
			cuvXpos = GUI.HorizontalSlider(new Rect(400,20, 50, 20), cuvXpos, 0.01F, 1.0F);
			cuvYpos = GUI.HorizontalSlider(new Rect(460,20, 50, 20), cuvYpos, 0.01F, 1.0F);


			//----tronco
			tMeshBlend01 = GUI.HorizontalSlider(new Rect(20,320, 100, 20), tMeshBlend01, 0.0F, 10.0F);
			tMeshBlend02 = GUI.HorizontalSlider(new Rect(20,340, 100, 20), tMeshBlend02, 0.0F, 10.0F);
			tMeshBlend03 = GUI.HorizontalSlider(new Rect(20,360, 100, 20), tMeshBlend03, 0.0F, 10.0F);
			tMeshBlend04 = GUI.HorizontalSlider(new Rect(20,380, 100, 20), tMeshBlend04, 0.0F, 10.0F);
			tMeshBlend05 = GUI.HorizontalSlider(new Rect(20,400, 100, 20), tMeshBlend05, 0.0F, 10.0F);
			tMeshBlend06 = GUI.HorizontalSlider(new Rect(20,420, 100, 20), tMeshBlend06, 0.0F, 10.0F);
			tuvXpos = GUI.HorizontalSlider(new Rect(400,40, 50, 20), tuvXpos, 0.01F, 1.0F);
			tuvYpos = GUI.HorizontalSlider(new Rect(460,40, 50, 20), tuvYpos, 0.01F, 1.0F);

			LocalRotX = GUI.HorizontalSlider(new Rect(20,560, 100, 10), LocalRotX, 0.0F, 10.0F);
			LocalRotY =	GUI.HorizontalSlider(new Rect(20,570, 100, 10), LocalRotY, 0.0F, 10.0F);
			LocalRotZ =	GUI.HorizontalSlider(new Rect(20,580, 100, 10), LocalRotZ, 0.0F, 10.0F);

			LocalScaleAll =	GUI.HorizontalSlider(new Rect(20,590, 100, 10), LocalScaleAll, 0.0F, 10.0F);
			LocalScaleX =	GUI.HorizontalSlider(new Rect(20,600, 100, 10), LocalScaleX, 0.0F, 10.0F);
			LocalScaleY =	GUI.HorizontalSlider(new Rect(20,610, 100, 10), LocalScaleY, 0.0F, 10.0F);
			LocalScaleZ =	GUI.HorizontalSlider(new Rect(20,620, 100, 10), LocalScaleZ, 0.0F, 10.0F);

		


				
			//----rais
			rMeshBlend01 = GUI.HorizontalSlider(new Rect(20,440, 100, 20), rMeshBlend01, 0.0F, 10.0F);
			rMeshBlend02 = GUI.HorizontalSlider(new Rect(20,460, 100, 20), rMeshBlend02, 0.0F, 10.0F);
			rMeshBlend03 = GUI.HorizontalSlider(new Rect(20,480, 100, 20), rMeshBlend03, 0.0F, 10.0F);
			rMeshBlend04 = GUI.HorizontalSlider(new Rect(20,500, 100, 20), rMeshBlend04, 0.0F, 10.0F);
			rMeshBlend05 = GUI.HorizontalSlider(new Rect(20,520, 100, 20), rMeshBlend05, 0.0F, 10.0F);
			rMeshBlend06 = GUI.HorizontalSlider(new Rect(20,540, 100, 20), rMeshBlend06, 0.0F, 10.0F);
			

			}
		}

		public void AllRandom ()
		{
	

		if(WoldSizeIsRandom){
			WoldSize =   Mathf.Pow(Random.Range (WoldSizeAmountMin, WoldSizeAmountMax),2); 

		}else{
			WoldSize =3f; 

		}

		if(LocalScalesIsRandom){

			LocalScaleX	= Random.Range (0.5F, 1.5F); 
			LocalScaleY= Random.Range (0.5F, 1.5F); 
			LocalScaleZ= Random.Range (0.5F, 1.5F); 

			LocalRotX	= Random.Range (-45,45) +270 ;  
			LocalRotY= Random.Range (-45,45); 
			LocalRotZ=  Random.Range (-45,45); 

			LocalPosX = Random.Range (-0.01F, 0.01F);  
			LocalPosY =  Random.Range (-0.2F, 0.1F); 
			LocalPosZ =  Random.Range (-0.01F, 0.01F);


		}else{
			LocalScaleAll = 1f;
			LocalScaleX	=1f; 
			LocalScaleY= 1f; 
			LocalScaleZ= 1f;
			LocalRotX	= 270 ;  
			LocalRotY= 0; 
			LocalRotZ=  0; 
		}

				HighSise = Random.Range (0.5F, 1.5F); 
				whideSise = Random.Range (0.5F, 1.5F); 
				Divercidade = Random.Range (0.0F, 1.0F); 
				//copa.GetComponent<CdTCopa1> ().cRandom ();
				//tronco.GetComponent<CdTTronco1> ().tRandom ();
				//rais.GetComponent<CdTRais1> ().rRandom ();

				//transform.localScale = new Vector3( whideSise * (WoldSize) , HighSise * (WoldSize),whideSise * (WoldSize));	


		//---copa
		cMeshBlend01 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend02 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend03 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend04 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend05 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend06 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend07 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend08 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend09 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend10 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend11 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend12 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cMeshBlend13 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		cuvXpos = Random.Range(0.01F, 0.9F) - 0.5F;
		cuvYpos = Random.Range(0.01F, 0.9F)- 0.5F;

		//--------tronco

		tMeshBlend01 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		tMeshBlend02 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		tMeshBlend03 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		tMeshBlend04 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		tMeshBlend05 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		tMeshBlend06 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		
		tuvXpos = Random.Range(0.01F, 0.9F)- 0.5F;
		tuvYpos = Random.Range(0.01F, 0.9F)- 0.5F;

		//------------rais
		rMeshBlend01 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		rMeshBlend02 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		rMeshBlend03 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10;  
		rMeshBlend04 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		rMeshBlend05 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		rMeshBlend06 = Mathf.Pow(Random.Range(0.0F, 10.0F),ProblabilityPower)/10; 
		
		

				//print ( tronco.GetComponent<CdTTronco>().MeshBlend01 ); 


		}

		void Update ()
		{
	


	}

}
