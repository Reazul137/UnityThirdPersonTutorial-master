﻿using UnityEngine;
using System.Collections;

public class CdTRais : MonoBehaviour {


	public float MeshBlend01 = 0.0F;
	public float MeshBlend02 = 0.0F;
	public float MeshBlend03 = 0.0F;
	public float MeshBlend04 = 0.0F;
	public float MeshBlend05 = 0.0F;
	public float MeshBlend06 = 0.0F;
	//public float MeshBlend07 = 50.0F;
	//public float MeshBlend08 = 50.0F;
	//public float MeshBlend09 = 50.0F;
	//public float MeshBlend10 = 50.0F;
	//public float MeshBlend11 = 50.0F;
	//public float MeshBlend12 = 50.0F;

	public GameObject tronco ;

	public Vector2 uvXYpos;




	private  SkinnedMeshRenderer skinMeshRenderer;
	
	void Start () {
		
		GameObject myObject = transform.gameObject;
		skinMeshRenderer = myObject.GetComponent<SkinnedMeshRenderer>();
		
	}
	void OnGUI() {
		MeshBlend01 = GUI.HorizontalSlider(new Rect(20,440, 100, 20), MeshBlend01, 0.0F, 10.0F);
		MeshBlend02 = GUI.HorizontalSlider(new Rect(20,460, 100, 20), MeshBlend02, 0.0F, 10.0F);
		MeshBlend03 = GUI.HorizontalSlider(new Rect(20,480, 100, 20), MeshBlend03, 0.0F, 10.0F);
		MeshBlend04 = GUI.HorizontalSlider(new Rect(20,500, 100, 20), MeshBlend04, 0.0F, 10.0F);
		MeshBlend05 = GUI.HorizontalSlider(new Rect(20,520, 100, 20), MeshBlend05, 0.0F, 10.0F);
		MeshBlend06 = GUI.HorizontalSlider(new Rect(20,540, 100, 20), MeshBlend06, 0.0F, 10.0F);
		//MeshBlend07 = GUI.HorizontalSlider(new Rect(20,140, 100, 20), MeshBlend07, 0.0F, 100.0F);
		//MeshBlend08 = GUI.HorizontalSlider(new Rect(20,160, 100, 20), MeshBlend08, 0.0F, 100.0F);
		//MeshBlend09 = GUI.HorizontalSlider(new Rect(20,180, 100, 20), MeshBlend09, 0.0F, 100.0F);
		//MeshBlend10 = GUI.HorizontalSlider(new Rect(20,200, 100, 20), MeshBlend10, 0.0F, 100.0F);
		//MeshBlend11 = GUI.HorizontalSlider(new Rect(20,220, 100, 20), MeshBlend11, 0.0F, 100.0F);
		//MeshBlend12 = GUI.HorizontalSlider(new Rect(20,240, 100, 20), MeshBlend12, 0.0F, 100.0F);



	}

	public void rRandom (){

		
		MeshBlend01 = Random.Range(0.0F, 10.0F); 
		MeshBlend02 = Random.Range(0.0F, 10.0F); 
		MeshBlend03 = Random.Range(0.0F, 10.0F); 
		MeshBlend04 = Random.Range(0.0F, 10.0F);
		MeshBlend05 = Random.Range(0.0F, 10.0F);
		MeshBlend06 = Random.Range(0.0F, 10.0F);
		//MeshBlend07 = Random.Range(0.0F, 10.0F);
		//MeshBlend08 = Random.Range(0.0F, 10.0F);
		//MeshBlend09 = Random.Range(0.0F, 10.0F);
		//MeshBlend10 = Random.Range(0.0F, 10.0F);
		//MeshBlend11 = Random.Range(0.0F, 10.0F);
		//MeshBlend12 = Random.Range(0.0F, 10.0F);
		}
	
	
	void Update () {
				
		skinMeshRenderer.SetBlendShapeWeight(0, MeshBlend01*MeshBlend01); 
		skinMeshRenderer.SetBlendShapeWeight(1, MeshBlend02*MeshBlend02); 
		skinMeshRenderer.SetBlendShapeWeight(2, MeshBlend03*MeshBlend03); 
		skinMeshRenderer.SetBlendShapeWeight(3, MeshBlend04*MeshBlend04); 
		skinMeshRenderer.SetBlendShapeWeight(4, MeshBlend05*MeshBlend05); 
		skinMeshRenderer.SetBlendShapeWeight(5, MeshBlend06*MeshBlend06); 
		//skinMeshRenderer.SetBlendShapeWeight(6, MeshBlend07*MeshBlend07); 
		//skinMeshRenderer.SetBlendShapeWeight(7, MeshBlend08*MeshBlend08); 
		//skinMeshRenderer.SetBlendShapeWeight(8, MeshBlend09*MeshBlend09); 
		//skinMeshRenderer.SetBlendShapeWeight(9, MeshBlend10*MeshBlend10); 
		//skinMeshRenderer.SetBlendShapeWeight(10, MeshBlend11*MeshBlend11); 
		//skinMeshRenderer.SetBlendShapeWeight(11, MeshBlend12*MeshBlend12);
		//uvXYpos = tronco.renderer.material.GetTextureOffset

		GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2((tronco.GetComponent<CdTTronco>().uvXpos),tronco.GetComponent<CdTTronco>().uvYpos));


		
	}
}