using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveMessagePanel3 : MonoBehaviour {
	//MessageUIに設定されているMessageスクリプトを設定
	[SerializeField]
	private MessageScript messageScript;
	public GameObject QueueJail;
	public GameObject Queue;
	public GameObject ScopIcon;
	public GameObject QueueIcon;
	public GameObject ActiveMessagePanel4;
	public GameObject ActiveMessagePanel5;

	//表示させるメッセージ
	private string message = "サンキュー、スタック！\n"
		+"さぁ、一緒にこんなとこ出ちまおうぜ！\n\n"
		+" キューが仲間になった "
		;

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Player") {
			messageScript.SetMessagePanel (message);
			Destroy(this.gameObject);
			Destroy(QueueJail);
			Destroy(Queue);
			ScopIcon.SetActive(false);
			QueueIcon.SetActive(true);
			ActiveMessagePanel4.SetActive(false);
			ActiveMessagePanel5.SetActive(true);
		}
	}

}
