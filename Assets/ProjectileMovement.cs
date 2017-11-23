using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

	public float force = 5f;
	bool hasAlreadyLaunched = false;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void FixedUpdate () {
		if (!hasAlreadyLaunched)
		{
			Rigidbody rb = GetComponent<Rigidbody>();
			rb.AddForce(new Vector3(0, 0, force), ForceMode.Impulse);
			hasAlreadyLaunched = true;
		}
	}
}
