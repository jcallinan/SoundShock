using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YellowWaveScript : MonoBehaviour {

	// Use this for initialization
	Rigidbody2D rb2d;
	Vector2 startPos;
	Vector2 pos;
	void Start () {
		startPos = transform.position;
		pos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {


		if (pos.x > startPos.x + 35 || pos.x < startPos.x - 35) {
			Destroy (this.gameObject);
		}
	}
	public void FireYellowWave(float velocity) {
		rb2d = GetComponent<Rigidbody2D> ();
		pos.x = 1;
		rb2d.AddForce (pos * velocity);




	}
	public void ReduceScale(double scaleDivider) {
		scaleDivider = (float) scaleDivider;
		Vector2 scale = transform.localScale;
		scale.x = transform.localScale.x / (float) scaleDivider;
		scale.y = transform.localScale.y / (float) scaleDivider;
		transform.localScale = scale;

	}

}
