using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other) {
		GameObject collidedWith = other.gameObject;
		if (this.tag == "CountryEnemyTag") {
			if (collidedWith.tag == "RedWaveTag") {
				Destroy (this.gameObject);
				Destroy (collidedWith);

			}
		}
		if (this.tag == "Hip-HopEnemyTag") {
			if (collidedWith.tag == "BlueWaveTag") {
				Destroy (this.gameObject);
				Destroy (collidedWith);
			}
		}
		if (this.tag == "RockEnemyTag") {
			if (collidedWith.tag == "YellowWaveTag") {
				Destroy (this.gameObject);
				Destroy (collidedWith);
			}
		}



	}
}
