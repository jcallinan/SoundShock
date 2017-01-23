using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueWaveScript : MonoBehaviour {

	public float MoveSpeed = 5.0f;

	public float frequency = 20.0f;

	public float magnitude = 0.5f;

	public Vector3 axis;
	public Vector3 pos;
	public Rigidbody2D rb2d;
	public GameObject Player;
	// Use this for initialization
	void Start () {
		pos = transform.position;
		DestroyObject (this, 500f);
		axis = transform.up;
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {
		pos += transform.right * Time.deltaTime * MoveSpeed;
		transform.position = pos + axis * Mathf.Sin (Time.time * frequency) * magnitude;

		if (transform.position.x > Player.transform.position.x + 25 || transform.position.x < Player.transform.position.x - 25) {
			Destroy (this.gameObject);
		}
	}

	void FixedUpdate() {
		

	}

	public void FireBlueWave() {
		rb2d = GetComponent<Rigidbody2D> ();
		pos.x = 1;
		rb2d.AddForce (pos * 800);
	}
}
