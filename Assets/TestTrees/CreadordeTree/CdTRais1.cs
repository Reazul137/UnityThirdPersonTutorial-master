using UnityEngine;
using System.Collections;

public class CdTRais1 : MonoBehaviour {

	public bool Mestre;
	
	public GameObject objCreadordeTrees1	 ;

	public float rMeshBlend01 = 0.0F;
	public float rMeshBlend02 = 0.0F;
	public float rMeshBlend03 = 0.0F;
	public float rMeshBlend04 = 0.0F;
	public float rMeshBlend05 = 0.0F;
	public float rMeshBlend06 = 0.0F;
	public float ruvXpos = 200.0F;
	public float ruvYpos = 200.0F;
	
	public float DivercidadeClone = 0.5F;
	public float DivercidadeCloneUpdate = 0.5F;
	

	public GameObject tronco ;

	public Vector2 ruvXYpos;




	private  SkinnedMeshRenderer skinMeshRenderer;
	
	void Start () {

		
		DivercidadeClone = Random.Range (0.0F, 1.0F);
		
		GameObject myObject = transform.gameObject;
		skinMeshRenderer = myObject.GetComponent<SkinnedMeshRenderer>();
		
	}
	void OnGUI() {
		/*
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
		*/


	}

	public void rRandom (){

		/*
		rMeshBlend01 = Random.Range(0.0F, 10.0F); 
		rMeshBlend02 = Random.Range(0.0F, 10.0F); 
		rMeshBlend03 = Random.Range(0.0F, 10.0F); 
		rMeshBlend04 = Random.Range(0.0F, 10.0F);
		rMeshBlend05 = Random.Range(0.0F, 10.0F);
		rMeshBlend06 = Random.Range(0.0F, 10.0F);
		//MeshBlend07 = Random.Range(0.0F, 10.0F);
		//MeshBlend08 = Random.Range(0.0F, 10.0F);
		//MeshBlend09 = Random.Range(0.0F, 10.0F);
		//MeshBlend10 = Random.Range(0.0F, 10.0F);
		//MeshBlend11 = Random.Range(0.0F, 10.0F);
		//MeshBlend12 = Random.Range(0.0F, 10.0F);
		*/
		}
	
	
	void Update () {
				
		rMeshBlend01 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().rMeshBlend01);
		rMeshBlend02 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().rMeshBlend02);
		rMeshBlend03 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().rMeshBlend03);
		rMeshBlend04 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().rMeshBlend04);
		rMeshBlend05 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().rMeshBlend05);
		rMeshBlend06 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().rMeshBlend06);

		ruvXpos = Mathf.Min(1.0f,(objCreadordeTrees1.GetComponent<CreadordeTrees1> ().tuvXpos));
		ruvYpos = Mathf.Min(1.0f,(objCreadordeTrees1.GetComponent<CreadordeTrees1> ().tuvYpos));
		

		
		skinMeshRenderer.SetBlendShapeWeight (0, rMeshBlend01 * rMeshBlend01); 
		skinMeshRenderer.SetBlendShapeWeight (1, rMeshBlend02 * rMeshBlend02); 
		skinMeshRenderer.SetBlendShapeWeight (2, rMeshBlend03 * rMeshBlend03); 
		skinMeshRenderer.SetBlendShapeWeight (3, rMeshBlend04 * rMeshBlend04); 
		skinMeshRenderer.SetBlendShapeWeight (4, rMeshBlend05 * rMeshBlend05); 
		skinMeshRenderer.SetBlendShapeWeight (5, rMeshBlend06 * rMeshBlend06); 
		

		GetComponent<Renderer>().material.SetTextureOffset ("_BodyColor", new Vector2 (ruvXpos, ruvYpos));

		this.transform.localScale = new Vector3 (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalScaleX , objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalScaleY , objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalScaleZ );

		
	}
}
