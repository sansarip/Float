using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {
	Rigidbody2D rigidBody2D;
	float index;
	public float ampY;
	public float speed;
	public static Vector3 position;

	// Use this for initialization
	void Start () {
		rigidBody2D = this.gameObject.GetComponent<Rigidbody2D> ();
		index = 0;
		rigidBody2D.AddForce (new Vector2 (speed, 0));
	}
	
	// Update is called once per frame
	void Update () {
		index += Time.deltaTime;
		position = transform.position;
		rigidBody2D.position = new Vector2(position.x, ampY * Mathf.Cos (2*index));
	}
}
