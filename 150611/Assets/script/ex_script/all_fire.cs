using UnityEngine;
using System.Collections;

public class all_fire : MonoBehaviour {

    public GameObject gage_set;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerStay(Collider col)
    {
        gage_set.SetActive(true);       //게이지 On
    }
    void OnTriggerExit(Collider col)
    {
        gage_set.SetActive(false);      //게이지 Off
    }
}
