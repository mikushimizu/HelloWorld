using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel4 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;


	//表示させるメッセージ
	private string message = "ED3:「殺人犯」"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player" ) {
			messageScript.SetMessagePanel (message);

		}
	}
}
