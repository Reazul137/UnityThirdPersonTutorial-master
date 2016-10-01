using UnityEngine;
using System.Collections;

public class ItemActions : MonoBehaviour {

	public GameObject Blade;

	public ItemActioState itemActioState = ItemActioState.Idle;

	public enum ItemActioState
	{
		Idle,
		Activaded
	}
	// Use this for initialization
	void Start () {
	
	}

	public void Activate(){
		itemActioState =ItemActioState.Activaded;
	
	}
	// Update is called once per frame
	void Update () {

		switch (itemActioState) {
		case ItemActioState.Idle:
			

			break;

		case ItemActioState.Activaded:

			itemActioState =ItemActioState.Idle;
				
			break;
		}
	
	}
}
