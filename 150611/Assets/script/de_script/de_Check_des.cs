using UnityEngine;
using System.Collections;

public class de_Check_des : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider col)
    {
        col.GetComponent<de_Item>().isEscape = true;

    }
}
