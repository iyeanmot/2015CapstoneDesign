using UnityEngine;
using System.Collections;

public class doorfront : MonoBehaviour {

    public bool test4 = false;
    public bool get = false;
    public bool pet_get = false;
    public GameObject player4;
    void Start()
    {
        player4 = GameObject.Find("pet_man");
    }

    // Update is called once per frame
    void Update()
    {
       
        if (test4 == true)
        {
            if (get == true)
            {

                if (Input.GetMouseButtonDown(0))
                {
                    //Debug.Log("dddddddddddddddddddddd");
                    gameObject.transform.Rotate(0, 90, 0);
                    get = false;
                }
            }
            
        }
    }
    void OnTriggerEnter(Collider col)
    {
        test4 = true ;
    }
    void OnTriggerExit(Collider col)
    {
        test4 = false;
    }
}
