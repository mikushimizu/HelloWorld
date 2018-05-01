using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
	public float time = 60;
	public GameObject Lazer;
	// Use this for initialization
	void Start () {
		GetComponent<Text>().text = ((int)time).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		//1秒に1ずつ減らしていく
		time -= Time.deltaTime;
		//マイナスは表示しない
		if (time < 0) {
			time = 0;
		}
		GetComponent<Text> ().text = ((int)time).ToString ();

		if (time % 10 == 0.0f) {
			Lazer.SetActive (false);
		}else {
			Lazer.SetActive (true);
		}


	}
}
