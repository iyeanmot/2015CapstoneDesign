using UnityEngine;
using System.Collections;

public class de_CheckDown : MonoBehaviour {

    public GameObject _Warning;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnTriggerEnter(Collider col)
    {
        _Warning.SetActive(true);
    }
    void OnTriggerExit(Collider col)
    {
        _Warning.SetActive(false);
    }
}
