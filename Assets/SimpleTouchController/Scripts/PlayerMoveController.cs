using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]

public class PlayerMoveController : MonoBehaviour {

	// PUBLIC
	public SimpleTouchController leftController;
	public SimpleTouchController rightController;
	public Transform headTrans;
	public float speedMovements = 10f;
	public float speedContinuousLook = 100f;
	public float speedProgressiveLook = 3000f;

	// PRIVATE
	private Rigidbody _rigidbody;
	[SerializeField] bool continuousRightController = true;

	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
		//rightController.TouchEvent += RightController_TouchEvent;
	}

	public bool ContinuousRightController
	{
		set{continuousRightController = value;}
	}

	//void RightController_TouchEvent (Vector2 value)
	//{
	//	if(!continuousRightController)
	//	{
	//		UpdateAim(value);
	//	}
	//}

	void Update()
	{
		// move
		_rigidbody.MovePosition(transform.position - (transform.forward * leftController.GetTouchPosition.y * Time.deltaTime * speedMovements) -
			(transform.right * leftController.GetTouchPosition.x * Time.deltaTime * speedMovements) );

		// スティックの倒れた向きを向く
		var v2 = leftController.GetTouchPosition.y;
		var h2 = leftController.GetTouchPosition.x;
		Vector3 direction = new Vector3(h2,0,v2);
		transform.localRotation = Quaternion.LookRotation (direction);

		// 斜めの長さ
		float y = leftController.GetTouchPosition.y;
		float x = leftController.GetTouchPosition.x;
		float syahen = Mathf.Sqrt (x * x + y * y);
		Debug.Log (syahen);
		//if(continuousRightController)
		//{
		//	UpdateAim(rightController.GetTouchPosition);
		//}
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

	//void OnDestroy()
	//{
	//	rightController.TouchEvent -= RightController_TouchEvent;
	//}

}
