using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour {


	public GameObject RedWavePrefab;
	public GameObject YellowWavePrefab;
	public GameObject BlueWavePrefab;
	public YellowWaveScript scriptYellowWavePrefabScript;
	public RedWaveScript scriptRedWavePrefabScript;
	public BlueWaveScript scriptBlueWavePrefabScript;
	// Use this for initialization
	void Start () {
		//RedWaveFireTest();
		//YellowWaveFireTest ();
		//BlueWaveFireTest ();




	}
	// Update is called once per frame
	void Update () {
		BlueWavePrefab.transform.position = transform.position;
		if (Input.GetMouseButtonDown (0) == true) {
			RedWaveFireTest ();
		}
		if (Input.GetMouseButtonDown (1) == true) {
			BlueWaveFireTest ();
		}
		if (Input.GetMouseButtonDown (2) == true) {
			YellowWaveFireTest ();
		}
	


	}

	public void YellowWaveFireTest() {
		GameObject YellowWave = Instantiate(YellowWavePrefab) as GameObject;

		scriptYellowWavePrefabScript = YellowWave.GetComponent<YellowWaveScript> ();
		scriptYellowWavePrefabScript.FireYellowWave(550);

		GameObject YellowWave2 = Instantiate(YellowWavePrefab) as GameObject;
	
		scriptYellowWavePrefabScript = YellowWave2.GetComponent<YellowWaveScript> ();
		scriptYellowWavePrefabScript.FireYellowWave (500);
		scriptYellowWavePrefabScript.ReduceScale (1.4);

		GameObject YellowWave3 = Instantiate (YellowWavePrefab) as GameObject;

		scriptYellowWavePrefabScript = YellowWave3.GetComponent<YellowWaveScript> ();
		scriptYellowWavePrefabScript.FireYellowWave (450);
		scriptYellowWavePrefabScript.ReduceScale (1.8);
	}

	public void RedWaveFireTest() {
		GameObject RedWave = Instantiate (RedWavePrefab) as GameObject;
		RedWave.transform.position = transform.position;
		scriptRedWavePrefabScript = RedWave.GetComponent<RedWaveScript> ();
		scriptRedWavePrefabScript.FireRedWave ();
	}

	public void BlueWaveFireTest() {
		GameObject BlueWave = Instantiate (BlueWavePrefab) as GameObject;

		scriptBlueWavePrefabScript = BlueWave.GetComponent<BlueWaveScript>();
		scriptBlueWavePrefabScript.FireBlueWave ();
	}


}
