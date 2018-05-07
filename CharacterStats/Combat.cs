using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class Combat : MonoBehaviour {

	CharacterStats mystats;

	void Start () {
		mystats = GetComponent<CharacterStats>();
	}
	

	public void Attack(CharacterStats targetStats){
		targetStats.takeDamage(mystats.damage.getValue());
	}
}
