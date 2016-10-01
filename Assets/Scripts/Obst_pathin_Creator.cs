using UnityEngine;
using System.Collections;

public class Obst_pathin_Creator : MonoBehaviour {


	public float obstPlataformeX = 2f;
	public float obstPlataformeZ = 2f;

	public float PathLength = 2f;
	public float PathWidth = 2f;
	public float PathHeight = 2f;




	public GameObject  PlataforHelper_in;
	public GameObject  PlataforHelper_out;






	// Use this for initialization
	void Start () {
		// You can change that line to provide another MeshFilter

		GameObject DoorIn = this.transform.GetComponent<ObstCreator> ().DoorIn;
		GameObject DoorOut = this.transform.GetComponent<ObstCreator> ().DoorOut;




			CreatePath (DoorIn,PlataforHelper_in);
			CreatePath (DoorOut,PlataforHelper_out);



	
	}


	void CreatePath (GameObject DoorToUse, GameObject PlataforHelperToUse) {
		GameObject ObstObj = PlataforHelperToUse.transform.parent.GetChild(0).gameObject ;
	


	

		Vector3 targetDir = DoorToUse.transform.localPosition - transform.localPosition;


		if (Mathf.Abs( targetDir.x -PlataforHelperToUse.transform.parent.localPosition.x )<= Mathf.Abs(targetDir.z - PlataforHelperToUse.transform.parent.localPosition.z)) {
			//NS


			if ( targetDir.z <= PlataforHelperToUse.transform.parent.localPosition.z) {
				//Norte
				PlataforHelperToUse.transform.parent.GetChild(0).rotation = Quaternion.Euler(0,180,0);
			}else if ( targetDir.z > PlataforHelperToUse.transform.parent.localPosition.z) {
				//Sul
				PlataforHelperToUse.transform.parent.GetChild(0).rotation = Quaternion.Euler(0,0,0);
				
			}


		} else if ( Mathf.Abs(targetDir.x - PlataforHelperToUse.transform.parent.localPosition.x) >  Mathf.Abs(targetDir.z - PlataforHelperToUse.transform.parent.localPosition.z)) {
			//LO

			if ( targetDir.x <= PlataforHelperToUse.transform.parent.localPosition.x) {
				//oeste
				PlataforHelperToUse.transform.parent.GetChild(0).rotation = Quaternion.Euler(0,-90,0);
				
			}else if ( targetDir.x > PlataforHelperToUse.transform.parent.localPosition.x) {
				//Leste
				PlataforHelperToUse.transform.parent.GetChild(0).rotation = Quaternion.Euler(0,90,0);
				
			}

		}







	
		MeshFilter filter = PlataforHelperToUse.gameObject.AddComponent< MeshFilter >();
		Mesh mesh = filter.mesh;
		mesh.Clear();
		
		//float length = 2f;
		//float width = 1f;
		//float height = 1f;
		
		#region Vertices

		//Path
		Vector3 pT0 = DoorToUse.transform.GetChild(2).transform.position - PlataforHelperToUse.transform.position;
		Vector3 pT1 = DoorToUse.transform.GetChild(3).transform.position - PlataforHelperToUse.transform.position;
		Vector3 pT2 = new  Vector3(((DoorToUse.transform.GetChild(2).transform.position.x + PlataforHelperToUse.transform.parent.GetChild(0).GetChild(0).position.x)/2)- PlataforHelperToUse.transform.position.x,PlataforHelperToUse.transform.localPosition.y,((DoorToUse.transform.GetChild(2).transform.position.z + PlataforHelperToUse.transform.parent.GetChild(0).GetChild(0).position.z)/2)- PlataforHelperToUse.transform.position.z);
		Vector3 pT3 = new  Vector3(((DoorToUse.transform.GetChild(3).transform.position.x + PlataforHelperToUse.transform.parent.GetChild(0).GetChild(1).position.x)/2)- PlataforHelperToUse.transform.position.x,PlataforHelperToUse.transform.localPosition.y,((DoorToUse.transform.GetChild(3).transform.position.z + PlataforHelperToUse.transform.parent.GetChild(0).GetChild(1).position.z)/2)- PlataforHelperToUse.transform.position.z);
		Vector3 pT4 = ObstObj.transform.GetChild(0).transform.position - PlataforHelperToUse.transform.position;
		Vector3 pT5 = ObstObj.transform.GetChild(1).transform.position - PlataforHelperToUse.transform.position;


		Vector3 pB0 = pT0 - new Vector3(0,PathHeight,0);
		Vector3 pB1 = pT1 - new Vector3(0,PathHeight,0);
		Vector3 pB2 = pT2 - new Vector3(0,PathHeight,0);
		Vector3 pB3 = pT3 - new Vector3(0,PathHeight,0);
		Vector3 pB4 = pT4 - new Vector3(0,PathHeight,0);
		Vector3 pB5 = pT5 - new Vector3(0,PathHeight,0);


		
		Vector3[] vertices = new Vector3[]
		{
			// Top01
			pT0, pT1, pT2, pT3,
			 pT2, pT3,pT4, pT5, 


			// Bot01
			pB0, pB1, pB2, pB3,
			pB2, pB3,pB4, pB5,

			// Left01

			pT1, pB1, pT3, pB3,
			pT3, pB3,pT5, pB5,

			// Righ01
			pT0, pB0, pT2, pB2,
			pT2, pB2,pT4, pB4


			

		};
		#endregion
		
		#region Normales
		Vector3 up 	= Vector3.up;
		Vector3 down 	= Vector3.down;
		Vector3 front 	= Vector3.forward;
		Vector3 back 	= Vector3.back;
		Vector3 left 	= Vector3.left;
		Vector3 right 	= Vector3.right;
		
		Vector3[] normales = new Vector3[]
		{
			// Top
			up, up, up, up,
			up, up,up, up, 

			// Bot
			down, down,down, down,
			down, down,down, down,

			// left
			right,right,right,right,
			right,right,right,right,

			//right
			right,right,right,right,
			right,right,right,right
		};
		#endregion	
		
		#region UVs
		Vector2 _00 = new Vector2( 0f, 0f );
		Vector2 _10 = new Vector2( 1f, 0f );
		Vector2 _01 = new Vector2( 0f, 1f );
		Vector2 _11 = new Vector2( 1f, 1f );
		
		Vector2[] uvs = new Vector2[]
		{
			// Top
			_00, _10,_01,_11,
			_00, _10,_01,_11,
			
			
			// bot
			_10,_00,_11,_01,
			_10,_00,_11,_01,

			// left
			_00, _10,_01,_11,
			_00, _10,_01,_11,

			// right
			_00, _10,_01,_11,
			_00, _10,_01,_11,


			

		};
		#endregion
		
		#region Triangles
		int[] triangles = new int[]
		{

			// Top
			0, 2, 3,
			0, 3, 1,

			4, 6, 7,
			4, 7, 5,

			// Bot
			8, 11, 10,
			8,  9,11,
			
			12, 15,14,
			12, 13,15,



			//Left
			16,18,19,
			16,19,17,

			20,22,23,
			20,23,21,

			//Rigth
			24,25,27,
			24,27,26,

			28,29,31,
			28,31,30





			

			

			
		};
		#endregion
		
		mesh.vertices = vertices;
		mesh.normals = normales;
	
		mesh.uv = uvs;
		mesh.triangles = triangles;
		
		mesh.RecalculateBounds();
		mesh.Optimize();

		MeshCollider caveCollider = gameObject.AddComponent<MeshCollider> ();
		caveCollider.sharedMesh = mesh;




	
	}
	

}





















