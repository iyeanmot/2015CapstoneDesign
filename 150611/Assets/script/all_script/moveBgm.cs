using UnityEngine;
using System.Collections;

public class moveBgm : MonoBehaviour {

    GameObject _Player;
	// Use this for initialization
	void Start () {
        _Player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.position = _Player.transform.position;
	
	}
}
