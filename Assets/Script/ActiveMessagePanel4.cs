using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ActiveMessagePanel4 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;
	public GameObject time;
	public GameObject LastJailer;
	public GameObject Tosenbo;
	public GameObject ED3Switch;

	//表示させるメッセージ
	private string message = "≪看守≫\n「お前、囚人だな？\nどうしてこんなところにいる。」\n"
		+"≪看守≫\n「今すぐそのスコップを床に置いて、\n両手を上げろ！」\n"
		+"…\n\n\n"
		+"≪看守≫\n「なにやってんだ早くしろ！」\n\n"
		+"…\n\n\n"
		+"≪看守≫\n「ふざけるな、逃げられるとでも思っているのか？\nお前は一生牢屋から出られない。」\n"
		+"≪看守≫\n「罪人なんかに自由になる権利はないんだよ。」\n\n"
		+"≪看守≫\n「言うことをきかないと…\nわかってんだろうなぁ！」\n"
		+"≪看守≫\n「ま、待て、お、お、落ち着け！\nスコップを降ろせ！やめっ…」\n"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			messageScript.SetMessagePanel (message);
			Destroy(this.gameObject);
			Destroy(time.gameObject);
			LastJailer.SetActive (true);
			Tosenbo.SetActive (true);
			ED3Switch.SetActive (true);
		}
	}
}
