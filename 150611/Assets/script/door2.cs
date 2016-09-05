using UnityEngine;
using System.Collections;

public class door2 : MonoBehaviour {
    //public GameObject open;
	// Use this for initialization
    public bool test = true;
    public bool test1 = true;
    public bool getItem = false;
    
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (getItem == true)
        {
            if (test == false)
            {
                if (test1 == true)
                {
                    if (Input.GetKey(KeyCode.S))
                    {
                        test = true;
                    }
                    else
                    {
                        if (Input.GetMouseButtonDown(0))
                        {
                            //Debug.Log("dddddddddddddddddddddd");
                            gameObject.transform.Rotate(0, -90, 0);
                            test1 = false;
                        }
                    }
                }
            }
        }
	}
    void OnTriggerEnter(Collider col)
    {   
        test = false;
        //Debug.Log(test);
    }
}
