using UnityEngine;
using System.Collections;

public class be_final : MonoBehaviour {

    public GameObject select_edu;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider col)
    {
        if (col.name == "Player")
        {
            if (select_edu.GetComponent<be_select_edu>().edu3_finished &&
                select_edu.GetComponent<be_select_edu>().edu2_finished &&
                select_edu.GetComponent<be_select_edu>().edu1_finished)
            {
                col.GetComponent<be_Item>().isSuccess = true;
            }
        }

    }
}
