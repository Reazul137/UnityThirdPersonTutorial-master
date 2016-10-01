using UnityEngine;
using System.Collections;

public class SumPos : MonoBehaviour {

	float SunTime=0;

	float MapZ=0;

	public int RegiaoLigting_seed=0;

	public float AstrorotationSpeed=0;

	public Light AstroLight;
	public float MaxLigthIntensity=0;

	public bool isSun;
	float SunMunModifier = 0f;
	// Use this for initialization
	void Start () {



		if (isSun) {
			SunMunModifier = 1f;
		} else 


		Random.seed =  ((RegiaoInfo.OverWorldPositionX*1000)+ RegiaoInfo.OverWorldPositionZ) + this.name.GetHashCode();

		float NigthDayVar = Random.Range (0f, 2f);
		SunTime =  ((Mathf.Sin(NigthDayVar*3.14f)+(NigthDayVar*3.14f)) *57.3f)-(180f*SunMunModifier)  ;// Random.Range (0f, RegiaoInfo.Var_LightDark*180f) - (SunMunModifier*180);
		MapZ = RegiaoInfo.OverWorldPositionZ/1000000f;
		MaxLigthIntensity=(RegiaoInfo.Var_LightDark/200f)+0.01f;

		transform.localRotation = Quaternion.Euler(MapZ, 0f, SunTime);






	}
	
	// Update is called once per frame
	void Update () {
		//print (this.name+"---"+transform.rotation.z+"--"+ AstroLight.intensity);


		SunTime += AstrorotationSpeed;
		transform.localRotation = Quaternion.Euler(MapZ, 0, SunTime);


		AstroLight.intensity =  (((Mathf.Cos((transform.rotation.z)*3.14f)*0.5f)+0.5f) * MaxLigthIntensity)+(SunMunModifier*MaxLigthIntensity);

	
	}
}
