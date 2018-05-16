using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel21 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;

	//表示させるメッセージ
	private string message = 
		"≪キュー≫\n「なんかさ、使えそうな道具を見つけたら持ってきてくれ！」"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			messageScript.SetMessagePanel (message);
		}
	}

}
