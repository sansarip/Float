using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public float zVal;

	// Use this for initialization
	void Start () {
		transform.position = Plane.position;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 newPos = Plane.position;
		newPos.z = zVal;;
		transform.position = newPos;
	}
}
