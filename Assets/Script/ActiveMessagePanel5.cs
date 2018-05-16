using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel5 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;
	public GameObject time;
	public GameObject LastJailer;
	public GameObject Queue;
	public GameObject Tosenbo;
	public GameObject ED2Switch;

	//表示させるメッセージ
	private string message = "≪看守≫\n「お前ら、囚人だな？\nどうしてこんなところにいる。」\n"
		+"≪キュー≫\n「やっべ…！」\n\n"
		+"≪キュー≫\n「スタック、お前は先に行ってろ！\n俺があいつをボコボコにしといてやる。」\n"
		+"≪キュー≫\n「いいから走れ！　すぐに追いつく！」\n\n"
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player" ) {
			messageScript.SetMessagePanel (message);
			Destroy(time.gameObject);
			Destroy(this.gameObject);
			LastJailer.SetActive (true);
			Queue.SetActive (true);
			Tosenbo.SetActive (true);
			ED2Switch.SetActive (true);
		}
	}
}
