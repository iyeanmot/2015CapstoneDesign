﻿using UnityEngine;
using System.Collections;

public class speech : MonoBehaviour {
    public GameObject white;
    public GameObject blue;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("exting").GetComponent<exting_pro>().check_player == true)
        {
            blue.SetActive(true);
            blue.transform.position = white.transform.position;
            blue.transform.rotation = white.transform.rotation;
            white.SetActive(false);
        }
	}
}
