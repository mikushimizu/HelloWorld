using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel6 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;

	//表示させるメッセージ
	private string message = "ED1:「南の島」"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player" ) {
			messageScript.SetMessagePanel (message);

		}
	}
}
