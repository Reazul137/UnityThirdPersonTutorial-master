using UnityEngine;
using System.Collections;

public class Slider: MonoBehaviour {
	private float slider = 0.0F;
	private SkinnedMeshRenderer sRenderer;

	
	void Start()
	{
		GameObject myObject = transform.gameObject;
		sRenderer = myObject.GetComponent<SkinnedMeshRenderer>();
	}
	
	void OnGUI()
	{
		GUI.Label( new Rect(20,150,150,30),"Blend Shape Slider");
		slider = GUI.HorizontalSlider(new Rect(10, 170, 150, 30), slider, 0.0F, 100.0F);
	}
	
	void Update()
	{
		sRenderer.SetBlendShapeWeight(0, slider);
	}
}