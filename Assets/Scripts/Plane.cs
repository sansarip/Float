using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {
	Rigidbody2D rigidBody2D;
	float index;
	float ampY;

	// Use this for initialization
	void Start () {
		rigidBody2D = this.gameObject.GetComponent<Rigidbody2D> ();
		index = 0;
		ampY = 0.25f;
		rigidBody2D.AddForce (new Vector2 (100, 0));
	}
	
	// Update is called once per frame
	void Update () {
		index += Time.deltaTime;
		Vector2 position = rigidBody2D.position;
		rigidBody2D.position = new Vector2(position.x, ampY * Mathf.Cos (2*index));
	}
}
