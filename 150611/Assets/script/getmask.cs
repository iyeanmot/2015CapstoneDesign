using UnityEngine;
using System.Collections;

public class getmask : MonoBehaviour {
    //public GameObject open;
	// Use this for initialization
    public int extingItem;
    public GameObject man;
    public GameObject extinguisher_man;
	void Start () {
        extingItem = 0;
        //gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        //extinguisher_man.SetActive(false);
        if (extingItem == 1)  
        {
            //Debug.Log("1");
            extinguisher_man.SetActive(true);
            extinguisher_man.transform.position = man.transform.position;
            extinguisher_man.transform.rotation = man.transform.rotation;
            man.SetActive(false);
            //extinguisher.transform
        }
	}

}