using UnityEngine;
using System.Collections;

public class TestHMDRotation : MonoBehaviour {

	public GameObject hand;

	public Vector3 offset;

	Rigidbody rb;

	Vector3 direction;

	// Use this for initialization
	void Start () {
		//rb = gameObject.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {
		//transform.position = hand.transform.position + offset;
		//transform.position = hand.transform.position + transform.TransformDirection( offset );
		//transform.rotation = hand.transform.rotation;

		//direction = (hand.transform.position + offset ) - gameObject.transform.position;
		//rb.velocity = direction * 32;
		//rb.AddForce (direction);

		offset = transform.InverseTransformDirection (offset);
		Debug.DrawLine (transform.position, offset);

	}
}
