using UnityEngine;
using System.Collections;

public class move_not : MonoBehaviour {
    public bool check;
	// Use this for initialization
	void Start () {
        gameObject.SetActive(false);
        check = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (check == true)
        {
            gameObject.SetActive(true);
            Debug.Log(check);
        }
       
	}
}
