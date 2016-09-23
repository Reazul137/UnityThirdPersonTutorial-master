using UnityEngine;
using System.Collections;

public class StarsRot : MonoBehaviour {



	float MapZ=0;



	public float AstrorotationSpeed=0;
	public float SunTime=0;




	// Use this for initialization
	void Start () {

		MapZ= RegiaoInfo.OverWorldPositionZ;
		transform.localRotation = Quaternion.Euler(MapZ, 0, SunTime);




	}

	// Update is called once per frame
	void Update () {

		SunTime += AstrorotationSpeed;
		transform.localRotation = Quaternion.Euler(MapZ, 0, SunTime);



	}
}
