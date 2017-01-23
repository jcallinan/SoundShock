using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedWaveScript : MonoBehaviour {

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
		DestroyObject (this, 35f);
		axis = transform.up;
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	// Update is called once per frame
	void Update () {


		Vector3 playerPos = Player.transform.position;
		pos += transform.right * Time.deltaTime * MoveSpeed;
		transform.position = pos + axis * Mathf.Sin (Time.time * frequency) * magnitude;


		if (pos.x > Player.transform.position.x + 35 || pos.x < Player.transform.position.x - 35) {
			Destroy (this.gameObject);
		}
	}
	void FixedUpdate() {

	

	}
	public void FireRedWave() {
		rb2d = GetComponent<Rigidbody2D> ();
		Vector2 pos = transform.position;
		pos.x = 1;
		rb2d.AddForce (pos * 800);

	
	}

}



