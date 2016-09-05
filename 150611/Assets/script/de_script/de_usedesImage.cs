using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class de_usedesImage : MonoBehaviour {

    public Texture2D explain_1;
    public Texture2D explain_2;
    public Texture2D explain_3;
    public Texture2D explain_4;
    public Texture2D explain_5;

    GameObject _board;

	// Use this for initialization
	void Start () {
        //gameObject.SetActive(false);
        _board = GameObject.Find("educationUI");
	}
	
	// Update is called once per frame
	void Update () {
        if (_board.GetComponent<de_select_edu>()._state == 3)
            gameObject.GetComponent<RawImage>().texture = explain_2;
        if (_board.GetComponent<de_select_edu>()._state == 4)
            gameObject.GetComponent<RawImage>().texture = explain_3;
        if (_board.GetComponent<de_select_edu>()._state == 5)
            gameObject.GetComponent<RawImage>().texture = explain_4;
        if (_board.GetComponent<de_select_edu>()._state == 6)
            gameObject.GetComponent<RawImage>().texture = explain_5;
	
	}
}
