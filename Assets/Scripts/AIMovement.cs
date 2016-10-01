using UnityEngine;
using System.Collections;

public class AIMovement : MonoBehaviour {

	public GameObject AiMovFoucus;
	public float AiMovSpeed = 5;
	public float AiMovForce = 20;

	float AiMovMaxDistance = 10;
	float AiMovMinDistance = 1f;



	// Use this for initialization
	void Start () 
	{
		if(GetComponent<CharPersonality> ())
		{
			AiMovSpeed = GetComponent<CharPersonality> ().CharMoveSpeed;
			AiMovForce = GetComponent<CharPersonality> ().CharMoveStrength;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		AiMov ();
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "DeepOcean") { 
			print ("Afoga, diabo!!!");
			this.transform.position = new Vector3 (0, 50, 0);
		}
	}

	void AiMov ()
	{
			

		Vector3 movLookVector = new Vector3 (AiMovFoucus.transform.position.x - transform.position.x, 0, AiMovFoucus.transform.position.z - transform.position.z);


		transform.rotation = Quaternion.Slerp (transform.rotation, Quaternion.LookRotation (movLookVector), (AiMovSpeed * Time.deltaTime) * 0.9f);
		//transform.rotation = Quaternion.Slerp (transform.rotation, new Quaternion (0,0.1f, 0, 0), (AiMovSpeed * Time.deltaTime) * 0.9f);

		//Vector3.Angle (transform.position, movLookVector)

		
		Vector3 fwd = transform.TransformDirection (Vector3.down);
		if (Physics.Raycast (transform.position, fwd, 0.3f)) { 
			if (Vector3.Distance (transform.position, AiMovFoucus.transform.position) >= AiMovMinDistance) {

				if (GetComponent<Rigidbody> ().velocity.magnitude <= AiMovSpeed) {
				
					//GetComponent<Rigidbody>().AddForce(transform.forward * AiMovForce *(Vector3.Distance (transform.position, AiMovFoucus.transform.position)/10));
					GetComponent<Rigidbody> ().AddForce ((AiMovFoucus.transform.position - transform.position).normalized * AiMovForce * (Vector3.Distance (transform.position, AiMovFoucus.transform.position)));

					//print(Vector3.MoveTowards(transform.position,AiMovFoucus.transform.position,1));
					//GetComponent<Rigidbody>().AddForce((Vector3.MoveTowards(transform.position,AiMovFoucus.transform.position,AiMovSpeed)));
					//transform.position += transform.forward * AiMovSpeed * Time.deltaTime;
				}
			}
		}

	
	}
		



}
