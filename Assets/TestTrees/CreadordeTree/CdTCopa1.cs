using UnityEngine;
using System.Collections;

public class CdTCopa1 : MonoBehaviour {

	public bool Mestre;

	public GameObject objCreadordeTrees1	 ;
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

	public float DivercidadeClone = 0.5F;
	public float DivercidadeCloneUpdate = 0.5F;

	private  SkinnedMeshRenderer skinMeshRenderer;




	
	void Start () {
		DivercidadeClone = Random.Range (0.0F, 1.0F);

		GameObject myObject = transform.gameObject;
		skinMeshRenderer = myObject.GetComponent<SkinnedMeshRenderer>();



	}

	/*
	public void cRandom (){
		
		
		cMeshBlend01 = Random.Range(0.0F, 10.0F); 
		cMeshBlend02 = Random.Range(0.0F, 10.0F); 
		cMeshBlend03 = Random.Range(0.0F, 10.0F); 
		cMeshBlend04 = Random.Range(0.0F, 10.0F);
		cMeshBlend05 = Random.Range(0.0F, 10.0F);
		cMeshBlend06 = Random.Range(0.0F, 10.0F);
		cMeshBlend07 = Random.Range(0.0F, 10.0F);
		cMeshBlend08 = Random.Range(0.0F, 10.0F);
		cMeshBlend09 = Random.Range(0.0F, 10.0F);
		cMeshBlend10 = Random.Range(0.0F, 10.0F);
		cMeshBlend11 = Random.Range(0.0F, 10.0F);
		cMeshBlend12 = Random.Range(0.0F, 10.0F);
		cuvXpos = Random.Range(0.01F, 1.0F);
		cuvYpos = Random.Range(0.01F, 1.0F);

	
	}*/

	void Update() {
		if (!Mestre) {
						DivercidadeCloneUpdate = DivercidadeClone * (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().Divercidade);
						//print (DivercidadeClone + " + " + (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().Divercidade) + " = " + DivercidadeCloneUpdate);
		} else {DivercidadeCloneUpdate=0;
				}

		cMeshBlend01 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend01);
		cMeshBlend02 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend02);
		cMeshBlend03 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend03);
		cMeshBlend04 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend04);
		cMeshBlend05 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend05);
		cMeshBlend06 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend06);
		cMeshBlend07 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend07);
		cMeshBlend08 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend08);
		cMeshBlend09 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend09);
		cMeshBlend10 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend10);
		cMeshBlend11 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend11);
		cMeshBlend12 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend12);
		cMeshBlend13 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cMeshBlend13);


		cuvXpos = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cuvXpos)+ (DivercidadeClone / 5);
		cuvYpos = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().cuvYpos) + (DivercidadeClone / 5);


				



				skinMeshRenderer.SetBlendShapeWeight (0, cMeshBlend01 * cMeshBlend01); 
				skinMeshRenderer.SetBlendShapeWeight (1, cMeshBlend02 * cMeshBlend02); 
				skinMeshRenderer.SetBlendShapeWeight (2, cMeshBlend03 * cMeshBlend03); 
				skinMeshRenderer.SetBlendShapeWeight (3, cMeshBlend04 * cMeshBlend04); 
				skinMeshRenderer.SetBlendShapeWeight (4, cMeshBlend05 * cMeshBlend05); 
				skinMeshRenderer.SetBlendShapeWeight (5, cMeshBlend06 * cMeshBlend06); 
				skinMeshRenderer.SetBlendShapeWeight (6, cMeshBlend07 * cMeshBlend07); 
				skinMeshRenderer.SetBlendShapeWeight (7, cMeshBlend08 * cMeshBlend08); 
				skinMeshRenderer.SetBlendShapeWeight (8, cMeshBlend09 * cMeshBlend09); 
				skinMeshRenderer.SetBlendShapeWeight (9, cMeshBlend10 * cMeshBlend10); 
				skinMeshRenderer.SetBlendShapeWeight (10, cMeshBlend11 * cMeshBlend11); 
				skinMeshRenderer.SetBlendShapeWeight (11, cMeshBlend12 * cMeshBlend12);
				//skinMeshRenderer.SetBlendShapeWeight (12, cMeshBlend13 * cMeshBlend13);

		GetComponent<Renderer>().material.SetTextureOffset ("_BodyColor", new Vector2 (cuvXpos, cuvYpos));
		//GetComponent<Renderer>().material.mainTextureOffset =  new Vector2 (cuvXpos, cuvYpos);

		//float shininess = Mathf.PingPong(Time.time, 1.0F);
		//rend.material.SetFloat("_Temp", shininess);
			

		this.transform.localScale = new Vector3 (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalScaleX , objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalScaleY , objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalScaleZ );


	}
}
