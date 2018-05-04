using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Player"){
			//衝突した場所を取得
			GameObject.Find("Player").GetComponent<PlayerController>().s_position.x = transform.position.x;
			GameObject.Find("Player").GetComponent<PlayerController>().s_position.z = transform.position.z;
			Debug.Log ("xは" + transform.position.x + ", zは" + transform.position.z);
		}
	}
}
