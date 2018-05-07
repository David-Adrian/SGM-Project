using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcAnim : MonoBehaviour {

	[SerializeField]
	public Animator anim;

	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void running(){
		anim.SetBool("run", true);
		anim.SetBool("walk", false);
		anim.SetBool("attack",false);
	}

	public void walking(){
		anim.SetBool("walk", true);
		anim.SetBool("run", false);
		anim.SetBool("attack",false);
	}

	public void attack(){
		anim.SetBool("attack",true);
		anim.SetBool("run", false);
		anim.SetBool("walk", false);
	}
}
