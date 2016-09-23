using UnityEngine;
using System.Collections;

public class RandomPosTest : MonoBehaviour {

	private float nextJump = 1F;



	void Update() {
		if (Time.time > nextJump) {
			nextJump += 3;
			transform.position = new Vector3 (Random.value * 30,0,Random.value * 30);

		}
	}
}
