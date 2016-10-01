using UnityEngine;
using System.Collections;

public class CdTTronco1 : MonoBehaviour {

	public bool Mestre;

	public GameObject objCreadordeTrees1	 ;
	public float tMeshBlend01 = 0.0F;
	public float tMeshBlend02 = 0.0F;
	public float tMeshBlend03 = 0.0F;
	public float tMeshBlend04 = 0.0F;
	public float tMeshBlend05 = 0.0F;
	public float tMeshBlend06 = 0.0F;
	public float tuvXpos = 200.0F;
	public float tuvYpos = 200.0F;

	public float DivercidadeClone = 0.5F;
	public float DivercidadeCloneUpdate = 0.5F;

	///public Transform IdleTransform;

	private  SkinnedMeshRenderer skinMeshRenderer;
	
	void Start () {

		DivercidadeClone = Random.Range (0.0F, 1.0F);
		
		GameObject myObject = transform.gameObject;
		Vector3 IdlePos = this.transform.position;

		skinMeshRenderer = myObject.GetComponent<SkinnedMeshRenderer>();

				
	}




	public void tRandom (){

		/*
		tMeshBlend01 = Random.Range(0.0F, 10.0F); 
		tMeshBlend02 = Random.Range(0.0F, 10.0F); 
		tMeshBlend03 = Random.Range(0.0F, 10.0F); 
		tMeshBlend04 = Random.Range(0.0F, 10.0F);
		tMeshBlend05 = Random.Range(0.0F, 10.0F);
		tMeshBlend06 = Random.Range(0.0F, 10.0F);

		tuvXpos = Random.Range(0.01F, 1.0F);
		tuvYpos = Random.Range(0.01F, 1.0F);
		*/}
	
	
	void Update () {
				
		

		tMeshBlend01 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().tMeshBlend01);
		tMeshBlend02 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().tMeshBlend02);
		tMeshBlend03 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().tMeshBlend03);
		tMeshBlend04 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().tMeshBlend04);
		tMeshBlend05 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().tMeshBlend05);
		tMeshBlend06 = (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().tMeshBlend06);

		tuvXpos = Mathf.Min(1.0f,(objCreadordeTrees1.GetComponent<CreadordeTrees1> ().tuvXpos));
		tuvYpos = Mathf.Min(1.0f,(objCreadordeTrees1.GetComponent<CreadordeTrees1> ().tuvYpos));
		
		
		
		
		
		skinMeshRenderer.SetBlendShapeWeight (0, tMeshBlend01 * tMeshBlend01); 
		skinMeshRenderer.SetBlendShapeWeight (1, tMeshBlend02 * tMeshBlend02); 
		skinMeshRenderer.SetBlendShapeWeight (2, tMeshBlend03 * tMeshBlend03); 
		skinMeshRenderer.SetBlendShapeWeight (3, tMeshBlend04 * tMeshBlend04); 
		skinMeshRenderer.SetBlendShapeWeight (4, tMeshBlend05 * tMeshBlend05); 
		skinMeshRenderer.SetBlendShapeWeight (5, tMeshBlend06 * tMeshBlend06); 

		GetComponent<Renderer>().material.SetTextureOffset ("_BodyColor", new Vector2 (tuvXpos, tuvYpos));


		this.transform.localPosition= new Vector3 ( (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalPosX), (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalPosY), (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalPosZ)); 
		this.transform.localScale = new Vector3 (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalScaleX , objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalScaleY , objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalScaleZ );

		this.transform.localEulerAngles = new Vector3 (objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalRotX,objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalRotY,objCreadordeTrees1.GetComponent<CreadordeTrees1> ().LocalRotZ);


		
	}
}
