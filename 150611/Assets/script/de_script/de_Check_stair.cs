using UnityEngine;
using System.Collections;

public class de_Check_stair : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player" && col.GetComponent<de_Item>().firebell)
        {
            col.GetComponent<de_Item>().isShowede2 = true;
        }
    }
}
