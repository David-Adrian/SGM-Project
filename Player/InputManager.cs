using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	public static float XboxHorizontal(){
		float r = 0.0f;
		r += Input.GetAxis("WalkHorizontal");
		return Mathf.Clamp(r,-1.0f, 1.0f);
	}

	public static float XboxVertical(){
		float r = 0.0f;
		r += Input.GetAxis("WalkVertical");
		return Mathf.Clamp(r,-1.0f, 1.0f);
	}

	public static Vector3 XboxJoystickMovement(){
		return new Vector3(XboxHorizontal(), 0, XboxVertical());
	}
}
