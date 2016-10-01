using UnityEngine;
using System.Collections;

public class OceanMov : MonoBehaviour {



	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		float height =0.5f+(1f * Mathf.PerlinNoise(Time.time * 0.2f, 0.0F));
		Vector3 pos = transform.position;
		pos.y = height;
		transform.position = pos;
	}
}
