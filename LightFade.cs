using UnityEngine;
using System.Collections;

public class LightFade : MonoBehaviour {

	Light lightComp;

	float fadeRate = 0.3f;

	AudioSource hitSound;

	public float desiredPitch = 1;

	// Use this for initialization
	void Start () {

		lightComp = gameObject.GetComponent<Light> ();

		hitSound = gameObject.GetComponent<AudioSource> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (lightComp.intensity > 0) {
			lightComp.intensity -= fadeRate * Time.deltaTime;
		}
	}

	void OnCollisionEnter( Collision collision ) {
		lightComp.intensity = 1f;

		hitSound.pitch = desiredPitch;
		hitSound.Play ();
	}
}
