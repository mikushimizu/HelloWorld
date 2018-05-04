using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	float speed = 5.0f;
	public Vector3 s_position;
	public GameObject Switch1;
	public GameObject LaserGreen;

	// Use this for initialization
	void Start () {
		s_position = new Vector3(transform.position.x, transform.position.y, transform.position.z );
	}

	// Update is called once per frame
	void Update () {
		if ( this.transform.position.y <= -10) {
			this.transform.position = new Vector3 (0, 18.5f, 0);
		}

		if (Input.GetKey ("up")) {
			transform.position += new Vector3 (0, 0, speed * Time.deltaTime);
		}
		if (Input.GetKey ("down")) {
			transform.position += new Vector3 (0, 0, -speed * Time.deltaTime);
		}
		if (Input.GetKey ("left")) {
			transform.position += new Vector3 (-speed * Time.deltaTime,0,0);
		}
		if (Input.GetKey ("right")) {
			transform.position += new Vector3 (speed * Time.deltaTime,0,0);
		}
		
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Laser") {
			SceneManager.LoadScene ("Gameover");
			this.transform.position = new Vector3 (s_position.x, s_position.y, s_position.z);
		}
		if (other.gameObject.tag == "Switch1") {
			Switch1.gameObject.SetActive(false);
			LaserGreen.gameObject.SetActive(false);
		}
	}




}
