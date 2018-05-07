using UnityEngine;

public class Interactable : MonoBehaviour {

    public float radius = 5f;
    bool isFocus = false;
    public Transform player;

    bool intereacted = false;

    public virtual void Interact(){
        Debug.Log("Interacted with " + transform.name);
    }

    void Update()
    {
        // if(isFocus){
        //     float distance = (player.transform.position - transform.position).sqrMagnitude;
        //     if(distance <= radius){
        //         Debug.Log("Interacted");
        //         intereacted = true;
        //     }
        // }
    }   
    void onDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
		Gizmos.DrawWireSphere(transform.position, radius);
    }

     // public void onFocused(Transform playerTransform){
    //     isFocus = true;
    //     player = playerTransform;
    //     intereacted = false;
    // }

    // public void onDeFocused(){
    //     isFocus = false;
    //     player = null;
    //     intereacted = false;
    // }

}