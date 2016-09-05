using UnityEngine;
using System.Collections;

public class door1 : MonoBehaviour {

    public bool test2 = false;
    public bool fireget = false;
    public bool getItem2 = false;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (getItem2 == true)
        {
            if (test2 == true)
            {
                if (fireget == true)
                {
                    if (Input.GetKey(KeyCode.S))
                    {
                        test2 = true;
                    }
                    else
                    {
                        if (Input.GetMouseButtonDown(0))
                        {
                            //Debug.Log("dddddddddddddddddddddd");
                            gameObject.transform.Rotate(0, 90, 0);
                            fireget = false;
                        }
                    }
                }
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        getItem2 = true;
        //Debug.Log(test2);
    }
    void OnTriggerExit(Collider col)
    {
        getItem2 = false;
        //Debug.Log("2");
    }
}
