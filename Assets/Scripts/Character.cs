﻿using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {
	Movement movement;

	void Awake ()
	{
		movement = GetComponent<Movement>();
	}

	public void RecieveMovementInput (float horizontal, float vertial)
	{
		movement.Move(horizontal, vertial);
	}
}
