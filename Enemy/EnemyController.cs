using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	//public Interactable focus;
	public LayerMask movementMask;
	EnemyMovement movement;
	public GameObject player1;
	public GameObject enemy;
	float lookRadius = 100f;
	float closeRadius = 4f;	
	
	void Start () {
		movement = GetComponent<EnemyMovement>();
		//focus = GetComponent<Interactable>();
		player1 = GameObject.FindGameObjectWithTag("Player1");
		enemy = GameObject.FindGameObjectWithTag("Enemy");

	}
	
	void Update () {

		movement.moveToCart();

		float distance = (player1.transform.position - enemy.transform.position).sqrMagnitude;
		if(distance <= lookRadius){
			movement.moveToPlayer(player1.transform);

				if(distance <= closeRadius){
					movement.attackPlayer(closeRadius);
				}
		}					
	}

	void onDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(enemy.transform.position, lookRadius);
    }

	//void SetFocus(Interactable newFocus){

	// 	if(newFocus != focus){
	// 		if(focus != null)
	// 			focus.onDeFocused();

	// 		focus = newFocus;
	// 		movement.followTarget(focus, closeRadius);
	// 	}

	// 	newFocus.onFocused(player1.transform);
		
	// }

	// void removeFocus(){

	// 	if(focus != null)
	// 		focus.onDeFocused();
			
	// 	focus = null;
	// 	movement.stopFollowTarget();
	// }
}
