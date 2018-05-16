using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMoveController : MonoBehaviour {

	// PUBLIC
	public SimpleTouchController leftController;
	public SimpleTouchController rightController;
	public Transform headTrans;
	public float speed = 5f;
	public float speedContinuousLook = 100f;
	public float speedProgressiveLook = 3000f;
	public GameObject Message;
	// PRIVATE
	private Rigidbody _rigidbody;
	[SerializeField] bool continuousRightController = true;

	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}

	public bool ContinuousRightController
	{
		set{continuousRightController = value;}
	}


	void Update()
	{
		// move
		if (Message.activeSelf) {
			speed = 0;
		}else{
			speed = 10f;
		}
			_rigidbody.velocity = new Vector3 (leftController.GetTouchPosition.x, 0, leftController.GetTouchPosition.y) * speed;


		// スティックの倒れた向きを向く
		var v2 = leftController.GetTouchPosition.y;
		var h2 = leftController.GetTouchPosition.x;
		Vector3 direction = new Vector3(h2,0,v2);
		transform.localRotation = Quaternion.LookRotation (direction);

	}

	void UpdateAim(Vector2 value)
	{
		if(headTrans != null)
		{
			Quaternion rot = Quaternion.Euler(0f,
				transform.localEulerAngles.y - value.x * Time.deltaTime * -speedProgressiveLook,
				0f);

			_rigidbody.MoveRotation(rot);

			rot = Quaternion.Euler(headTrans.localEulerAngles.x - value.y * Time.deltaTime * speedProgressiveLook,
				0f,
				0f);
			headTrans.localRotation = rot;

		}
		else
		{

			Quaternion rot = Quaternion.Euler(transform.localEulerAngles.x - value.y * Time.deltaTime * speedProgressiveLook,
				transform.localEulerAngles.y + value.x * Time.deltaTime * speedProgressiveLook,
				0f);

			_rigidbody.MoveRotation(rot);
		}
	}
}
