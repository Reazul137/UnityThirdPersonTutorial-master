using UnityEngine;
using System.Collections;

public class CharItemControlerLogic : MonoBehaviour {


	private float rigthX = 0f;
	private float rigthY = 0f;
	// Use this for initialization

	public GameObject CharRightHand;
	public GameObject Item01;
	public GameObject Item02;
	public GameObject Item03;
	public GameObject Item04;

	public GameObject ItemHolder01;
	public GameObject ItemHolder02;
	public GameObject ItemHolder03;
	public GameObject ItemHolder04;

	private ItemState itemState = ItemState.Item01;


	private Quaternion ItemLookdirection;
	private float ItemLookIntensity;
	private Vector3 CharRightHandIdlePos;
	private Quaternion CharRightHandIdleRot;

	public enum ItemState
	{
		noItem,		
		Item01,
		Item02,
		Item03,
		Item04
	}	
	

	void Start () {

		CharRightHandIdlePos = CharRightHand.transform.localPosition;
		CharRightHandIdleRot = CharRightHand.transform.localRotation;
		Physics.IgnoreCollision (Item01.GetComponentInChildren<Collider> (), this.GetComponent<Collider> ());
	}



	void Update () {



		if (Input.GetButton ("Item1")) {
			if (itemState == ItemState.Item01) {
				//print ("Item1_Atack");
				ItemActions Item1Actions = Item01.GetComponent<ItemActions> ();
				Item1Actions.Activate();

			}else{
				itemState = ItemState.Item01;
			}
		}
		if (Input.GetButton ("Item2")) {
			if (itemState == ItemState.Item02) {
				//print ("Item2_Atack");
			} else {
				itemState = ItemState.Item02;
			}
		}
		if (Input.GetAxisRaw ("Item3")>0.7) {
			if (itemState == ItemState.Item03) {
				//print ("Item3_Atack");
			} else {
				itemState = ItemState.Item03;
			}
		}
		if (Input.GetAxisRaw ("Item3")<-0.7) {
			if (itemState == ItemState.Item04) {
				//print ("Item4_Atack");
			} else {
				itemState = ItemState.Item04;
			}
		}



		ItemLookdirection =  this.GetComponent<CharContolerLogic_simple>().Head.transform.rotation;
		ItemLookIntensity=  this.GetComponent<CharContolerLogic_simple>().LookdirectionOut.magnitude ;

		rigthX = Input.GetAxisRaw ("RightStickX");
		rigthY = Input.GetAxisRaw ("RightStickY");

//		print ( "_Item01"+Item01.transform.localRotation+"_Item02"+Item01.transform.localRotation+"_Item03"+Item01.transform.localRotation+"_Item04"+Item01.transform.localRotation);


		//---
		switch (itemState)
		{
		case ItemState.Item01:
			//-
			Item01.transform.parent = CharRightHand.transform;
			Item01.transform.localPosition = Vector3.zero;
			Item01.transform.localRotation = new Quaternion(0,0,0,0);
			Item01.transform.localScale = Vector3.one;
			Item01.GetComponentInChildren<Rigidbody>().detectCollisions=true;


			//-
			
			Item02.transform.parent = ItemHolder02.transform;
			Item02.transform.localPosition = Vector3.zero;
			Item02.transform.localRotation = new Quaternion(0,0,0,0);
			Item02.transform.localScale = Vector3.one;
			Item02.GetComponentInChildren<Rigidbody>().detectCollisions=false;

			
			Item03.transform.parent = ItemHolder03.transform;
			Item03.transform.localPosition = Vector3.zero;
			Item03.transform.localRotation = new Quaternion(0,0,0,0);
			Item03.transform.localScale = Vector3.one;
			Item03.GetComponentInChildren<Rigidbody>().detectCollisions=false;
			
			Item04.transform.parent = ItemHolder04.transform;
			Item04.transform.localPosition = Vector3.zero;
			Item04.transform.localRotation = new Quaternion(0,0,0,0);
			Item04.transform.localScale = Vector3.one;
			Item04.GetComponentInChildren<Rigidbody>().detectCollisions=false;
			
			CharRightHandIdleRot = new Quaternion(-0.4f,0,0,1);
		break;

		case ItemState.Item02:
			
			Item01.transform.parent = ItemHolder01.transform;
			Item01.transform.localPosition = Vector3.zero;
			Item01.transform.localRotation = new Quaternion(0,0,0,0);
			Item01.transform.localScale = Vector3.one;
			Item01.GetComponentInChildren<Rigidbody>().detectCollisions=false;

			//-
			Item02.transform.parent = CharRightHand.transform;
			Item02.transform.localPosition = Vector3.zero;
			Item02.transform.localRotation = new Quaternion(0,0,0,0);
			Item02.transform.localScale = Vector3.one;
			Item02.GetComponentInChildren<Rigidbody>().detectCollisions=true;
			//-
			
			Item03.transform.parent = ItemHolder03.transform;
			Item03.transform.localPosition = Vector3.zero;
			Item03.transform.localRotation = new Quaternion(0,0,0,0);
			Item03.transform.localScale = Vector3.one;
			Item03.GetComponentInChildren<Rigidbody>().detectCollisions=false;
			
			Item04.transform.parent = ItemHolder04.transform;
			Item04.transform.localPosition = Vector3.zero;
			Item04.transform.localRotation = new Quaternion(0,0,0,0);
			Item04.transform.localScale = Vector3.one;
			Item04.GetComponentInChildren<Rigidbody>().detectCollisions=false;
				
			CharRightHandIdleRot = new Quaternion(0.4f,0,0,1);
		break;

		case ItemState.Item03:
					
			Item01.transform.parent = ItemHolder01.transform;
			Item01.transform.localPosition = Vector3.zero;
			Item01.transform.localRotation = new Quaternion(0,0,0,0);
			Item01.transform.localScale = Vector3.one;
			Item01.GetComponentInChildren<Rigidbody>().detectCollisions=false;
			
			Item02.transform.parent = ItemHolder02.transform;
			Item02.transform.localPosition = Vector3.zero;
			Item02.transform.localRotation = new Quaternion(0,0,0,0);
			Item02.transform.localScale = Vector3.one;
			Item02.GetComponentInChildren<Rigidbody>().detectCollisions=false;
			
			//-
			Item03.transform.parent = CharRightHand.transform;
			Item03.transform.localPosition = Vector3.zero;
			Item03.transform.localRotation = new Quaternion(0,0,0,0);
			Item03.transform.localScale = Vector3.one;
			Item03.GetComponentInChildren<Rigidbody>().detectCollisions=true;
			//-
			
			Item04.transform.parent = ItemHolder04.transform;
			Item04.transform.localPosition = Vector3.zero;
			Item04.transform.localRotation = new Quaternion(0,0,0,0);
			Item04.transform.localScale = Vector3.one;
			Item04.GetComponentInChildren<Rigidbody>().detectCollisions=false;
			
			CharRightHandIdleRot = new Quaternion(0.7f,0.7f,0.7f,0.7f);
		break;	
		
		case ItemState.Item04:
			
			
			Item01.transform.parent = ItemHolder01.transform;
			Item01.transform.localPosition = Vector3.zero;
			Item01.transform.localRotation = new Quaternion(0,0,0,0);
			Item01.transform.localScale = Vector3.one;
			Item01.GetComponentInChildren<Rigidbody>().detectCollisions=false;
			
			Item02.transform.parent = ItemHolder02.transform;
			Item02.transform.localPosition = Vector3.zero;
			Item02.transform.localRotation = new Quaternion(0,0,0,0);
			Item02.transform.localScale = Vector3.one;
			Item02.GetComponentInChildren<Rigidbody>().detectCollisions=false;

			Item03.transform.parent = ItemHolder03.transform;
			Item03.transform.localPosition = Vector3.zero;
			Item03.transform.localRotation = new Quaternion(0,0,0,0);
			Item03.transform.localScale = Vector3.one;
			Item03.GetComponentInChildren<Rigidbody>().detectCollisions=false;
			
			//-
			Item04.transform.parent = CharRightHand.transform;
			Item04.transform.localPosition = Vector3.zero;
			Item04.transform.localRotation = new Quaternion(0,0,0,0);
			Item04.transform.localScale = Vector3.one;
			Item04.GetComponentInChildren<Rigidbody>().detectCollisions=true;
			//-
						
			CharRightHandIdleRot = new Quaternion(-0.3f,0,0,1);
		break;
		}

		//---

		if (rigthY == 0 && rigthX == 0) {

			CharRightHand.transform.parent =  this.transform;

		//	CharRightHand.transform.localPosition = Vector3.Lerp(CharRightHand.transform.localPosition,CharRightHandIdlePos, 1f );
			CharRightHand.transform.localRotation = Quaternion.Slerp(CharRightHand.transform.rotation, CharRightHandIdleRot, 1f);
				
		} else {

			CharRightHand.transform.parent =  this.GetComponent<CharContolerLogic_simple>().Head.transform;

			//print (Mathf.Min(1,ItemLookIntensity));
			CharRightHand.transform.localPosition = new Vector3((1-ItemLookIntensity)*0.3f,(-0.05f- CharRightHandIdlePos.y +(ItemLookIntensity*0.05f)), Mathf.Min(1,(ItemLookIntensity)+0.5f));

			CharRightHand.transform.rotation = Quaternion.Slerp( CharRightHand.transform.rotation,ItemLookdirection, 0.3f);


	
			
		}
		


	}
}