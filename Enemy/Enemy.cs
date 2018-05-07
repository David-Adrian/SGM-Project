using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class Enemy : Interactable {

	PlayerManager playerManager;
	CharacterStats myStats;

	void Start()
	{
		playerManager = GetComponent<PlayerManager>();
		myStats = GetComponent<CharacterStats>();
	}
	public override void Interact(){
		base.Interact();
		CharacterCombat combat = playerManager.player.GetComponent<CharacterCombat>();

		if(combat != null){
			combat.Attack(myStats);
		}

	}
}
