using UnityEngine;
using System.Collections;

public class pet : MonoBehaviour {

    public GameObject player3;
    public bool trigger = false;
	// Use this for initialization
	void Start () {
        player3 = GameObject.Find("extinguisher_man");
	}
	
	// Update is called once per frame
	void Update () {

        if (trigger == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject.Find("DoorFront_HouseM1Tbrick").AddComponent<doorfront>().get = true;

                GameObject.Find("extinguisher_man").GetComponent<getpet>().extingItem3 = 1;
                Destroy(gameObject);
            }
        }

	}
    void OnTriggerEnter(Collider col)
    {
        trigger = true;
    }
    void OnTriggerExit(Collider col)
    {
        trigger = false;
    }
}
