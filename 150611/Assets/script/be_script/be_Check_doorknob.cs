using UnityEngine;
using System.Collections;

public class be_Check_doorknob : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {

            col.GetComponent<be_Item>().isShowede2 = true;
        }
    }
}
