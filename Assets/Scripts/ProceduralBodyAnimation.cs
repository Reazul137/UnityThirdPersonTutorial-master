using UnityEngine;
using System.Collections;

public class ProceduralBodyAnimation : MonoBehaviour {
	public bool isRandom;
	public bool inMainChar;


	public GameObject CharMain;
	public GameObject Head;
	public GameObject Shoulders;
	public GameObject Hip;

	public GameObject RightHand;
	public GameObject LeftHand;

	public GameObject RightFoot;
	public GameObject LeftFoot;

	public GameObject IdleTailPos;

	public float IdleHeadPos_CHANGER_Y = 2f;
	public float IdleShouldersPos_CHANGER_Y = 1.5f;
	public float IdleHipPos_CHANGER_Y = 1f;
	public float IdleLeftHandPos_CHANGER_Y = 5f;

	public float CharFemiminity = 5f;
	public float CharMasculinity = 5f;
	public float CharGoofiness = 5f;
	public float CharSeriousness = 5f;


	private float CharMoveMagnitude = 0f;
	private float CharHipMoveVer = 0f;
	private float CharHeadMoveVer = 0f;
	private float CharHipVerMag = 0.1f;
	public float directionSpeed = 0f;
	private MoveState moveState = MoveState.FallUp;
	private Vector3 Smoothvelocity = Vector3.zero;

	Vector3 velocity;
	Rigidbody rigidbody;

	Vector3 IdleHeadPos;
	Vector3 IdleShouldersPos;
	Vector3 IdleHipPos;
	Vector3 IdleRightHandPos;
	Vector3 IdleLeftHandPos;



	public GameObject rigHead;
	public GameObject rigNeck;
	public GameObject rigChest;

	public GameObject rigVer02;
	public GameObject rigVer01;
	public GameObject rigHip;

	public GameObject rigLeftShoulder;
	public GameObject rigLeftElbow;
	public GameObject rigLeftHand;

	public GameObject rigRightShoulder;
	public GameObject rigRightElbow;
	public GameObject rigRightHand;

	public GameObject rigLeftTie;
	public GameObject rigLeftNee;
	public GameObject rigLeftFoot;

	public GameObject rigRightTie;
	public GameObject rigRightNee;
	public GameObject rigRightFoot;



	public GameObject rigTailTip;

	public float IdleTailPos_CHANGER_Y = 0f;
	public float TailSofthMov = 0f;



	public enum MoveState
	{
		StandStill,			
		Walk,
		Run,
		FallUp,
		FallDown,
		Climb
		
	}

	// Use this for initialization
	void Start () {
		

	
		//directionSpeed = this.GetComponent<CharContolerLogic_simple>().directionSpeed ;
		rigidbody = GetComponent<Rigidbody> ();
		directionSpeed = rigidbody.velocity.magnitude ;



		IdleHeadPos = Head.transform.localPosition;
		IdleShouldersPos = Shoulders.transform.localPosition;
		IdleHipPos = Hip.transform.localPosition;
		IdleRightHandPos = RightHand.transform.localPosition;
		IdleLeftHandPos = LeftHand.transform.localPosition;



		rigHead.transform.parent = Head.transform;
		rigNeck.transform.parent = Shoulders.transform;
		rigChest.transform.parent = Shoulders.transform;
		rigHip.transform.parent = Hip.transform;

		rigRightShoulder.transform.parent = Shoulders.transform;
		rigRightHand.transform.parent = RightHand.transform; 
		rigRightFoot.transform.parent = RightFoot.transform;
		rigRightTie.transform.parent= Hip.transform;

		rigLeftShoulder.transform.parent = Shoulders.transform;
		rigLeftHand.transform.parent = LeftHand.transform; 
		rigLeftFoot.transform.parent = LeftFoot.transform;
		rigLeftTie.transform.parent= Hip.transform;




		if (isRandom) {
			IdleHeadPos.y = 1.2f+ (Random.Range(0f,3.0f));
			IdleHipPos.y= Random.Range((IdleHeadPos.y)*0.5f,IdleHeadPos.y-1.0f);
			IdleShouldersPos.y= Random.Range(IdleHipPos.y+0.2f,IdleHeadPos.y-0.4f);
			IdleLeftHandPos.y= Random.Range(IdleHipPos.y-0.2f,IdleShouldersPos.y-0.4f);

			CharFemiminity = Random.Range(0,10);
			CharMasculinity = Random.Range(0,10);
			CharGoofiness = Random.Range(0,10);
			CharSeriousness = Random.Range(0,10);

			IdleTailPos_CHANGER_Y = Random.Range(-IdleHipPos.y,1);

			TailSofthMov = Random.Range(0.1f,1f);
		}

		IdleHeadPos_CHANGER_Y=IdleHeadPos.y;
		IdleShouldersPos_CHANGER_Y=IdleShouldersPos.y ;
		IdleHipPos_CHANGER_Y=IdleHipPos.y ;

		IdleLeftHandPos_CHANGER_Y = IdleLeftHandPos.y;


		IdleLeftHandPos.y =IdleLeftHandPos_CHANGER_Y;
		IdleRightHandPos.y =IdleLeftHandPos_CHANGER_Y;
		if(inMainChar)IdleRightHandPos.y *= -1;

		if (rigTailTip != null) {
			rigTailTip.transform.parent = null;
			IdleTailPos.transform.position = new Vector3(IdleTailPos.transform.position.x,IdleTailPos.transform.position.y +IdleTailPos_CHANGER_Y,IdleTailPos.transform.position.z);
			IdleTailPos.transform.eulerAngles = new Vector3 (IdleTailPos.transform.eulerAngles.x+(IdleTailPos_CHANGER_Y*90), IdleTailPos.transform.eulerAngles.y, IdleTailPos.transform.eulerAngles.z);
			}

		Hip.transform.position =Vector3.Lerp(Hip.transform.position,new Vector3(Hip.transform.position.x,(transform.position.y +IdleHipPos.y),Hip.transform.position.z),5);


		Head.transform.localPosition = Vector3.Lerp(Head.transform.localPosition,IdleHeadPos, 1);
		Shoulders.transform.localPosition = Vector3.Lerp(Shoulders.transform.localPosition,IdleShouldersPos , 1 );



	}

	void Update () {



		IdleHeadPos.y = IdleHeadPos_CHANGER_Y;
		IdleShouldersPos.y = IdleShouldersPos_CHANGER_Y;
		IdleHipPos.y = IdleHipPos_CHANGER_Y;





	}
	// Update is called once per frame
	void LateUpdate () {


		if (rigTailTip != null) {
			rigTailTip.transform.position = Vector3.Lerp (rigTailTip.transform.position, IdleTailPos.transform.position, TailSofthMov);
			rigTailTip.transform.rotation = Quaternion.Lerp (rigTailTip.transform.rotation, IdleTailPos.transform.rotation, TailSofthMov);}

		Vector3 dwn = transform.TransformDirection(Vector3.down);
		Vector3 fwd = transform.TransformDirection(Vector3.forward);

		CharContolerLogic_simple CharContolerLogic_simpleScript = GetComponent<CharContolerLogic_simple> ();

		if (inMainChar) {
			if (CharContolerLogic_simpleScript.actionState == CharContolerLogic_simple.ActionState.Noting) {
	
				if (Physics.Raycast (transform.position, dwn, 0.55f)) {   //-is on floor


					if (this.rigidbody.velocity.magnitude >= 0.01) {

						directionSpeed = rigidbody.velocity.magnitude;
						//print (directionSpeed);

						if (this.rigidbody.velocity.magnitude < 13) {
							moveState = MoveState.Walk;
						} else {
							moveState = MoveState.Run;
						}
					
				
					} else {
						moveState = MoveState.StandStill;
					}
				} else {	//-is NOT on floor
		
					if (this.rigidbody.velocity.y >= 0) {
						moveState = MoveState.FallUp;
				
					} else if (this.rigidbody.velocity.y < 0) {
						moveState = MoveState.FallDown;
				
					}

				}
			} else if (CharContolerLogic_simpleScript.actionState == CharContolerLogic_simple.ActionState.Climb) {
				moveState = MoveState.Climb;
			}
		} else {
			if (Physics.Raycast (transform.position, dwn, 0.55f)) {   //-is on floor


				if (this.rigidbody.velocity.magnitude >= 0.01) {

					directionSpeed = rigidbody.velocity.magnitude;
					//print (directionSpeed);

					if (this.rigidbody.velocity.magnitude < 13) {
						moveState = MoveState.Walk;
					} else {
						moveState = MoveState.Run;
					}


				} else {
					moveState = MoveState.StandStill;
				}
			} else {	//-is NOT on floor

				if (this.rigidbody.velocity.y >= 0) {
					moveState = MoveState.FallUp;

				} else if (this.rigidbody.velocity.y < 0) {
					moveState = MoveState.FallDown;

				}

			}
		}
		/*    //-----colocar a mao esquerda na parede
		RaycastHit hit;
		if (Physics.Raycast (transform.position+(new Vector3(0,Shoulders.transform.localPosition.y,0)), fwd,out hit, 1f)) {
			if (hit.transform.tag != "Player") {

				LeftHand.transform.parent = null;
				LeftHand.transform.position = Vector3.Lerp(LeftHand.transform.position,hit.point, 0.1f );


			}
			
		}else{
			LeftHand.transform.parent = Shoulders.transform;

		}*/

		

			///----Animatioin States
			///
		switch (moveState)
		{
		case MoveState.StandStill:
			//print ("StandStill");
			LeftHand.transform.parent = Shoulders.transform;
			RightFoot.transform.localEulerAngles = new Vector3 (0, 0, 0);
			LeftFoot.transform.localEulerAngles = new Vector3 (0, 0, 0);


			Hip.transform.position =Vector3.Lerp(Hip.transform.position,new Vector3(Hip.transform.position.x,(transform.position.y +IdleHipPos.y),Hip.transform.position.z),5);
			Hip.transform.localEulerAngles = Vector3.Lerp(Hip.transform.localEulerAngles,new Vector3(0,0,0), 0.9f );
		

			Head.transform.localPosition = Vector3.Lerp(Head.transform.localPosition,IdleHeadPos, 0.1f );
			Shoulders.transform.localPosition = Vector3.Lerp(Shoulders.transform.localPosition,IdleShouldersPos , 0.1f );
			//Shoulders.transform.localEulerAngles = (Head.transform.localEulerAngles + Hip.transform.localEulerAngles)*0.5f;
			if (Input.GetAxisRaw ("RightStickX") == 0 && Input.GetAxisRaw ("RightStickY") == 0 && inMainChar) {
				Shoulders.transform.localEulerAngles = new Vector3(0, Mathf.LerpAngle(Shoulders.transform.localEulerAngles.y,Hip.transform.localEulerAngles.y,0.1f),0);
							
				RightHand.transform.localPosition = Vector3.Lerp(RightHand.transform.localPosition,IdleRightHandPos, 0.1f );	
			}else{
				Hip.transform.localEulerAngles = new Vector3(0, Mathf.DeltaAngle(this.transform.eulerAngles.y+10f,Head.transform.eulerAngles.y)/4,0);
				Shoulders.transform.localEulerAngles = new Vector3(0, Mathf.LerpAngle(Shoulders.transform.localEulerAngles.y,Mathf.DeltaAngle(Hip.transform.localEulerAngles.y+10f,Head.transform.localEulerAngles.y)*0.6f,0.1f),0);

				if(!inMainChar)RightHand.transform.localPosition = Vector3.Lerp(RightHand.transform.localPosition,IdleRightHandPos, 0.1f );	
			}


			if(LeftHand.transform.parent == Shoulders.transform)LeftHand.transform.localPosition = Vector3.Lerp(LeftHand.transform.localPosition,new Vector3(IdleRightHandPos.x*-1,IdleLeftHandPos.y,IdleRightHandPos.z), 0.1f );


			RightFoot.transform.localPosition = Vector3.Lerp(RightFoot.transform.localPosition, new Vector3(0.2f,0,0),0.3f);
			LeftFoot.transform.localPosition =  Vector3.Lerp(LeftFoot.transform.localPosition, new Vector3(-0.2f,0,0),0.3f);


			break;
			
		case MoveState.Walk:
			//print ("Walk");
			LeftHand.transform.parent = Shoulders.transform;
			RightFoot.transform.localEulerAngles = new Vector3 (0, 0, 0);
			LeftFoot.transform.localEulerAngles = new Vector3 (0, 0, 0);

			CharMoveMagnitude =	Mathf.Round( (this.rigidbody.velocity.magnitude / directionSpeed)+1);
			
			CharHipMoveVer= CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude);//+0.75f-(CharHipVerMag/2);
			//print(((CharGoofiness*CharGoofiness)/100));
			Hip.transform.position =new Vector3(Hip.transform.position.x, (Mathf.Abs(CharHipMoveVer*(1+(CharGoofiness*CharGoofiness)/100)) + transform.position.y + IdleHipPos.y),Hip.transform.position.z);
			Hip.transform.localEulerAngles= new Vector3(  Mathf.Cos(Time.time *8*CharMoveMagnitude)*5 ,0,  CharHipMoveVer*10*(CharFemiminity*1.1f)*(CharMoveMagnitude/2));


			CharHeadMoveVer= CharHipVerMag * Mathf.Cos((Time.time *4*CharMoveMagnitude)+(CharGoofiness/2));
			Head.transform.localPosition =new Vector3(Mathf.Cos(Time.time *4*CharMoveMagnitude)*0.02f, (Mathf.Abs(CharHeadMoveVer )  + IdleHeadPos.y),(((this.rigidbody.velocity.magnitude)*(this.rigidbody.velocity.magnitude))/(directionSpeed*directionSpeed))/5);


			if (Input.GetAxisRaw ("RightStickX") == 0 && Input.GetAxisRaw ("RightStickY") == 0 && inMainChar) {
				Shoulders.transform.localPosition = new Vector3(Mathf.Cos(Time.time *4*CharMoveMagnitude)*0.002f, (Mathf.Abs(CharHeadMoveVer )  + IdleShouldersPos.y),(((this.rigidbody.velocity.magnitude)*(this.rigidbody.velocity.magnitude))/(directionSpeed*directionSpeed))*0.1f);

				Shoulders.transform.localEulerAngles= new Vector3(  Mathf.Cos(Time.time *8*CharMoveMagnitude)*5 , (CharHipMoveVer*-22*(CharMasculinity)*(CharMoveMagnitude/2)),  CharHipMoveVer*-10*(CharMasculinity)*(CharMoveMagnitude/2));
			//Shoulders.transform.localRotation= Quaternion.LookRotation(new Vector3(  Mathf.Cos(Time.time *2*CharMoveMagnitude)*5 , (CharHipMoveVer*-1*(CharMasculinity)*(CharMoveMagnitude/2))+((this.GetComponent<CharContolerLogic_simple>().LookdirectionOut.y + Hip.transform.localEulerAngles.y)*0.5f),  CharHipMoveVer*-1*(CharMasculinity)*(CharMoveMagnitude/2)));
		

			  RightHand.transform.localPosition =new Vector3(IdleRightHandPos.x, 	  (Mathf.Abs((CharHipMoveVer*5)/Mathf.Max( CharFemiminity,(10-CharGoofiness)))  + IdleRightHandPos.y),((CharHipMoveVer*(CharMasculinity*0.6f))  + IdleRightHandPos.z));

			}else{
				Shoulders.transform.localEulerAngles = new Vector3(0, Mathf.LerpAngle(Shoulders.transform.localEulerAngles.y,Mathf.DeltaAngle(Hip.transform.localEulerAngles.y,Head.transform.localEulerAngles.y)/2,0.1f),0);
				if(!inMainChar) RightHand.transform.localPosition =new Vector3(IdleRightHandPos.x, 	  (Mathf.Abs((CharHipMoveVer*5)/Mathf.Max( CharFemiminity,(10-CharGoofiness)))  + IdleRightHandPos.y),((CharHipMoveVer*(CharMasculinity*0.6f))  + IdleRightHandPos.z));

			}



			if(LeftHand.transform.parent == Shoulders.transform)LeftHand.transform.localPosition =	   new Vector3(IdleRightHandPos.x *-1, (Mathf.Abs((CharHipMoveVer*-5)/ Mathf.Max( CharFemiminity,(10-CharGoofiness)) ) + IdleLeftHandPos.y),((CharHipMoveVer*(CharMasculinity*-0.6f))  + IdleRightHandPos.z));

			LeftHand.transform.localEulerAngles = Vector3.Lerp (LeftHand.transform.localEulerAngles, new Vector3 (0,0,0), 1f);


			RightFoot.transform.localPosition = Vector3.Lerp(RightFoot.transform.localPosition, new Vector3( Mathf.Max(0,( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.03f)*CharFemiminity)+(0.2f-CharFemiminity/40) ,  Mathf.Max(0, Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.05f)*CharGoofiness,(CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude))*-2f*CharMoveMagnitude),0.3f);
			LeftFoot.transform.localPosition =  Vector3.Lerp(LeftFoot.transform.localPosition, new Vector3( Mathf.Min(0,( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.03f)*CharFemiminity )-(0.2f-CharFemiminity/40),  Mathf.Max(0, Mathf.Sin(Time.time *-4*CharMoveMagnitude)*0.05f)*CharGoofiness,(CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude))*2f*CharMoveMagnitude),0.3f);


			break;

		case MoveState.Run:
			LeftHand.transform.parent = Shoulders.transform;
			RightFoot.transform.localEulerAngles = new Vector3 (0, 0, 0);
			LeftFoot.transform.localEulerAngles = new Vector3 (0, 0, 0);
			
			CharMoveMagnitude =	Mathf.Round( (this.rigidbody.velocity.magnitude / directionSpeed)+2);
			
			CharHipMoveVer= CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude);//+0.75f-(CharHipVerMag/2);
			//print(((CharGoofiness*CharGoofiness)/100));
			Hip.transform.position =new Vector3(Hip.transform.position.x, (Mathf.Abs(CharHipMoveVer*(1+(CharGoofiness*CharGoofiness)/100)) + transform.position.y + IdleHipPos.y),Hip.transform.position.z);
			Hip.transform.localEulerAngles= new Vector3(  Mathf.Cos(Time.time *8*CharMoveMagnitude)*5 ,0,  CharHipMoveVer*10*(CharFemiminity)*(CharMoveMagnitude/2));
			
			
			CharHeadMoveVer= CharHipVerMag * Mathf.Cos((Time.time *4*CharMoveMagnitude)+(CharGoofiness/2));
			Head.transform.localPosition =new Vector3(Mathf.Cos(Time.time *4*CharMoveMagnitude)*0.02f, (Mathf.Abs(CharHeadMoveVer )  + IdleHeadPos.y),(((this.rigidbody.velocity.magnitude)*(this.rigidbody.velocity.magnitude))/(directionSpeed*directionSpeed))/3);
			
			
			if (Input.GetAxisRaw ("RightStickX") == 0 && Input.GetAxisRaw ("RightStickY") == 0 && inMainChar) {
				Shoulders.transform.localPosition = new Vector3((Head.transform.localPosition.x + Hip.transform.localPosition.x)*0.5f,(Head.transform.localPosition.y + Hip.transform.localPosition.y)*0.51f,(Head.transform.localPosition.z + Hip.transform.localPosition.z)*0.5f);
				Shoulders.transform.localEulerAngles= new Vector3(  Mathf.Cos(Time.time *8*CharMoveMagnitude)*5 , (CharHipMoveVer*-22*(CharMasculinity)*(CharMoveMagnitude/2)),  CharHipMoveVer*-10*(CharMasculinity)*(CharMoveMagnitude/2));
				//Shoulders.transform.localRotation= Quaternion.LookRotation(new Vector3(  Mathf.Cos(Time.time *2*CharMoveMagnitude)*5 , (CharHipMoveVer*-1*(CharMasculinity)*(CharMoveMagnitude/2))+((this.GetComponent<CharContolerLogic_simple>().LookdirectionOut.y + Hip.transform.localEulerAngles.y)*0.5f),  CharHipMoveVer*-1*(CharMasculinity)*(CharMoveMagnitude/2)));
				
				
				RightHand.transform.localPosition =new Vector3(IdleRightHandPos.x, 	  (Mathf.Abs((CharHipMoveVer*5)/Mathf.Max( CharFemiminity,(10-CharGoofiness)))  + IdleRightHandPos.y),((CharHipMoveVer*(CharMasculinity*0.6f))  + IdleRightHandPos.z));
			}else{
				Shoulders.transform.localEulerAngles = new Vector3(0, Mathf.LerpAngle(Shoulders.transform.localEulerAngles.y,Mathf.DeltaAngle(Hip.transform.localEulerAngles.y,Head.transform.localEulerAngles.y)/2,0.1f),0);
				if(!inMainChar) 	RightHand.transform.localPosition =new Vector3(IdleRightHandPos.x, 	  (Mathf.Abs((CharHipMoveVer*5)/Mathf.Max( CharFemiminity,(10-CharGoofiness)))  + IdleRightHandPos.y),((CharHipMoveVer*(CharMasculinity*0.6f))  + IdleRightHandPos.z));

			}
			
			if(LeftHand.transform.parent == Shoulders.transform)LeftHand.transform.localPosition =	   new Vector3(IdleRightHandPos.x *-1, (Mathf.Abs((CharHipMoveVer*-5)/ Mathf.Max( CharFemiminity,(10-CharGoofiness)) ) + IdleLeftHandPos.y),((CharHipMoveVer*(CharMasculinity*-0.6f))  + IdleRightHandPos.z));

			LeftHand.transform.localEulerAngles = Vector3.Lerp (LeftHand.transform.localEulerAngles, new Vector3 (0,0,0), 1f);
			
			
			
			RightFoot.transform.localPosition = Vector3.Lerp(RightFoot.transform.localPosition, new Vector3( Mathf.Max(0,( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.03f)*CharFemiminity)+(0.2f-CharFemiminity/40) ,  Mathf.Max(0, Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.05f)*CharGoofiness,(CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude))*-2f*CharMoveMagnitude),0.3f);
			LeftFoot.transform.localPosition =  Vector3.Lerp(LeftFoot.transform.localPosition, new Vector3( Mathf.Min(0,( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.03f)*CharFemiminity )-(0.2f-CharFemiminity/40),  Mathf.Max(0, Mathf.Sin(Time.time *-4*CharMoveMagnitude)*0.05f)*CharGoofiness,(CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude))*2f*CharMoveMagnitude),0.3f);

			break;

		case MoveState.FallUp:
			LeftHand.transform.parent = Shoulders.transform;
			//print ("FallUp");

			//Debug.DrawRay(new Vector3(this.rigidbody.position.x,this.rigidbody.position.y+2.5f,this.rigidbody.position.z),(this.rigidbody.GetRelativePointVelocity(new Vector3(this.rigidbody.position.x,this.rigidbody.position.y,this.rigidbody.position.z))), Color.blue);

			Hip.transform.position = Vector3.Lerp (Hip.transform.position, (new Vector3 (Hip.transform.position.x, (transform.position.y + IdleHipPos.y + 0.1f), Hip.transform.position.z)), 0.1f);
			Hip.transform.localEulerAngles = Vector3.Lerp (Hip.transform.localEulerAngles, new Vector3 (this.rigidbody.velocity.magnitude * 4, 0, 0), 5);

			Head.transform.localPosition = Vector3.Lerp (Head.transform.localPosition, new Vector3 (IdleHeadPos.x, IdleHeadPos.y - 0.1f, IdleHeadPos.z), 0.1f);

			if (Input.GetAxisRaw ("RightStickX") == 0 && Input.GetAxisRaw ("RightStickY") == 0 && inMainChar) {
				Shoulders.transform.localPosition = Vector3.Lerp (Shoulders.transform.localPosition, IdleShouldersPos, 0.1f);
				Shoulders.transform.localEulerAngles = (Head.transform.localEulerAngles + Hip.transform.localEulerAngles) * 0.5f;


				RightHand.transform.localPosition = Vector3.Lerp (RightHand.transform.localPosition, IdleRightHandPos, 0.1f);
			} else {
				Shoulders.transform.localEulerAngles = new Vector3 (0, Mathf.LerpAngle (Shoulders.transform.localEulerAngles.y, Mathf.DeltaAngle (Hip.transform.localEulerAngles.y, Head.transform.localEulerAngles.y) / 2, 0.1f), 0);
				if(!inMainChar) RightHand.transform.localPosition = Vector3.Lerp (RightHand.transform.localPosition, IdleRightHandPos, 0.1f);
			}
			LeftHand.transform.localPosition = Vector3.Lerp (LeftHand.transform.localPosition, new Vector3 (IdleRightHandPos.x * -1, IdleLeftHandPos.y, IdleRightHandPos.z), 0.1f);
			LeftHand.transform.localEulerAngles = Vector3.Lerp (LeftHand.transform.localEulerAngles, new Vector3 (0,0,0), 1f);


			RightFoot.transform.localPosition = Vector3.Lerp (RightFoot.transform.localPosition, new Vector3 (0.2f, -0.3f, (this.rigidbody.velocity.magnitude * -0.01f) + RightFoot.transform.localPosition.z), 0.04f);
			LeftFoot.transform.localPosition = Vector3.Lerp (LeftFoot.transform.localPosition, new Vector3 (-0.2f, -0.3f, (this.rigidbody.velocity.magnitude * -0.01f) + LeftFoot.transform.localPosition.z), 0.04f);

			RightFoot.transform.localEulerAngles =Vector3.Lerp (RightFoot.transform.localEulerAngles, new Vector3 (45, 0, 0), 0.1f); 
			LeftFoot.transform.localEulerAngles =Vector3.Lerp (LeftFoot.transform.localEulerAngles, new Vector3 (45, 0, 0), 0.1f);

			break;
			
		case MoveState.FallDown:
			LeftHand.transform.parent = Shoulders.transform;
			//print ("FallDown");
			Hip.transform.position =Vector3.Lerp(Hip.transform.position ,(new Vector3(Hip.transform.position.x, (transform.position.y + IdleHipPos.y - 0.1f),Hip.transform.position.z)),0.1f);

			Hip.transform.localEulerAngles= Vector3.Lerp(Hip.transform.localEulerAngles, new Vector3( Mathf.Clamp(this.rigidbody.velocity.magnitude * -2,-0,40), 0, 0 ),1f );
			Head.transform.localPosition = Vector3.Lerp(Head.transform.localPosition, new Vector3( IdleHeadPos.x, IdleHeadPos.y + 0.1f , IdleHeadPos.z ), 0.1f );


			if (Input.GetAxisRaw ("RightStickX") == 0 && Input.GetAxisRaw ("RightStickY") == 0 && inMainChar) {
			Shoulders.transform.localPosition = Vector3.Lerp(Shoulders.transform.localPosition,IdleShouldersPos, 0.1f );
			Shoulders.transform.localEulerAngles = (Head.transform.localEulerAngles + Hip.transform.localEulerAngles);

			RightHand.transform.localPosition = Vector3.Lerp(RightHand.transform.localPosition,new Vector3(IdleRightHandPos.x,IdleRightHandPos.y+1,IdleRightHandPos.z), 0.1f );
			
			}else{

				RightHand.transform.localPosition = Vector3.Lerp(RightHand.transform.localPosition,new Vector3(IdleRightHandPos.x,IdleRightHandPos.y,IdleRightHandPos.z), 0.1f );
				Shoulders.transform.localEulerAngles = new Vector3(0, Mathf.LerpAngle(Shoulders.transform.localEulerAngles.y,Mathf.DeltaAngle(Hip.transform.localEulerAngles.y,Head.transform.localEulerAngles.y)/2,0.1f),0);
				if(!inMainChar) RightHand.transform.localPosition = Vector3.Lerp(RightHand.transform.localPosition,new Vector3(IdleRightHandPos.x,IdleRightHandPos.y+1,IdleRightHandPos.z), 0.1f );

			}
			LeftHand.transform.localPosition = Vector3.Lerp(LeftHand.transform.localPosition,new Vector3(IdleRightHandPos.x*-1,(IdleRightHandPos.y)*-1,IdleRightHandPos.z), 0.04f );
			LeftHand.transform.localEulerAngles = Vector3.Lerp (LeftHand.transform.localEulerAngles, new Vector3 (0,0,0), 1f);

			RightFoot.transform.localPosition = Vector3.Lerp(RightFoot.transform.localPosition, new Vector3(0.2f,-0.2f,Mathf.Min( this.rigidbody.velocity.magnitude * 0.04f,0.6f)),0.04f);
			LeftFoot.transform.localPosition =  Vector3.Lerp(LeftFoot.transform.localPosition, 	new Vector3(-0.2f,0.2f,Mathf.Min( this.rigidbody.velocity.magnitude * 0.01f,0.5f)),0.04f);
			                                                                                           
			RightFoot.transform.localEulerAngles =Vector3.Lerp (RightFoot.transform.localEulerAngles, new Vector3 (0, 0, 0), 0.1f); 
			LeftFoot.transform.localEulerAngles =Vector3.Lerp (LeftFoot.transform.localEulerAngles, new Vector3 (0, 0, 0), 0.1f);

			break;


		case MoveState.Climb:
			//print ("Climb_anima");

			float leftY = Input.GetAxis ("Vertical");

			RightFoot.transform.localEulerAngles = new Vector3 (0, 0, 0);
			LeftFoot.transform.localEulerAngles = new Vector3 (0, 0, 0);

			CharMoveMagnitude =	leftY * 5;

			CharHipMoveVer = CharHipVerMag * Mathf.Cos (Time.time * 4 * CharMoveMagnitude);//+0.75f-(CharHipVerMag/2);
			//print(((CharGoofiness*CharGoofiness)/100));
			//Hip.transform.position =new Vector3(Hip.transform.position.x, (Mathf.Abs(CharHipMoveVer*(1+(CharGoofiness*CharGoofiness)/100)) + transform.position.y + IdleHipPos.y),Hip.transform.position.z);
			Hip.transform.localEulerAngles = new Vector3 (Mathf.Cos (Time.time * 8 * CharMoveMagnitude) * 5, 0, CharHipMoveVer * 10 * (CharFemiminity * 1.1f) * (CharMoveMagnitude / 2));


			CharHeadMoveVer = CharHipVerMag * Mathf.Cos ((Time.time * 4 * CharMoveMagnitude) + (CharGoofiness / 2));
			Head.transform.localPosition = new Vector3 (0, (Mathf.Abs (CharHeadMoveVer) + IdleHeadPos.y), 0);


			if (Input.GetAxisRaw ("RightStickX") == 0 && Input.GetAxisRaw ("RightStickY") == 0 && inMainChar) {
				//Shoulders.transform.localPosition = new Vector3(Mathf.Cos(Time.time *4*CharMoveMagnitude)*0.002f, (Mathf.Abs(CharHeadMoveVer )  + IdleShouldersPos.y),(((this.rigidbody.velocity.magnitude)*(this.rigidbody.velocity.magnitude))/(directionSpeed*directionSpeed))*0.1f);

				Shoulders.transform.localEulerAngles = new Vector3 (Mathf.Cos (Time.time * 8 * CharMoveMagnitude) * 5, (CharHipMoveVer * -22 * (CharMasculinity) * (CharMoveMagnitude / 2)), CharHipMoveVer * -10 * (CharMasculinity) * (CharMoveMagnitude / 2));
				//Shoulders.transform.localRotation= Quaternion.LookRotation(new Vector3(  Mathf.Cos(Time.time *2*CharMoveMagnitude)*5 , (CharHipMoveVer*-1*(CharMasculinity)*(CharMoveMagnitude/2))+((this.GetComponent<CharContolerLogic_simple>().LookdirectionOut.y + Hip.transform.localEulerAngles.y)*0.5f),  CharHipMoveVer*-1*(CharMasculinity)*(CharMoveMagnitude/2)));


				RightHand.transform.localPosition = new Vector3 (IdleRightHandPos.x, (Mathf.Abs ((CharHipMoveVer * 5) / Mathf.Max (CharFemiminity, (10 - CharGoofiness))) + IdleRightHandPos.y), ((CharHipMoveVer * (CharMasculinity * 0.6f)) + IdleRightHandPos.z));

			} else {
				Shoulders.transform.localEulerAngles = new Vector3 (0, Mathf.LerpAngle (Shoulders.transform.localEulerAngles.y, Mathf.DeltaAngle (Hip.transform.localEulerAngles.y, Head.transform.localEulerAngles.y) / 2, 0.1f), 0);
				if (!inMainChar)
					RightHand.transform.localPosition = Vector3.Lerp (LeftFoot.transform.localPosition, new Vector3 (Mathf.Min (0, (Mathf.Sin (Time.time * -4 * CharMoveMagnitude) * -0.03f) * CharFemiminity) - (0.2f - CharFemiminity / 40), (Mathf.Sin (Time.time * -4 * CharMoveMagnitude) * 0.05f) * CharGoofiness, (Mathf.Min (0, CharHipVerMag * Mathf.Cos (Time.time * 4 * CharMoveMagnitude)) * 2f * Mathf.Abs (CharMoveMagnitude)) + 0.1f), 0.3f);

			}



			LeftHand.transform.parent = this.transform;
			LeftHand.transform.localPosition = Vector3.Lerp (RightFoot.transform.localPosition, new Vector3 (-1.5f, ((Mathf.Sin (Time.time * -4 * CharMoveMagnitude) * -0.05f) * CharGoofiness) + 4, (Mathf.Max (-0.2f, CharHipVerMag * Mathf.Cos (Time.time * 4 * CharMoveMagnitude)) * -2f * Mathf.Abs (CharMoveMagnitude)) + 0.1f), 0.3f);
			LeftHand.transform.localEulerAngles = Vector3.Lerp (LeftHand.transform.localEulerAngles, new Vector3 (270,0,0), 1f);



			RightFoot.transform.localPosition = Vector3.Lerp(RightFoot.transform.localPosition, new Vector3( Mathf.Max(0,( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.03f)*CharFemiminity)+(0.2f-CharFemiminity/40) ,  ( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.05f)*CharGoofiness,(Mathf.Max(0,CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude))*-2f*Mathf.Abs(CharMoveMagnitude))+0.1f),0.3f);
			LeftFoot.transform.localPosition =  Vector3.Lerp(LeftFoot.transform.localPosition, new Vector3( Mathf.Min(0,( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.03f)*CharFemiminity )-(0.2f-CharFemiminity/40),  ( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*0.05f)*CharGoofiness,(Mathf.Min(0,CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude))*2f* Mathf.Abs( CharMoveMagnitude))+0.1f),0.3f);


			break;
		}

		rigNeck.transform.LookAt ( rigHead.transform);

		rigVer01.transform.position =new Vector3(((rigChest.transform.position.x + rigHip.transform.position.x)/2),(rigChest.transform.position.y + rigHip.transform.position.y)/2,((rigChest.transform.position.z + rigHip.transform.position.z)/2));
		rigVer01.transform.rotation =Quaternion.Slerp( rigChest.transform.rotation , rigHip.transform.rotation,0.9f);

		rigVer02.transform.position =new Vector3(((rigChest.transform.position.x + rigVer01.transform.position.x)/2),(rigChest.transform.position.y + rigVer01.transform.position.y)/2,((rigChest.transform.position.z + rigVer01.transform.position.z)/2));
		rigVer02.transform.rotation =Quaternion.Slerp( rigChest.transform.rotation , rigVer01.transform.rotation,0.5f);



		rigRightNee.transform.position = new Vector3((rigRightTie.transform.position.x + rigRightFoot.transform.position.x)/2,(rigRightTie.transform.position.y + rigRightFoot.transform.position.y)/2,((rigRightTie.transform.position.z + rigRightFoot.transform.position.z)/2));

		float RrotZ=( Mathf.Atan2(rigRightNee.transform.localPosition.x -rigRightFoot.transform.localPosition.x	, rigRightNee.transform.localPosition.y -rigRightFoot.transform.localPosition.y)*180/Mathf.PI);	
		float RrotX=( Mathf.Atan2(rigRightNee.transform.localPosition.z -rigRightFoot.transform.localPosition.z	, rigRightNee.transform.localPosition.y -rigRightFoot.transform.localPosition.y)*180/Mathf.PI)*-1;	
		rigRightNee.transform.localEulerAngles = new Vector3(RrotX,0,RrotZ);

		float RrotZTie=( Mathf.Atan2(rigRightTie.transform.localPosition.x -rigRightNee.transform.localPosition.x	, rigRightTie.transform.localPosition.y -rigRightNee.transform.localPosition.y)*180/Mathf.PI);	
		float RrotXTie=( Mathf.Atan2(rigRightTie.transform.localPosition.z -rigRightNee.transform.localPosition.z	, rigRightTie.transform.localPosition.y -rigRightNee.transform.localPosition.y)*180/Mathf.PI);	
		rigRightTie.transform.localEulerAngles = new Vector3(RrotXTie,-180,RrotZTie);

		rigRightElbow.transform.position = new Vector3((rigRightShoulder.transform.position.x + rigRightHand.transform.position.x)/2,(rigRightShoulder.transform.position.y + rigRightHand.transform.position.y)/2,((rigRightShoulder.transform.position.z + rigRightHand.transform.position.z)/2));
		rigRightElbow.transform.LookAt ( rigRightHand.transform);
		rigRightShoulder.transform.LookAt ( rigRightElbow.transform);



		rigLeftNee.transform.position = new Vector3( (rigLeftTie.transform.position.x + rigLeftFoot.transform.position.x)/2,(rigLeftTie.transform.position.y + rigLeftFoot.transform.position.y)/2,((rigLeftTie.transform.position.z + rigLeftFoot.transform.position.z)/2));

		float LrotZ=( Mathf.Atan2(rigLeftNee.transform.localPosition.x -rigLeftFoot.transform.localPosition.x	, rigLeftNee.transform.localPosition.y -rigLeftFoot.transform.localPosition.y)*180/Mathf.PI);	
		float LrotX=( Mathf.Atan2(rigLeftNee.transform.localPosition.z -rigLeftFoot.transform.localPosition.z	, rigLeftNee.transform.localPosition.y -rigLeftFoot.transform.localPosition.y)*180/Mathf.PI)*-1;	
		rigLeftNee.transform.localEulerAngles = new Vector3(LrotX,0,LrotZ);

		float LrotZTie=( Mathf.Atan2(rigLeftTie.transform.localPosition.x -rigLeftNee.transform.localPosition.x	, rigLeftTie.transform.localPosition.y -rigLeftNee.transform.localPosition.y)*180/Mathf.PI);	
		float LrotXTie=( Mathf.Atan2(rigLeftTie.transform.localPosition.z -rigLeftNee.transform.localPosition.z	, rigLeftTie.transform.localPosition.y -rigLeftNee.transform.localPosition.y)*180/Mathf.PI);	
		rigLeftTie.transform.localEulerAngles = new Vector3(LrotXTie,-180,LrotZTie);

		rigLeftElbow.transform.position = new Vector3((rigLeftShoulder.transform.position.x + rigLeftHand.transform.position.x)/2,(rigLeftShoulder.transform.position.y + rigLeftHand.transform.position.y)/2,((rigLeftShoulder.transform.position.z + rigLeftHand.transform.position.z)/2));
		rigLeftElbow.transform.LookAt ( rigLeftHand.transform);
		rigLeftShoulder.transform.LookAt ( rigLeftElbow.transform);




	}

}
