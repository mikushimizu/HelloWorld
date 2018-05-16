using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	float speed = 5.0f;
	public Vector3 s_position;
	public GameObject JailDoor;
	public GameObject Switch1;
	public GameObject LaserGreen;
	public GameObject Switch2;
	public GameObject LaserPurple;
	public GameObject LaserPurple2;
	public GameObject Switch3;
	public GameObject LaserBlue;
	public GameObject Scop;
	public GameObject ScopIcon;
	public GameObject Card;
	public GameObject CardIcon;
	public GameObject ActiveMessagePanel21;
	public GameObject ActiveMessagePanel3;
	public GameObject ActiveMessagePanel4;
	public GameObject ActiveMessagePanel5;
	public GameObject ActiveMessagePanel6;
	public GameObject ED3;
	public GameObject ED2;
	public GameObject ED1;

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
		if (other.gameObject.tag == "JailDoor") {
			JailDoor.gameObject.SetActive(false);
		}
		if (other.gameObject.tag == "Laser") {
			SceneManager.LoadScene ("Gameover");
			this.transform.position = new Vector3 (s_position.x, s_position.y, s_position.z);
		}
		if (other.gameObject.tag == "Switch1") {
			Switch1.gameObject.SetActive(false);
			LaserGreen.gameObject.SetActive(false);
		}
		if (other.gameObject.tag == "Switch2") {
			Switch2.gameObject.SetActive(false);
			LaserPurple.gameObject.SetActive(false);
			LaserPurple2.gameObject.SetActive(false);
		}
		if (other.gameObject.tag == "Switch3") {
			Switch3.gameObject.SetActive(false);
			LaserBlue.gameObject.SetActive(false);
		}
		if (other.gameObject.tag == "Jailer") {
			SceneManager.LoadScene ("Gameover");
			this.transform.position = new Vector3 (s_position.x, s_position.y, s_position.z);
		}
		if (other.gameObject.tag == "GetScop") {
			Scop.gameObject.SetActive(false);
			ScopIcon.SetActive(true);
			ActiveMessagePanel21.SetActive(false);
			ActiveMessagePanel3.SetActive(true);
			ActiveMessagePanel4.SetActive(true);
		}
		if (other.gameObject.tag == "GetCard") {
			Card.gameObject.SetActive(false);
			CardIcon.SetActive(true);
			ActiveMessagePanel5.SetActive(false);
			ActiveMessagePanel6.SetActive(true);
		}

		if (other.gameObject.tag == "ED3Switch") {
			ED3.SetActive(true);
		}
		if (other.gameObject.tag == "ED2Switch") {
			ED2.SetActive(true);
		}
		if (other.gameObject.tag == "ED1Switch") {
			ED1.SetActive(true);
		}

	}




}
