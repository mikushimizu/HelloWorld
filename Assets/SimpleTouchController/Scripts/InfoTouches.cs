﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class InfoTouches : MonoBehaviour {

	// PUBLIC
	public Text leftText;
	public Text rightText;
	public SimpleTouchController leftController;
	public SimpleTouchController rightController;

	public GameObject Message;
	// PRIVATE


	void Update()
	{
		leftText.text = "Left Touch:\n" +
			"x: " + leftController.GetTouchPosition.x + "\n" +
			"y: " + leftController.GetTouchPosition.y;
	}
}
