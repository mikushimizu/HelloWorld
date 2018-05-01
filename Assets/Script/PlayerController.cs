using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	float speed = 5.0f;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		if ( this.transform.position.y <= -10) {
			this.transform.position = new Vector3 (0, 18.5f, 0);
			Debug.Log ("Fall");
		}

		if (Input.GetKey ("up")) {
			transform.position += new Vector3 (0, 0, speed * Time.deltaTime);
			Debug.Log ("Go");
		}
		if (Input.GetKey ("down")) {
			transform.position += new Vector3 (0, 0, -speed * Time.deltaTime);
			Debug.Log ("Back");
		}
		if (Input.GetKey ("left")) {
			transform.position += new Vector3 (-speed * Time.deltaTime,0,0);
			Debug.Log ("left");
		}
		if (Input.GetKey ("right")) {
			transform.position += new Vector3 (speed * Time.deltaTime,0,0);
			Debug.Log ("right");
		}
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Lazer") {
			SceneManager.LoadScene ("Gameover");
		}
	}



}
