using UnityEngine;
using System.Collections;

public class testadordeposisaoOverWorld001 : MonoBehaviour
{
	
		private float rA = 1F;
		private float rB = 2F;
		private float rC = 3F;
		private float rX = 4F;
		private float rZ = 5F;
		private float rEnd = 5F;
		//private float WorldyFake = 0;
	
		void Update ()
		{

				
				rX = gameObject.transform.position.x + 1.1f;
				rZ = gameObject.transform.position.z + 1.1f;
				
				
				rA = (Mathf.Sin (rX / (rZ * 33) + 1) * Mathf.Sin ((rZ * (rX * 3))) + 1);
				rB = (Mathf.Cos (rX / (rZ * 42) + 1) * Mathf.Cos ((rZ * (rX * 42))) + 1);
				rC = (Mathf.Cos (rX / (rZ * 100) + 1) * Mathf.Sin ((rZ * (rX * 100))) + 1);
				
				
				rEnd = Mathf.Round ((rA + rB + rC) * 10);
				
				
				//print (rEnd);
				
				if (rEnd <= 10) {
						gameObject.GetComponent<Renderer>().material.color = Color.black;
				} else if (rEnd <= 15) {
						gameObject.GetComponent<Renderer>().material.color = Color.red;
				} else if (rEnd <= 16) {
						gameObject.GetComponent<Renderer>().material.color = Color.yellow;
				} else if (rEnd <= 34) {
						gameObject.GetComponent<Renderer>().material.color = Color.blue;
				} else if (rEnd <= 45) {
						gameObject.GetComponent<Renderer>().material.color = Color.green;
				} else if (rEnd <= 45) {
						gameObject.GetComponent<Renderer>().material.color = Color.cyan;
				} else {
						gameObject.GetComponent<Renderer>().material.color = Color.white;
				}
				
				
				
				
		}
}
	
	


