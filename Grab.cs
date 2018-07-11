using UnityEngine;
using System.Collections;

public class Grab : MonoBehaviour {

	bool grabbed = false;
	GameObject hand;

	Vector3 direction;

	public GameObject controller1;
	public GameObject controller2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		
		if (grabbed) {
			direction = hand.transform.position - transform.position;
			//gameObject.GetComponent<Rigidbody> ().velocity = direction * 32;
			gameObject.GetComponent<Rigidbody>().AddForce( direction * 1000);
			Debug.Log ("Moving to hand");
		}

		if ( !controller1.GetComponent<SteamVR_TrackedController>().triggerPressed && !controller2.GetComponent<SteamVR_TrackedController>().triggerPressed ) {
			grabbed = false;
		}

		if (controller1.GetComponent<SteamVR_TrackedController>().triggerPressed || controller2.GetComponent<SteamVR_TrackedController>().triggerPressed) {
			Debug.Log ("A trigger was pressed");
		}

		Debug.Log (grabbed);
	
	}

	void OnTriggerStay( Collider collider ) {

		Debug.Log ("Something entered the trigger");

		if (controller1.GetComponent<SteamVR_TrackedController>().triggerPressed || controller2.GetComponent<SteamVR_TrackedController>().triggerPressed) {
			Debug.Log ("A trigger was pressed while inside the collision trigger");
		}

		if (collider.gameObject.name == "Hand" && (controller1.GetComponent<SteamVR_TrackedController>().triggerPressed || controller2.GetComponent<SteamVR_TrackedController>().triggerPressed)) {
			grabbed = true;
			hand = collider.gameObject;
			Debug.Log ("Grabbed");
		}

	}


}
