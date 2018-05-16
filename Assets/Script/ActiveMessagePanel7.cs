using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel7 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;

	//表示させるメッセージ
	private string message = "≪キュー≫\n「おい、スタック！」\n\n" 
		+"≪キュー≫\n「この先、看守がうろついてやがるぜ…！\n見つからないように気を付けて行くぞ！」\n"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player" ) {
			messageScript.SetMessagePanel (message);
			Destroy(this.gameObject);
		}
	}
}
