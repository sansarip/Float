using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {
	Rigidbody2D rigidBody2D;
	float index;
	public float ampY;
	public float speed;
	public float wobble;
	public float frequency;
	public static Vector3 position;
	private float bounceTimer;

	// Use this for initialization
	void Start () {
		rigidBody2D = this.gameObject.GetComponent<Rigidbody2D> ();
		index = 0;
		rigidBody2D.AddForce (new Vector2 (speed, 0));
		bounceTimer = 0;
		//InvokeRepeating ("addWobble", 0, frequency);
	}

	// Update is called once per frame
	void Update () {
		index += Time.deltaTime;
		if (bounceTimer > 0) {
			if (bounceTimer == 2 * ampY) {
				index = 0;
			}
			bounceTimer -= Time.deltaTime;
			rigidBody2D.position = new Vector2 (transform.position.x, 2 * ampY * Mathf.Sin (2 * index));
		} else {
			rigidBody2D.position = new Vector2 (transform.position.x, ampY * Mathf.Sin (2 * index));
		}
	}

	void OnMouseUp() {
		rigidBody2D.position = new Vector2(position.x, ampY * 2 * Mathf.Sin (2*index));
		bounceTimer = 2 * ampY;
	}

	private void addWobble() {
		print ("Wobble: " + wobble);
		rigidBody2D.AddForce (new Vector2 (0, wobble));
	}
}
