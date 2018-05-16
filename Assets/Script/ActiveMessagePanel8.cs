using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel8 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;

	//表示させるメッセージ
	private string message = "≪キュー≫\n「スタック、スタック！」\n\n" 
		+"≪キュー≫\n「この先、また看守がうろついてやがるぜ…！\n気を付けて行くぞ！」\n"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player" ) {
			messageScript.SetMessagePanel (message);
			Destroy(this.gameObject);
		}
	}
}
