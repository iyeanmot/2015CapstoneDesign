using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Waypoint : MonoBehaviour {

	private GameObject controller;

	// Use this for initialization
	void Start () {
		controller = this.transform.parent.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider col) {
		if(col.gameObject.tag == "Player"){
			controller.SendMessage("ChangeTarget", SendMessageOptions.RequireReceiver);
            Destroy(gameObject);
		}
	}
	
	void OnDrawGizmosSelected(){
		controller.SendMessage("OnDrawGizmosSelected");
	}

}
