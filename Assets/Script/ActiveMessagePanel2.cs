using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel2 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;

	//表示させるメッセージ
	private string message = "久しぶりだなァ、スタック！"
		+"元気にしてたか？\n\n\n"
		+"誰だ？って…オイオイ俺だよ、キューだよ！\n"
		+"ちょっと前まで同室だっただろうがよォ！冷てェー！\n\n"
		+"まぁいい！　お前よく独房から出られたなぁ。\n"
		+"え？　たまたま鍵が開いてた？\n"
		+"とんだラッキーボーイだなァ！ ガハハハッ\n"
		+"てかスタック！　俺も助けてくれ！ 頼む！\n"
		+"この檻脆いから、なんか使えそうな道具とか持ってきてくれ！"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			messageScript.SetMessagePanel (message);
		}
	}

}
