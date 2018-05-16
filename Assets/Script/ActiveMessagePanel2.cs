﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel2 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;

	//表示させるメッセージ
	private string message = "≪？？？≫\n「久しぶりだなァ、スタック！」\n\n"
		+"≪？？？≫\n「元気にしてたか？」\n\n"
		+"≪キュー≫\n「誰だ？って…オイオイ俺だよ、キューだよ！\n"
		+"ちょっと前まで同室だっただろうが！冷てェー！」\n"
		+"≪キュー≫\n「まぁいい！　お前よく独房から出られたなぁ。\n"
		+"え？　たまたま鍵が開いてた？」\n"
		+"≪キュー≫\n「そいつはラッキーだったなァ！\n羨ましいぜ…。」\n"
		+"≪キュー≫\n「てかスタック！　自由に動けるんだったら、\n俺のことも助けてくれよ！」\n"
		+"≪キュー≫\n「この檻脆いから、\n頑張ればなんとかなりそうなんだ。使えそうな道具を見つけたら持ってきてくれ！」"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			messageScript.SetMessagePanel (message);
			Destroy(this.gameObject);
		}
	}

}
