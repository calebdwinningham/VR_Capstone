using UnityEngine;
using System.Collections;

public class MirrorObject : MonoBehaviour {

	public GameObject mirrorObject;

	public Vector3 mirrorAxis;

	public GameObject mirroredObject;

	Vector3 destination;
	Vector3 direction;

	Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (mirrorAxis.x > 0) {

			destination.x = mirrorObject.transform.position.x + (mirrorObject.transform.position.x - mirroredObject.transform.position.x);

		} else if (mirrorAxis.x < 0) {
			destination.x = -( mirrorObject.transform.position.x + (mirrorObject.transform.position.x - mirroredObject.transform.position.x) );
		}else {
			destination.x = mirroredObject.transform.position.x;
		}

		if (mirrorAxis.y > 0) {

			destination.y = mirrorObject.transform.position.y + (mirrorObject.transform.position.y - mirroredObject.transform.position.y);

		} else if (mirrorAxis.y < 0) {
			destination.y = -( mirrorObject.transform.position.y + (mirrorObject.transform.position.y - mirroredObject.transform.position.y) );
		}else {
			destination.y = mirroredObject.transform.position.y;
		}

		if (mirrorAxis.z > 0) {

			destination.z = mirrorObject.transform.position.z + (mirrorObject.transform.position.z - mirroredObject.transform.position.z);

		} else if (mirrorAxis.x < 0) {
			destination.z = -( mirrorObject.transform.position.z + (mirrorObject.transform.position.z - mirroredObject.transform.position.z) );
		}else {
			destination.z = mirroredObject.transform.position.z;
		}

		direction = destination - gameObject.transform.position;
		rb.velocity = direction * 32;
		//transform.position = destination;


	}
}
