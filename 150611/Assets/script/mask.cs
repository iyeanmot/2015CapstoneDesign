using UnityEngine;
using System.Collections;

public class mask : MonoBehaviour {
    public bool test6 = true;
    public bool test7 = true;
    public bool open_door = true;
    public GameObject player;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("First Person Controller");
	}
	
	// Update is called once per frame
	void Update () {
        if (test6 == false)
        {
            if (test7 == true)
            {
                if (Input.GetKey(KeyCode.S))
                {
                    test6 = true;
                }
                else
                {
                    if (Input.GetMouseButtonDown(0))
                    {
                        //Debug.Log("dddddddddddddddddddddd");s
                        GameObject.Find("Door02_HouseM1Tbrick").GetComponent<door2>().getItem = true;
                        test7 = false;
                        GameObject.Find("Door02_HouseM1Tbrick").GetComponent<door2>().test = true;
                        GameObject.Find("First Person Controller").GetComponent<getmask>().extingItem = 1;
                        Destroy(gameObject);
                     }
                }
            }
        }       
	}
    void OnTriggerEnter(Collider col)
    {
        test6 = false;
    }
}
