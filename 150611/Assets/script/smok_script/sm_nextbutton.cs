using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class sm_nextbutton : MonoBehaviour {


    //edu보드 에서 보여줄 edu를 선택하고 이쪽으로 보내줄것
    //에듀보드 스테이트 쓸것

    //GameObject edu1;
    GameObject _board;

    GameObject _EduCamera;

    public AudioClip button_click;

	// Use this for initialization
	void Start () {

        //edu1 = GameObject.Find("edu1");
        _board = GameObject.Find("educationUI");
        _EduCamera = GameObject.Find("edu_camera");

        GetComponent<Button>().onClick.AddListener(() => ButtonClick());
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void ButtonClick()
    {
        if (_EduCamera.GetComponent<sm_eduboard>().isON)
            _board.GetComponent<select_edu>()._state = _board.GetComponent<select_edu>()._state + 1;
        Debug.Log(_board.GetComponent<select_edu>()._state);

        audio.PlayOneShot(button_click);
    }
}
