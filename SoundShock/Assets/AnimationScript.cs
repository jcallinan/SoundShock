using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour {
	Animation anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animation> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.D)) {
			anim.Play ("player_boneset|Player_runR_loop");
			if (Input.GetKeyUp (KeyCode.D)) {
				anim.Stop ("player_boneset|Player_runR_loop");
			}
		} else if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.Space)) {
		//	anim.Play ("player_boneset|Player_jumping_phase 2");
		} else if (Input.GetKeyDown (KeyCode.A)) {
			anim.Play ("player_boneset|Player_runR_loop");
		} else if (Input.GetMouseButtonDown (0) || Input.GetMouseButtonDown (1) || Input.GetMouseButtonDown (2)) {
			anim.Play ("player_boneset|Player_FireWeap");
		}


	}
}
