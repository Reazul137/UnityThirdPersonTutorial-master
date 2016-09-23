using UnityEngine;
using System.Collections;

public class SumPos : MonoBehaviour {

	float SunTime=0;

	float MapZ=0;

	public int RegiaoLigting_seed=0;

	public float AstrorotationSpeed=0;

	public Light AstroLight;
	public float MaxLigthIntensity=0;


	// Use this for initialization
	void Start () {




		Random.seed =  ((RegiaoInfo.OverWorldPositionX*1000)+ RegiaoInfo.OverWorldPositionZ) + this.GetInstanceID();
		SunTime = Random.Range (0, 180) + Random.Range (0, 180) - 180;
		MapZ = RegiaoInfo.OverWorldPositionZ;


		transform.localRotation = Quaternion.Euler(MapZ, 0, SunTime);
		AstroLight.intensity = (1- (Mathf.Abs(SunTime) / 180))*MaxLigthIntensity;

	}
	
	// Update is called once per frame
	void Update () {

		SunTime += AstrorotationSpeed;
		transform.localRotation = Quaternion.Euler(MapZ, 0, SunTime);


	
	}
}
