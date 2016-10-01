using UnityEngine;
using System.Collections;

public class aiProceduralBOdyAnim : MonoBehaviour {
	
	public GameObject CharMain;
	public GameObject Head;
	public GameObject Shoulders;
	public GameObject Hip;
	
	public GameObject RightHand;
	public GameObject LeftHand;
	
	public GameObject RightFoot;
	public GameObject LeftFoot;
	
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

	public GameObject HeadFoucus;
	
	
	public enum MoveState
	{
		StandStill,			
		Walk,
		Run,
		FallUp,
		FallDown
		
	}
	
	// Use this for initialization
	void Start () {
		//directionSpeed = this.GetComponent<CharContolerLogic_simple>().directionSpeed ;
		rigidbody = GetComponent<Rigidbody> ();
		directionSpeed = rigidbody.velocity.magnitude ;
		//print (directionSpeed);
		
		
		IdleHeadPos = Head.transform.localPosition;
		IdleShouldersPos = Shoulders.transform.localPosition;
		IdleHipPos = Hip.transform.localPosition;
		IdleRightHandPos = RightHand.transform.localPosition;
		IdleLeftHandPos = LeftHand.transform.localPosition;




		CharFemiminity = GetComponent<CharPersonality> ().CharFemiminity;
		CharMasculinity =  GetComponent<CharPersonality> ().CharMasculinity;
		CharGoofiness =  GetComponent<CharPersonality> ().CharGoofiness;
		CharSeriousness =  GetComponent<CharPersonality> ().CharSeriousness;
		
	}
	
	
	// Update is called once per frame

	void Update () {

		Head.transform.LookAt (HeadFoucus.transform.position);

	}


	void LateUpdate () {
		
		
		
		
		Vector3 fwd = transform.TransformDirection(Vector3.down);
		if (Physics.Raycast (transform.position, fwd, 0.3f)) {   //-is on floor

			directionSpeed = rigidbody.velocity.magnitude ;
			//print(directionSpeed);
			
			if (directionSpeed >=0.01) {


				
				if(directionSpeed <13 )
				{

					moveState = MoveState.Walk;
				}else 
				{
					moveState = MoveState.Run;
				}
				
				
			} else {

				moveState = MoveState.StandStill;
			}
		} else {	//-is NOT on floor
			
			if (this.rigidbody.velocity.y >= 0) {
				moveState = MoveState.FallUp;
				
			}else if (this.rigidbody.velocity.y < 0) {
				moveState = MoveState.FallDown;
				
			}
			
		}
		
		
		
		///----Animatioin States
		///
		switch (moveState)
		{
		case MoveState.StandStill:
			//print ("StandStill");
			
			
			Hip.transform.position =Vector3.Lerp(Hip.transform.position,new Vector3(Hip.transform.position.x,(transform.position.y +IdleHipPos.y),Hip.transform.position.z),5);
			Hip.transform.localEulerAngles = Vector3.Lerp(Hip.transform.localEulerAngles,new Vector3(0,0,0), 0.9f );
			
			
			Head.transform.localPosition = Vector3.Lerp(Head.transform.localPosition,IdleHeadPos, 0.1f );
			Shoulders.transform.localPosition = Vector3.Lerp(Shoulders.transform.localPosition,IdleShouldersPos, 0.1f );
			//Shoulders.transform.localEulerAngles = (Head.transform.localEulerAngles + Hip.transform.localEulerAngles)*0.5f;
			if (Input.GetAxisRaw ("RightStickX") == 0 && Input.GetAxisRaw ("RightStickY") == 0) {
				Shoulders.transform.localEulerAngles = new Vector3(0, Mathf.LerpAngle(Shoulders.transform.localEulerAngles.y,Hip.transform.localEulerAngles.y,0.1f),0);
				
				RightHand.transform.localPosition = Vector3.Lerp(RightHand.transform.localPosition,IdleRightHandPos, 0.1f );	
			}else{
				Hip.transform.localEulerAngles = new Vector3(0, Mathf.DeltaAngle(this.transform.eulerAngles.y,Head.transform.eulerAngles.y)/4,0);
				Shoulders.transform.localEulerAngles = new Vector3(0, Mathf.LerpAngle(Shoulders.transform.localEulerAngles.y,Mathf.DeltaAngle(Hip.transform.localEulerAngles.y,Head.transform.localEulerAngles.y)/2,0.1f),0);
			}
			
			
			LeftHand.transform.localPosition = Vector3.Lerp(LeftHand.transform.localPosition,new Vector3(IdleRightHandPos.x*-1,IdleLeftHandPos.y,IdleRightHandPos.z), 0.1f );
			
			
			RightFoot.transform.localPosition = Vector3.Lerp(RightFoot.transform.localPosition, new Vector3(0.2f,0,0),0.3f);
			LeftFoot.transform.localPosition =  Vector3.Lerp(LeftFoot.transform.localPosition, new Vector3(-0.2f,0,0),0.3f);
			
			
			break;
			
		case MoveState.Walk:
			//print ("Walk");
			
			CharMoveMagnitude =	Mathf.Round( (this.rigidbody.velocity.magnitude / directionSpeed)+1);
			
			CharHipMoveVer= CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude);//+0.75f-(CharHipVerMag/2);
			//print(((CharGoofiness*CharGoofiness)/100));
			Hip.transform.position =new Vector3(Hip.transform.position.x, (Mathf.Abs(CharHipMoveVer*(1+(CharGoofiness*CharGoofiness)/100)) + transform.position.y + IdleHipPos.y),Hip.transform.position.z);
			Hip.transform.localEulerAngles= new Vector3(  Mathf.Cos(Time.time *8*CharMoveMagnitude)*5 ,0,  CharHipMoveVer*10*(CharFemiminity)*(CharMoveMagnitude/2));
			
			
			CharHeadMoveVer= CharHipVerMag * Mathf.Cos((Time.time *4*CharMoveMagnitude)+(CharGoofiness/2));
			Head.transform.localPosition =new Vector3(Mathf.Cos(Time.time *4*CharMoveMagnitude)*0.02f, (Mathf.Abs(CharHeadMoveVer )  + IdleHeadPos.y),(((this.rigidbody.velocity.magnitude)*(this.rigidbody.velocity.magnitude))/(directionSpeed*directionSpeed))/5);
			
			
			if (Input.GetAxisRaw ("RightStickX") == 0 && Input.GetAxisRaw ("RightStickY") == 0) {
				Shoulders.transform.localPosition = new Vector3((Head.transform.localPosition.x + Hip.transform.localPosition.x)*0.5f,(Head.transform.localPosition.y + Hip.transform.localPosition.y)*0.51f,(Head.transform.localPosition.z + Hip.transform.localPosition.z)*0.5f);
				Shoulders.transform.localEulerAngles= new Vector3(  Mathf.Cos(Time.time *8*CharMoveMagnitude)*5 , (CharHipMoveVer*-22*(CharMasculinity)*(CharMoveMagnitude/2)),  CharHipMoveVer*-10*(CharMasculinity)*(CharMoveMagnitude/2));
				//Shoulders.transform.localRotation= Quaternion.LookRotation(new Vector3(  Mathf.Cos(Time.time *2*CharMoveMagnitude)*5 , (CharHipMoveVer*-1*(CharMasculinity)*(CharMoveMagnitude/2))+((this.GetComponent<CharContolerLogic_simple>().LookdirectionOut.y + Hip.transform.localEulerAngles.y)*0.5f),  CharHipMoveVer*-1*(CharMasculinity)*(CharMoveMagnitude/2)));
				
				
				RightHand.transform.localPosition =new Vector3(IdleRightHandPos.x, 	  (Mathf.Abs((CharHipMoveVer*5)/Mathf.Max( CharFemiminity,(10-CharGoofiness)))  + IdleRightHandPos.y),((CharHipMoveVer*(CharMasculinity*0.6f))  + IdleRightHandPos.z));
			}else{
				Shoulders.transform.localEulerAngles = new Vector3(0, Mathf.LerpAngle(Shoulders.transform.localEulerAngles.y,Mathf.DeltaAngle(Hip.transform.localEulerAngles.y,Head.transform.localEulerAngles.y)/2,0.1f),0);
			}
			
			LeftHand.transform.localPosition =	   new Vector3(IdleRightHandPos.x *-1, (Mathf.Abs((CharHipMoveVer*-5)/ Mathf.Max( CharFemiminity,(10-CharGoofiness)) ) + IdleLeftHandPos.y),((CharHipMoveVer*(CharMasculinity*-0.6f))  + IdleRightHandPos.z));
			
			
			
			
			RightFoot.transform.localPosition = Vector3.Lerp(RightFoot.transform.localPosition, new Vector3( Mathf.Max(0,( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.03f)*CharFemiminity)+(0.2f-CharFemiminity/40) ,  Mathf.Max(0, Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.05f)*CharGoofiness,(CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude))*-2f*CharMoveMagnitude),0.3f);
			LeftFoot.transform.localPosition =  Vector3.Lerp(LeftFoot.transform.localPosition, new Vector3( Mathf.Min(0,( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.03f)*CharFemiminity )-(0.2f-CharFemiminity/40),  Mathf.Max(0, Mathf.Sin(Time.time *-4*CharMoveMagnitude)*0.05f)*CharGoofiness,(CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude))*2f*CharMoveMagnitude),0.3f);
			
			
			break;
			
		case MoveState.Run:
			
			CharMoveMagnitude =	Mathf.Round( (this.rigidbody.velocity.magnitude / directionSpeed)+2);
			
			CharHipMoveVer= CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude);//+0.75f-(CharHipVerMag/2);
			//print(((CharGoofiness*CharGoofiness)/100));
			Hip.transform.position =new Vector3(Hip.transform.position.x, (Mathf.Abs(CharHipMoveVer*(1+(CharGoofiness*CharGoofiness)/100)) + transform.position.y + IdleHipPos.y),Hip.transform.position.z);
			Hip.transform.localEulerAngles= new Vector3(  Mathf.Cos(Time.time *8*CharMoveMagnitude)*5 ,0,  CharHipMoveVer*10*(CharFemiminity)*(CharMoveMagnitude/2));
			
			
			CharHeadMoveVer= CharHipVerMag * Mathf.Cos((Time.time *4*CharMoveMagnitude)+(CharGoofiness/2));
			Head.transform.localPosition =new Vector3(Mathf.Cos(Time.time *4*CharMoveMagnitude)*0.02f, (Mathf.Abs(CharHeadMoveVer )  + IdleHeadPos.y),(((this.rigidbody.velocity.magnitude)*(this.rigidbody.velocity.magnitude))/(directionSpeed*directionSpeed))/3);
			
			
			if (Input.GetAxisRaw ("RightStickX") == 0 && Input.GetAxisRaw ("RightStickY") == 0) {
				Shoulders.transform.localPosition = new Vector3((Head.transform.localPosition.x + Hip.transform.localPosition.x)*0.5f,(Head.transform.localPosition.y + Hip.transform.localPosition.y)*0.51f,(Head.transform.localPosition.z + Hip.transform.localPosition.z)*0.5f);
				Shoulders.transform.localEulerAngles= new Vector3(  Mathf.Cos(Time.time *8*CharMoveMagnitude)*5 , (CharHipMoveVer*-22*(CharMasculinity)*(CharMoveMagnitude/2)),  CharHipMoveVer*-10*(CharMasculinity)*(CharMoveMagnitude/2));
				//Shoulders.transform.localRotation= Quaternion.LookRotation(new Vector3(  Mathf.Cos(Time.time *2*CharMoveMagnitude)*5 , (CharHipMoveVer*-1*(CharMasculinity)*(CharMoveMagnitude/2))+((this.GetComponent<CharContolerLogic_simple>().LookdirectionOut.y + Hip.transform.localEulerAngles.y)*0.5f),  CharHipMoveVer*-1*(CharMasculinity)*(CharMoveMagnitude/2)));
				
				
				RightHand.transform.localPosition =new Vector3(IdleRightHandPos.x, 	  (Mathf.Abs((CharHipMoveVer*5)/Mathf.Max( CharFemiminity,(10-CharGoofiness)))  + IdleRightHandPos.y),((CharHipMoveVer*(CharMasculinity*0.6f))  + IdleRightHandPos.z));
			}else{
				Shoulders.transform.localEulerAngles = new Vector3(0, Mathf.LerpAngle(Shoulders.transform.localEulerAngles.y,Mathf.DeltaAngle(Hip.transform.localEulerAngles.y,Head.transform.localEulerAngles.y)/2,0.1f),0);
			}
			
			LeftHand.transform.localPosition =	   new Vector3(IdleRightHandPos.x *-1, (Mathf.Abs((CharHipMoveVer*-5)/ Mathf.Max( CharFemiminity,(10-CharGoofiness)) ) + IdleLeftHandPos.y),((CharHipMoveVer*(CharMasculinity*-0.6f))  + IdleRightHandPos.z));
			
			
			
			
			RightFoot.transform.localPosition = Vector3.Lerp(RightFoot.transform.localPosition, new Vector3( Mathf.Max(0,( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.03f)*CharFemiminity)+(0.2f-CharFemiminity/40) ,  Mathf.Max(0, Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.05f)*CharGoofiness,(CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude))*-2f*CharMoveMagnitude),0.3f);
			LeftFoot.transform.localPosition =  Vector3.Lerp(LeftFoot.transform.localPosition, new Vector3( Mathf.Min(0,( Mathf.Sin(Time.time *-4*CharMoveMagnitude)*-0.03f)*CharFemiminity )-(0.2f-CharFemiminity/40),  Mathf.Max(0, Mathf.Sin(Time.time *-4*CharMoveMagnitude)*0.05f)*CharGoofiness,(CharHipVerMag * Mathf.Cos(Time.time *4*CharMoveMagnitude))*2f*CharMoveMagnitude),0.3f);
			
			break;
			
		case MoveState.FallUp:
			//print ("FallUp");
			
			//Debug.DrawRay(new Vector3(this.rigidbody.position.x,this.rigidbody.position.y+2.5f,this.rigidbody.position.z),(this.rigidbody.GetRelativePointVelocity(new Vector3(this.rigidbody.position.x,this.rigidbody.position.y,this.rigidbody.position.z))), Color.blue);
			
			Hip.transform.position =Vector3.Lerp(Hip.transform.position ,(new Vector3(Hip.transform.position.x, (transform.position.y + IdleHipPos.y + 0.1f),Hip.transform.position.z)),0.1f);
			Hip.transform.localEulerAngles= Vector3.Lerp(Hip.transform.localEulerAngles, new Vector3( this.rigidbody.velocity.magnitude * 4, 0, 0 ),5);
			
			Head.transform.localPosition = Vector3.Lerp(Head.transform.localPosition, new Vector3( IdleHeadPos.x, IdleHeadPos.y - 0.1f , IdleHeadPos.z ), 0.1f );
			
			if (Input.GetAxisRaw ("RightStickX") == 0 && Input.GetAxisRaw ("RightStickY") == 0) {
				Shoulders.transform.localPosition = Vector3.Lerp(Shoulders.transform.localPosition,IdleShouldersPos, 0.1f );
				Shoulders.transform.localEulerAngles = (Head.transform.localEulerAngles + Hip.transform.localEulerAngles)*0.5f;
				
				
				RightHand.transform.localPosition = Vector3.Lerp(RightHand.transform.localPosition,IdleRightHandPos, 0.1f );
			}else{
				Shoulders.transform.localEulerAngles = new Vector3(0, Mathf.LerpAngle(Shoulders.transform.localEulerAngles.y,Mathf.DeltaAngle(Hip.transform.localEulerAngles.y,Head.transform.localEulerAngles.y)/2,0.1f),0);
			}
			LeftHand.transform.localPosition = Vector3.Lerp(LeftHand.transform.localPosition,new Vector3(IdleRightHandPos.x*-1,IdleLeftHandPos.y,IdleRightHandPos.z), 0.1f );
			
			
			RightFoot.transform.localPosition = Vector3.Lerp(RightFoot.transform.localPosition, new Vector3(0.2f,-0.3f,(this.rigidbody.velocity.magnitude*-0.01f) + RightFoot.transform.localPosition.z),0.1f);
			LeftFoot.transform.localPosition =  Vector3.Lerp(LeftFoot.transform.localPosition, new Vector3(-0.2f,-0.3f,(this.rigidbody.velocity.magnitude*-0.01f) + LeftFoot.transform.localPosition.z),0.1f);
			
			break;
			
		case MoveState.FallDown:
			//print ("FallDown");
			Hip.transform.position =Vector3.Lerp(Hip.transform.position ,(new Vector3(Hip.transform.position.x, (transform.position.y + IdleHipPos.y - 0.1f),Hip.transform.position.z)),0.1f);
			
			Hip.transform.localEulerAngles= Vector3.Lerp(Hip.transform.localEulerAngles, new Vector3( this.rigidbody.velocity.magnitude * -2, 0, 0 ),1f );
			Head.transform.localPosition = Vector3.Lerp(Head.transform.localPosition, new Vector3( IdleHeadPos.x, IdleHeadPos.y + 0.1f , IdleHeadPos.z ), 0.1f );
			
			
			if (Input.GetAxisRaw ("RightStickX") == 0 && Input.GetAxisRaw ("RightStickY") == 0) {
				Shoulders.transform.localPosition = Vector3.Lerp(Shoulders.transform.localPosition,IdleShouldersPos, 0.1f );
				Shoulders.transform.localEulerAngles = (Head.transform.localEulerAngles + Hip.transform.localEulerAngles);
				
				RightHand.transform.localPosition = Vector3.Lerp(RightHand.transform.localPosition,new Vector3(IdleRightHandPos.x,IdleRightHandPos.y+1,IdleRightHandPos.z), 0.1f );
			}else{
				Shoulders.transform.localEulerAngles = new Vector3(0, Mathf.LerpAngle(Shoulders.transform.localEulerAngles.y,Mathf.DeltaAngle(Hip.transform.localEulerAngles.y,Head.transform.localEulerAngles.y)/2,0.1f),0);
			}
			LeftHand.transform.localPosition = Vector3.Lerp(LeftHand.transform.localPosition,new Vector3(IdleRightHandPos.x*-1,(IdleLeftHandPos.y)*-1,IdleRightHandPos.z), 0.04f );
			
			RightFoot.transform.localPosition = Vector3.Lerp(RightFoot.transform.localPosition, new Vector3(0.2f,-0.2f,this.rigidbody.velocity.magnitude * 0.04f),0.1f);
			LeftFoot.transform.localPosition =  Vector3.Lerp(LeftFoot.transform.localPosition, 	new Vector3(-0.2f,0.2f,this.rigidbody.velocity.magnitude * 0.01f),0.1f);
			
			break;
		}
		
		
		
		
		
	}
}
