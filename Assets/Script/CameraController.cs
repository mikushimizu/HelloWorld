using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject target;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position + new Vector3 (0, 5.7f, -2.9f);
		//transform.rotation = target.transform.rotation + new Vector3 (62, 0, 0);

	}
}
