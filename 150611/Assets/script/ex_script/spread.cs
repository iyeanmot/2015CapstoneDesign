using UnityEngine;
using System.Collections;

public class spread : MonoBehaviour {

    float OnTime;
	// Use this for initialization
	void Start () {
        OnTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
	    if(Time.time - OnTime > 1)
            Destroy(gameObject); 
	}
}
