using UnityEngine;
using System.Collections;

public class CharPersonality : MonoBehaviour {

	public float CharFemiminity = 5f;
	public float CharMasculinity = 5f;
	public float CharGoofiness = 5f;
	public float CharSeriousness = 5f;

	public float CharMoveSpeed = 5f;
	public float CharMoveStrength = 5f;
	public float CharJumpHigth = 5f;

	public float CharMaxHP = 5f;
	public float CharItemStrength = 5f;
	public float CharItemSpeed = 5f;


	

	// Use this for initialization
	void Start () {

		CharFemiminity = Random.Range (1,10);
		CharMasculinity = Random.Range (1,10);
		CharGoofiness = Random.Range (1,10);
		CharSeriousness = Random.Range (1,10);



	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
