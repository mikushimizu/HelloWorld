using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel5 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;

	//表示させるメッセージ
	private string message = "ED2:「逃亡」"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player" ) {
			messageScript.SetMessagePanel (message);

		}
	}
}
