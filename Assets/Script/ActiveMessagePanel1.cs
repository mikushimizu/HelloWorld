using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel1 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;

	//表示させるメッセージ
	private string message = "≪？？？≫\n「おい、スタック！」\n\n"
		+"≪？？？≫\n「こっちだこっち！　檻ん中！」";

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			messageScript.SetMessagePanel (message);
			Destroy(this.gameObject);
		}
	}

}
