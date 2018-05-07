using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseControls : MonoBehaviour {
	//Camera mainCamera;
	Cursor cursorReff;

	void Start () {
		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;

		//mainCamera = GetComponent<Camera>();
	}
	
	void Update () {

		//Camera rotation -> Mouse
		float x =Input.GetAxis ("Mouse X");
		float y =Input.GetAxis ("Mouse Y");

		if(Cursor.lockState == CursorLockMode.Locked){
			transform.eulerAngles = new Vector3 (transform.eulerAngles.x, transform.eulerAngles.y + x, 0f);
		}

		//Camera rotation -> Xbox Controller
		if(Input.GetAxis("Horizontal").GetType().ToString() == "Joystick Axis" && Input.GetAxis("Vertical").GetType().ToString() == "Joystick Axis"){
			transform.eulerAngles = new Vector3 (InputManager.XboxHorizontal(), InputManager.XboxVertical(), 0f);
		}

		if (Input.GetKey(KeyCode.LeftControl)) {
			 Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}else if (Input.GetKey(KeyCode.LeftAlt)) {
			 Cursor.lockState = CursorLockMode.None;
			 Cursor.visible = true;
		}
	}
}
