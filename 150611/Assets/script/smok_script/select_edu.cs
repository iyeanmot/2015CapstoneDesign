﻿using UnityEngine;
using System.Collections;

public class select_edu : MonoBehaviour {

    public GameObject edu1;
    public GameObject edu2;
    public GameObject edu3;

    GameObject _Player;
    //GameObject _EduCamera;

    public int _state;
    public GameObject now_edu;

    public bool edu1_finished;
    public bool edu2_finished; 
    public bool edu3_finished;

	// Use this for initialization
	void Start () {
       // edu1 = GameObject.Find("edu1"); 
       // edu2 = GameObject.Find("edu2");

        _Player = GameObject.Find("Player");
        //_EduCamera = GameObject.Find("sm_eduboard");

        _state = 0;
        now_edu = edu1;
        edu1_finished = false;
        edu2_finished = false;
        edu3_finished = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (_Player.GetComponent<sm_Item>().gethanki && !edu2_finished)
        {
            //Debug.Log("dwwwwwwdd");
            //now_edu = edu2;
            edu2.SetActive(true);
            //_EduCamera.SetActive(true);
            _Player.SetActive(false);
        }

	
	}

    public void play_edu3 ()
    {
        edu3.SetActive(true);
        _Player.SetActive(false);
    }
}
