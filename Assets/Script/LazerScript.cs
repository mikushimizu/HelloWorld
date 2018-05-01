using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine ("Lazer");
	}
	
	// Update is called once per frame
	void Update () {

	}

	private IEnumerator Lazer(){
		while (true) {
			yield return new WaitForSeconds (3.0f);
			gameObject.SetActive (false);
			yield return new WaitForSeconds (3.0f);
			gameObject.SetActive (true);
		}
	}
}
