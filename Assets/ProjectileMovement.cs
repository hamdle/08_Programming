using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour {

	public Vector3 newPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	public void UpdatePosition()
	{
		Transform trans = GetComponent<Transform>();
		trans.position = newPosition;
	}

	// Update is called once per frame
	void Update () {
		UpdatePosition();
	}
}
