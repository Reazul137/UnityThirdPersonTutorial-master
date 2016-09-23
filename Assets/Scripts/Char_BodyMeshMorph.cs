using UnityEngine;
using System.Collections;

public class Char_BodyMeshMorph : MonoBehaviour {


	public bool isRandom;

	public bool isMonster;
	public bool isColorRandom;

	public bool useBones;



	public int seed= 0;

	private  SkinnedMeshRenderer skinMeshRenderer;

	public float uvXpos= 0.5F;
	public float uvYpos= 0.5F;


	public float rMeshBlend00 = 1.0F;
	public float rMeshBlend01 = 1.0F;
	public float rMeshBlend02 = 1.0F;
	public float rMeshBlend03 = 1.0F;
	public float rMeshBlend04 = 1.0F;
	public float rMeshBlend05 = 1.0F;
	public float rMeshBlend06 = 1.0F;
	public float rMeshBlend07 = 1.0F;
	public float rMeshBlend08 = 1.0F;
	public float rMeshBlend09 = 1.0F;
	public float rMeshBlend10 = 1.0F;
	public float rMeshBlend11 = 1.0F;
	public float rMeshBlend12 = 1.0F;
	public float rMeshBlend13 = 1.0F;
	public float rMeshBlend14 = 1.0F;
	public float rMeshBlend15 = 1.0F;
	public float rMeshBlend16 = 1.0F;
	public float rMeshBlend17 = 1.0F;
	public float rMeshBlend18 = 1.0F;
	public float rMeshBlend19 = 1.0F;
	public float rMeshBlend20 = 1.0F;
	public float rMeshBlend21 = 1.0F;
	public float rMeshBlend22 = 1.0F;
	public float rMeshBlend23 = 1.0F;
	public float rMeshBlend24 = 1.0F;
	public float rMeshBlend25 = 1.0F;
	public float rMeshBlend26 = 1.0F;
	public float rMeshBlend27 = 1.0F;
	public float rMeshBlend28 = 1.0F;
	public float rMeshBlend29 = 1.0F;
	public float rMeshBlend30 = 1.0F;
	public float rMeshBlend31 = 1.0F; 
	public float rMeshBlend32 = 1.0F; 
	public float rMeshBlend33 = 1.0F; 
	public float rMeshBlend34 = 1.0F; 
	public float rMeshBlend35 = 1.0F; 
	public float rMeshBlend36 = 1.0F; 
	public float rMeshBlend37 = 1.0F; 
	public float rMeshBlend38 = 1.0F;
	public float rMeshBlend39 = 1.0F;
	public float rMeshBlend40 = 1.0F;




	public float skinMeshRendererArraySise ;

	// Use this for initialization
	void Start () {
		
		GameObject myObject = transform.gameObject;
		skinMeshRenderer = myObject.GetComponent<SkinnedMeshRenderer>();

		if( myObject.GetComponent<SkinnedMeshRenderer> () != null)skinMeshRendererArraySise = myObject.GetComponent<SkinnedMeshRenderer> ().sharedMesh.blendShapeCount;



		if (isRandom) {
			ActivadeRandom (this.GetInstanceID());
                                                            
		}   


		   


		ActivadeSkinMesh ();




		if(!useBones){
			Mesh mesh = new Mesh();
			skinMeshRenderer.BakeMesh (mesh);
			//mesh.RecalculateNormals ();
			skinMeshRenderer.sharedMesh = mesh;
		}
		skinMeshRenderer.sharedMesh.RecalculateNormals(); 
	                                                                      
	}                                                                     

	// Update is called once per frame
	void Update () {
		
	}

	public void ActivadeRandom (int mesterID) {

		Random.seed = mesterID ;

		if (isColorRandom) {
			uvXpos = Random.Range(0.01F, 1.0F);
			uvYpos = Random.Range(0.01F, 1.0F);
			GetComponent<Renderer>().material.SetTextureOffset("_MainTex", new Vector2(uvXpos, uvYpos));

		}

		Random.seed = mesterID ;
		rMeshBlend00 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend01 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend02 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend03 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend04 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend05 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend06 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend07 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend08 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend09 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend10 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend11 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend12 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend13 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend14 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend15 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend16 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend17 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend18 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend19 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend20 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend21 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		rMeshBlend22 = Random.Range(0,10) *  Random.Range(0,2f)*  Random.Range(0,2f); 
		if (isMonster) {
			rMeshBlend23 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend24 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend25 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend26 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend27 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend28 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend29 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend30 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend31 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend32 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend33 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend34 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend35 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend36 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend37 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend38 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend39 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
			rMeshBlend40 = Random.Range (0, 10) * Random.Range (0, 2f)*  Random.Range(0,2f);
		} 
	}

	void ActivadeSkinMesh () {


		if(skinMeshRendererArraySise >= 1) skinMeshRenderer.SetBlendShapeWeight (0, rMeshBlend00 * rMeshBlend00); 
		if(skinMeshRendererArraySise >= 2) skinMeshRenderer.SetBlendShapeWeight (1, rMeshBlend01 * rMeshBlend01); 
		if(skinMeshRendererArraySise >= 3) skinMeshRenderer.SetBlendShapeWeight (2, rMeshBlend02 * rMeshBlend02); 
		if(skinMeshRendererArraySise >= 4) skinMeshRenderer.SetBlendShapeWeight (3, rMeshBlend03 * rMeshBlend03); 
		if(skinMeshRendererArraySise >= 5) skinMeshRenderer.SetBlendShapeWeight (4, rMeshBlend04 * rMeshBlend04); 
		if(skinMeshRendererArraySise >= 6) skinMeshRenderer.SetBlendShapeWeight (5, rMeshBlend05 * rMeshBlend05); 		
		if(skinMeshRendererArraySise >= 7) skinMeshRenderer.SetBlendShapeWeight (6, rMeshBlend06 * rMeshBlend06); 
		if(skinMeshRendererArraySise >= 8) skinMeshRenderer.SetBlendShapeWeight (7, rMeshBlend07 * rMeshBlend07); 
		if(skinMeshRendererArraySise >= 9) skinMeshRenderer.SetBlendShapeWeight (8, rMeshBlend08 * rMeshBlend08);
		if(skinMeshRendererArraySise >= 10) skinMeshRenderer.SetBlendShapeWeight (9, rMeshBlend09 * rMeshBlend09); 
		if(skinMeshRendererArraySise >= 11) skinMeshRenderer.SetBlendShapeWeight (10, rMeshBlend10 * rMeshBlend10); 
		if(skinMeshRendererArraySise >= 12) skinMeshRenderer.SetBlendShapeWeight (11, rMeshBlend11 * rMeshBlend11); 
		if(skinMeshRendererArraySise >= 13) skinMeshRenderer.SetBlendShapeWeight (12, rMeshBlend12 * rMeshBlend12); 
		if(skinMeshRendererArraySise >= 14) skinMeshRenderer.SetBlendShapeWeight (13, rMeshBlend13 * rMeshBlend13); 
		if(skinMeshRendererArraySise >= 15) skinMeshRenderer.SetBlendShapeWeight (14, rMeshBlend14 * rMeshBlend14); 
		if(skinMeshRendererArraySise >= 16) skinMeshRenderer.SetBlendShapeWeight (15, rMeshBlend15 * rMeshBlend15); 
		if(skinMeshRendererArraySise >= 17) skinMeshRenderer.SetBlendShapeWeight (16, rMeshBlend16 * rMeshBlend16); 
		if(skinMeshRendererArraySise >= 18) skinMeshRenderer.SetBlendShapeWeight (17, rMeshBlend17 * rMeshBlend17); 
		if(skinMeshRendererArraySise >= 19) skinMeshRenderer.SetBlendShapeWeight (18, rMeshBlend18 * rMeshBlend18); 
		if(skinMeshRendererArraySise >= 20) skinMeshRenderer.SetBlendShapeWeight (19, rMeshBlend19 * rMeshBlend19); 
		if(skinMeshRendererArraySise >= 21) skinMeshRenderer.SetBlendShapeWeight (20, rMeshBlend20 * rMeshBlend20); 
		if(skinMeshRendererArraySise >= 22) skinMeshRenderer.SetBlendShapeWeight (21, rMeshBlend21 * rMeshBlend21);

		if(skinMeshRendererArraySise >= 23) skinMeshRenderer.SetBlendShapeWeight (22, rMeshBlend22 * rMeshBlend22);
		if(skinMeshRendererArraySise >= 24) skinMeshRenderer.SetBlendShapeWeight (23, rMeshBlend23 * rMeshBlend23); 
		if(skinMeshRendererArraySise >= 25) skinMeshRenderer.SetBlendShapeWeight (24, rMeshBlend24 * rMeshBlend24); 
		if(skinMeshRendererArraySise >= 26) skinMeshRenderer.SetBlendShapeWeight (25, rMeshBlend25 * rMeshBlend25); 
		if(skinMeshRendererArraySise >= 27) skinMeshRenderer.SetBlendShapeWeight (26, rMeshBlend26 * rMeshBlend26); 
		if(skinMeshRendererArraySise >= 28) skinMeshRenderer.SetBlendShapeWeight (27, rMeshBlend27 * rMeshBlend27); 
		if(skinMeshRendererArraySise >= 29) skinMeshRenderer.SetBlendShapeWeight (28, rMeshBlend28 * rMeshBlend28); 
		if(skinMeshRendererArraySise >= 30) skinMeshRenderer.SetBlendShapeWeight (29, rMeshBlend29 * rMeshBlend29); 
		if(skinMeshRendererArraySise >= 31) skinMeshRenderer.SetBlendShapeWeight (30, rMeshBlend30 * rMeshBlend30); 
		if(skinMeshRendererArraySise >= 32) skinMeshRenderer.SetBlendShapeWeight (31, rMeshBlend31 * rMeshBlend31);
		if(skinMeshRendererArraySise >= 33) skinMeshRenderer.SetBlendShapeWeight (32, rMeshBlend32 * rMeshBlend32); 
		if(skinMeshRendererArraySise >= 34) skinMeshRenderer.SetBlendShapeWeight (33, rMeshBlend33 * rMeshBlend33); 
		if(skinMeshRendererArraySise >= 35) skinMeshRenderer.SetBlendShapeWeight (34, rMeshBlend34 * rMeshBlend34); 
		if(skinMeshRendererArraySise >= 36) skinMeshRenderer.SetBlendShapeWeight (35, rMeshBlend35 * rMeshBlend35); 
		if(skinMeshRendererArraySise >= 37) skinMeshRenderer.SetBlendShapeWeight (36, rMeshBlend36 * rMeshBlend36); 
		if(skinMeshRendererArraySise >= 38) skinMeshRenderer.SetBlendShapeWeight (37, rMeshBlend37 * rMeshBlend37); 
		if(skinMeshRendererArraySise >= 39) skinMeshRenderer.SetBlendShapeWeight (38, rMeshBlend38 * rMeshBlend38); 
		if(skinMeshRendererArraySise >= 40) skinMeshRenderer.SetBlendShapeWeight (39, rMeshBlend39 * rMeshBlend39); 
		if(skinMeshRendererArraySise >= 41) skinMeshRenderer.SetBlendShapeWeight (40, rMeshBlend40 * rMeshBlend40); 

	
	}
}

