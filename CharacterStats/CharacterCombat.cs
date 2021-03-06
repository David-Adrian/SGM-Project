﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterStats))]
public class CharacterCombat : MonoBehaviour {

    CharacterStats myStats;

    void Start()
    {
        myStats = GetComponent<CharacterStats>();
    }
    public void Attack(CharacterStats targetStats){
        targetStats.takeDamage(myStats.damage.getValue());
        Debug.Log(transform.name + " took " + myStats.damage.getValue() + " damage.");
    }

}
