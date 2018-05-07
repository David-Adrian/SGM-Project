using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMovement : MonoBehaviour {

	public Transform target;
	NavMeshAgent agent;
	Transform player1;

	OrcAnim orcAnim;

	void Start () {
		agent =  GetComponent<NavMeshAgent>();
		orcAnim = GetComponent<OrcAnim>();
	}

	void Update()
	{
		if(target != null){
			agent.SetDestination(target.position);
			FaceTarget();
		}
	}

	public void moveToPlayer(Transform newTarget){
		orcAnim.running();
		target = newTarget;
		//Debug.Log("Player found: " + target.tag);
		agent.SetDestination(newTarget.position);
		agent.speed = 4f;
				
	}

	public void attackPlayer(float closeRadius){
		//Debug.Log("Attacking player: " + target.tag);
		agent.stoppingDistance = closeRadius;
		orcAnim.attack();	
	}

	public void moveToCart(){
		target = GameObject.FindGameObjectWithTag("Cart").transform;
		agent.SetDestination(target.position);
		orcAnim.walking();
		agent.speed = 2f;
	}

	void FaceTarget(){
		Vector3 direction = (target.position - transform.position).normalized;
		Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
		transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
	}

	// public void followTarget(Interactable newTarget, float closeRadius){
	// 	target = newTarget.transform;
	// 	agent.updateRotation = false;
	// 	agent.stoppingDistance = closeRadius;	
	// }

	// public void stopFollowTarget(){
	// 	agent.stoppingDistance = 0f;
	// 	agent.updateRotation = true;
	// 	target = null;
	// }

}
