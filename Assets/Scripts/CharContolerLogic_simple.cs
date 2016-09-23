using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CharContolerLogic_simple : MonoBehaviour {


	private float leftX = 0f;
	private float leftY = 0f;

	public float rigthX = 0f;
	public float rigthY = 0f;



	public GameObject Head;
	public Text GuiBot_X;


	[SerializeField]
	private Vector3 MoveDirection ; 
	[SerializeField]
	public float directionSpeed = 3f;
	public float maxSpeed = 100f;
	private float SprintSpeedModifier = 1f;
	[SerializeField]
	private float JumpHight = 1f;

	private float rotationSpeed = 3f;
	[SerializeField]
	private ThirdPersonCamera gamecam;
	private float direction = 0f;
	private Vector3 directionOut ;
	public Vector3 LookdirectionOut ;

	private float angleRoot = 0f;
	private float angleRootToMove = 0f;

	Rigidbody rigidbody;
	Vector3 CharMove;
	Vector3 velocity;

	public ActionState actionState = ActionState.Noting;





	void OnTriggerStay(Collider other) {
		if (other.gameObject.tag == "DeepOcean")
		{ 
			print("Afoga, diabo!!!");
			this.transform.position =new Vector3(0,50,0);
		}

		if (other.gameObject.tag == "isClimbable") {
			if (actionState == ActionState.Climb) {
				GuiBot_X.text = "Off";
				if (Input.GetButtonDown ("Action")) {
					
					actionState = ActionState.Noting;
				}

			} else {
				GuiBot_X.text = "Climb";
				if (Input.GetButtonDown ("Action")) {
					this.transform.rotation = other.transform.rotation;
					this.transform.position = new Vector3( other.transform.position.x,this.transform.position.y,other.transform.position.z);
					actionState = ActionState.Climb;
				}
			}


		} else if(other.gameObject.tag == "isPickUpable") {
			//actionState = ActionState.PickUp;
			GuiBot_X.text = "PickUP";
			} else {
			GuiBot_X.text = "-A-";
		}
	}

	void OnTriggerExit() {
		actionState = ActionState.Noting;
		GuiBot_X.text = "-A-";
		
	}


	
	void Start () {
		rigidbody = GetComponent<Rigidbody> ();
	}


	public enum ActionState
	{
		Noting,			
		Climb,
		PickUp,
		Opem,
		Talk

	}

	/*
	void LateUpdate () {
		switch (actionState) {

		case ActionState.Noting:

		break;

		case ActionState.Climb:
			
		break;

		case ActionState.PickUp:

		break;

		case ActionState.Opem:

		break;
		
		case ActionState.Talk:

		break;

		}
	}*/

	void OnGUI() {


	}
	void Update () {
		//print (actionState);

		// Input.GetAxis("Target");
		// Input.GetButton("ExitFPV");
		this.rigidbody.velocity = Vector3.ClampMagnitude (this.rigidbody.velocity, maxSpeed);



		switch (actionState) {

		case ActionState.Noting:


			leftX = Input.GetAxis ("Horizontal");
			leftY = Input.GetAxis ("Vertical");

			rigthX = Input.GetAxisRaw ("RightStickX");
			rigthY = Input.GetAxisRaw ("RightStickY");
			MoveStickToWorldspace (gamecam.transform, ref directionOut);
			LookStickToWorldspace (gamecam.transform, ref LookdirectionOut);



			// if triger hold, look arm direction
			if (Input.GetButton ("RotLook")) {
			
				//transform.rotation = Quaternion.RotateTowards (transform.rotation, Head.transform.rotation, Time.deltaTime * rotationSpeed * 100);
				transform.rotation = Head.transform.rotation;
			}


			//Left Stick mooviment

			RaycastHit hit;
			MoveDirection = directionOut * directionSpeed * SprintSpeedModifier;
			if (Physics.Raycast (transform.position, transform.TransformDirection (Vector3.forward), out hit, 2f) && !(Physics.Raycast (transform.position, transform.TransformDirection (Vector3.down), 0.55f)) ) {
				if (hit.transform.tag == "Player") {

					rigidbody.velocity = new Vector3 (MoveDirection.x, rigidbody.velocity.y, MoveDirection.z);

				}

			} else {
				
				rigidbody.velocity = new Vector3 (MoveDirection.x, rigidbody.velocity.y, MoveDirection.z);
			}


			if (this.rigidbody.velocity.x != Vector3.zero.x && this.rigidbody.velocity.z != Vector3.zero.z) {
				transform.rotation = Quaternion.RotateTowards (transform.rotation, Quaternion.LookRotation (new Vector3 (this.rigidbody.velocity.x, 0, this.rigidbody.velocity.z)), Time.deltaTime * rotationSpeed * 100);
			}
			//Right Stick Look
			if (rigthY == 0 && rigthX == 0) {
				//print (Quaternion.LookRotation (LookdirectionOut));
				Head.transform.rotation = Quaternion.Lerp (Head.transform.rotation, transform.rotation, Time.deltaTime * rotationSpeed * 2f);
			} else {
				Head.transform.rotation = Quaternion.LookRotation (LookdirectionOut);

			}

			//Triger buttons
	


			//Action buttons

			Vector3 fwd = transform.TransformDirection (Vector3.down);

			if (Input.GetButton ("Run")) {
				if (Physics.Raycast (transform.position, fwd, 0.55f)) {
					SprintSpeedModifier = 2;
				}
			} else {
				SprintSpeedModifier = 1;

			}


			if (Physics.Raycast (transform.position, fwd, 0.55f)) {
				//print ("There is something in down of the object!");
				if (Input.GetButton ("Jump")) {
			
					this.rigidbody.AddForce (transform.up * JumpHight * 50);

				}
			} else {
				this.rigidbody.AddForce (transform.up * -50);

			}

			break;

		case ActionState.Climb:



			leftY = Input.GetAxis ("Vertical");
			if (Input.GetButton ("Run")) {
				SprintSpeedModifier = 2;
			} else {
				SprintSpeedModifier = 1;

			}
			rigthX = Input.GetAxisRaw ("RightStickX");
			rigthY = Input.GetAxisRaw ("RightStickY");
			LookStickToWorldspace (gamecam.transform, ref LookdirectionOut);
			if (rigthY == 0 && rigthX == 0) {
				//print (Quaternion.LookRotation (LookdirectionOut));
				Head.transform.rotation = Quaternion.Lerp (Head.transform.rotation, transform.rotation, Time.deltaTime * rotationSpeed * 2f);
			} else {


					Head.transform.rotation = Quaternion.LookRotation (LookdirectionOut);
			

			}

			rigidbody.velocity = new Vector3 (0,leftY* directionSpeed, 0);

			if (Input.GetButton ("Jump")) {

				this.rigidbody.AddForce (transform.up * JumpHight * 100);

			}

			break;
		}
		
	}



	public void MoveStickToWorldspace( Transform camera, ref Vector3 directionOut)
	{
		Vector3 rootDirection = this.transform.forward;

	
		Vector3 stickDirection = new Vector3(leftX, 0, leftY);
		Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y + 2f, this.transform.position.z), velocity, Color.blue);
		
	

		// Get camera rotation
		Vector3 CameraDirection = camera.forward;
		CameraDirection.y = 0.0f; // kill Y
		Quaternion referentialShift = Quaternion.FromToRotation(Vector3.forward, Vector3.Normalize(CameraDirection));
		
		// Convert joystick input in Worldspace coordinates
		Vector3 moveDirection = referentialShift * stickDirection;
		Vector3 axisSign = Vector3.Cross(moveDirection, rootDirection);
		

		//Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y + 2.1f, this.transform.position.z), moveDirection, Color.green);
		//Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y + 2f, this.transform.position.z), rootDirection, Color.magenta);
		//Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y + 2f, this.transform.position.z), stickDirection, Color.blue);
		//Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y + 2.5f, this.transform.position.z), axisSign, Color.red);
		
		directionOut = moveDirection ;



	}


	public void LookStickToWorldspace( Transform camera, ref Vector3 LookdirectionOut)
	{
		Vector3 rootDirection = this.transform.forward;
		
		Vector3 stickDirection = new Vector3(rigthX, 0, rigthY);
		Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y + 2f, this.transform.position.z), velocity, Color.blue);
		
		
		
		// Get camera rotation
		Vector3 CameraDirection = camera.forward;
		CameraDirection.y = 0.0f; // kill Y
		Quaternion referentialShift = Quaternion.FromToRotation(Vector3.forward, Vector3.Normalize(CameraDirection));
		
		// Convert joystick input in Worldspace coordinates
		Vector3 LookDirection = referentialShift * stickDirection;
		Vector3 axisSign = Vector3.Cross(LookDirection, rootDirection);
		
		
		Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y + 2.1f, this.transform.position.z), LookDirection, Color.green);
		Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y + 2f, this.transform.position.z), rootDirection, Color.magenta);
		Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y + 2f, this.transform.position.z), stickDirection, Color.blue);
		Debug.DrawRay(new Vector3(this.transform.position.x, this.transform.position.y + 2.5f, this.transform.position.z), axisSign, Color.red);
		

		LookdirectionOut = LookDirection;

		
		
	}
}







//end