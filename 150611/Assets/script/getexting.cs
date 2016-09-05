using UnityEngine;
using System.Collections;

public class getexting : MonoBehaviour {
    public int extingItem2;
    public GameObject man2;
    public GameObject extinguisher_man2;
	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
        extingItem2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (extingItem2 == 1)
        {
            //Debug.Log("1");
            extinguisher_man2.SetActive(true);
            extinguisher_man2.transform.position = man2.transform.position;
            extinguisher_man2.transform.rotation = man2.transform.rotation;
            man2.SetActive(false);
            //extinguisher.transform
        }
	}

}
