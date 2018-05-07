using UnityEngine;

public class CharacterStats : MonoBehaviour {

	public int health = 100;
	public int currenthealth {get; private set;}

	public Stats damage;

	private KnightAnim dying;

	void Start () {
		dying = GetComponent<KnightAnim>();
	}

	void Awake(){
		currenthealth = health;
	}

	void Update()
	{
		//  if (Input.GetKeyDown(KeyCode.T)) {
		// 	takeDamage(10);
		// 	Debug.Log(getCurrentHealth() + " health");
		// }
	}

	public int getCurrentHealth(){
		return currenthealth;
	}

	public void takeDamage(int damage){

		damage = Mathf.Clamp(damage, 0, 100);

		currenthealth -= damage;
		Debug.Log(transform.name + " took " + damage + " damage.");

		if(currenthealth <= 0){
			Die();
		}
	}

	public virtual void Die(){	
		Debug.Log(transform.name + " has died.");
		dying.Die();
	}

}
