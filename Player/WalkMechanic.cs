using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WalkMechanic : MonoBehaviour {

	private Rigidbody knightRG;
	public float walkspeed = 3;
	public float sprintSpeed = 6;

	void Start () {
		 knightRG = GetComponent<Rigidbody> ();
	}
	
	void Update () {

		//Movement -> Keyboard
		if (Input.GetKey ("w")) {
			knightRG.velocity = transform.forward * walkspeed;
		} else if (Input.GetKey ("s")) {
			knightRG.velocity = -transform.forward * walkspeed;
		} else if (Input.GetKey ("a")) {
			knightRG.velocity = -transform.right * walkspeed;
		} else if (Input.GetKey ("d")) {
			knightRG.velocity = transform.right * walkspeed;
		}

		if (Input.GetKey ("w") && Input.GetKey ("d")) {
			knightRG.velocity = (transform.right + transform.forward) * walkspeed;
		}else if (Input.GetKey ("w") && Input.GetKey ("a")) {
			knightRG.velocity = ((-transform.right) + transform.forward) * walkspeed;
		}else if (Input.GetKey ("s") && Input.GetKey ("a")) {
			knightRG.velocity = ((-transform.right) + (-transform.forward)) * walkspeed;
		}else if (Input.GetKey ("s") && Input.GetKey ("d")) {
			knightRG.velocity = ( (- transform.forward) + transform.right) * walkspeed;
		}

		//Movement -> Xbox Controller
		string[] names = Input.GetJoystickNames();
        	for (int i = 0; i < names.Length; i++){
				if (InputManager.XboxJoystickMovement().z < 1f && InputManager.XboxJoystickMovement().z > 0f) {
					knightRG.velocity = transform.forward * walkspeed;
				}else if (InputManager.XboxJoystickMovement().z > -1f && InputManager.XboxJoystickMovement().z < 0f) {
					knightRG.velocity = -transform.forward * walkspeed;
				}else if (InputManager.XboxJoystickMovement().x < 1f && InputManager.XboxJoystickMovement().x > 0f) {
					knightRG.velocity = -transform.right * walkspeed;
				}else if (InputManager.XboxJoystickMovement().x > -1f && InputManager.XboxJoystickMovement().x < 0f) {
					knightRG.velocity = transform.right * walkspeed;
				}
		}
				


			
		//Sprinting
		if (Input.GetKey(KeyCode.LeftShift)|| Input.GetButtonDown("JoystickBButton")) {
			
			knightRG.velocity = transform.forward * sprintSpeed;
		}		
	}

	
}
