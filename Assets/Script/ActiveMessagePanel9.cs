using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel9 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;

	//表示させるメッセージ
	private string message = "≪キュー≫\n「なぁスタック、せっかく脱出できるってのに、\nなんでそんな辛気臭い顔してんだ？」\n"
		+"≪キュー≫\n「え？…罪人なのに\n外に出て行っていいのかって…？」\n"
		+"≪キュー≫\n「いいに決まってんだろアホか！\n外に出てやりたいこととかねぇの！？」\n"
		+"≪キュー≫\n「おいおい、ずっと牢獄に入ってたせいで、\n頭おかしくなっちまったのか～？」\n"
		+"≪キュー≫\n「あー…なんだよ…\nすげー元気ねぇじゃん…大丈夫かよ…」\n"
		+"≪キュー≫\n「あー……あーっと…………そうだ！\nここを出たらさ、南の島にでも行こうぜ！」\n"
		+"≪キュー≫\n「海とかみながらよー、ウマい飯食ってー、\nきっとすげー楽しいぜ！」\n"
		+"≪キュー≫\n「だからスタック、元気出せ！」\n\n"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player" ) {
			messageScript.SetMessagePanel (message);
			Destroy(this.gameObject);
		}
	}
}
