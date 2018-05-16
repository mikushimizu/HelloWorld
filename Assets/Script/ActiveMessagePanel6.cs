	using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel6 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;
	public GameObject time;

	//表示させるメッセージ
	private string message = "≪科学者≫\n「リタイアカードを承りました。\nお疲れ様です。」\n"
		+"≪キュー≫\n「やったな、スタック！」\n\n" 
		+"≪キュー≫\n「俺たちやっとこんなクソバイトから\n解放されるぜ！」\n"
		+"≪キュー≫\n「どうしたんだ？ポカンとして…」\n\n"
		+"≪キュー≫\n「俺たち心理学の実験の被験者だろ？」\n\n"
		+"≪キュー≫\n「一般人を囚人と看守のグループに分けて、\nどんな行動をとるか観察するっていう…。」\n"
		+"≪キュー≫\n「まさかお前、本気で、\n自分が囚人だと思い込んでたのか…？」\n"
		+"≪キュー≫\n「そんなわけないだろ！」\n\n"

		+"ED1:「南の島」"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player" ) {
			messageScript.SetMessagePanel (message);
			Destroy(time.gameObject);
		}
	}
}
