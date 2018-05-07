using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightAnim : MonoBehaviour {

	[SerializeField]
	public Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	void Update () {
		
		//Movement
		if (Input.GetKeyDown ("w")) {
			anim.SetBool ("walk", true);
			anim.SetFloat("Direction", 1.0f);
		}else if (Input.GetKeyUp ("w")){
			anim.SetBool ("walk", false);
		}else if (Input.GetKeyDown(KeyCode.LeftShift)) {
			anim.SetBool ("run", true);
		} else if (Input.GetKeyUp(KeyCode.LeftShift)){
			anim.SetBool ("run", false);
		}if (Input.GetKeyDown ("s") || Input.GetKeyDown("s") && Input.GetKeyDown ("d") || Input.GetKeyDown("s") && Input.GetKeyDown ("a")) {
			anim.SetBool ("walk", true);
			anim.SetFloat("Direction", -1.0f);
		}if (Input.GetKeyUp ("s") || Input.GetKeyUp("s") && Input.GetKeyUp ("d") || Input.GetKeyUp("s") && Input.GetKeyUp ("a")) {
			anim.SetBool ("walk", false);
		}if (Input.GetKeyDown ("d") || Input.GetKeyDown("a") || Input.GetKeyDown ("d") && Input.GetKeyDown ("w")) {
			anim.SetBool ("walk", true);
			anim.SetFloat("Direction", 1.0f);
		}if (Input.GetKeyUp ("d") || Input.GetKeyUp("a") || Input.GetKeyUp("d") && Input.GetKeyUp ("w")) {
			anim.SetBool ("walk", false);
		}

		//Joystick
		if(InputManager.XboxJoystickMovement().z <= 1f && InputManager.XboxJoystickMovement().z > 0f){
			anim.SetBool ("walk", true);
		}else if(InputManager.XboxJoystickMovement().z >= -1f && InputManager.XboxJoystickMovement().z < 0f){
			anim.SetBool ("walk", true);
		}else if(InputManager.XboxJoystickMovement().x >= -1f && InputManager.XboxJoystickMovement().x < 0f){
			anim.SetBool ("walk", true);
			anim.SetFloat("Direction", -1.0f);
		}else if(InputManager.XboxJoystickMovement().x <= 1f && InputManager.XboxJoystickMovement().x > 0f){
			anim.SetBool ("walk", true);
			anim.SetFloat("Direction", 1.0f);
		}else if (Input.GetButtonDown("JoystickBButton")) {
			anim.SetBool ("run", true);
		} else if (Input.GetButtonUp("JoystickBButton")){
			anim.SetBool ("run", false);
		}
		
		//Attacking
		 if (Input.GetMouseButtonDown(0) || Input.GetButtonDown("JoystickAButton")) {
			anim.SetBool ("atack", true);
		} else if (Input.GetMouseButtonUp(0) || Input.GetButtonUp("JoystickAButton")) {
			anim.SetBool ("atack", false);
		}
	}

	//Dying?!	
	public void Die(){
		anim.SetBool("die", true);
	}	
}