using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class de_nextbutton : MonoBehaviour {

    // Use this for initialization
    GameObject _board;

    GameObject _EduCamera;

    public AudioClip button_click;

    // Use this for initialization
    void Start()
    {

        _board = GameObject.Find("educationUI");
        _EduCamera = GameObject.Find("edu_camera");

        GetComponent<Button>().onClick.AddListener(() => ButtonClick());

    }

    // Update is called once per frame
    void Update()
    {

    }
    void ButtonClick()
    {
        if (_EduCamera.GetComponent<sm_eduboard>().isON)
            _board.GetComponent<de_select_edu>()._state = _board.GetComponent<de_select_edu>()._state + 1;
        Debug.Log(_board.GetComponent<de_select_edu>()._state);

        audio.PlayOneShot(button_click);
    }
}
