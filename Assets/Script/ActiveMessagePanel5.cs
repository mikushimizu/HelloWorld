using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel5 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;

	//表示させるメッセージ
	private string message = "≪看守≫\n「お前ら、囚人だな？\nどうしてこんなところにいる。」\n"
		+"≪キュー≫\n「やっべ…！」\n\n"
		+"≪キュー≫\n「スタック、お前は先に行ってろ！\n俺があいつをボコボコにしといてやる。」\n"
		+"≪キュー≫\n「いいから走れ！　すぐに追いつく！」\n\n"
		+"スタックは無我夢中で走った。\n汗が目に入っても、息が死ぬほど苦しくなっても、\nとにかく走った。\n"
		+"一瞬、後ろから銃声が聞こえた気がした。\nだがそれを見るのがあまりに恐ろしかったスタックは、振り返ることはできなかった。\n\n"
		+"彼は逃げ切ったあともずっと、\n牢獄で出会った友人を見捨てて逃げた後悔と、\n捕まって再び投獄される恐怖に苛まれていた。\n"
		+"彼はなにか大切なことを忘れている気がしたが、\nそれが一体何なのか、\n思い出すことはできなかった…。\n"
		+"ED2:「逃亡」"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player" ) {
			messageScript.SetMessagePanel (message);

		}
	}
}
