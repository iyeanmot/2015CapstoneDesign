using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class de_edu3 : MonoBehaviour {

    public Texture2D explain_1;
    public Texture2D explain_2;
    public Texture2D explain_3;
    public Texture2D explain_4;
    public Texture2D explain_5;
    public Texture2D explain_6;
    public Texture2D explain_7;

    //public GameObject yellcount;
    GameObject _board;
    GameObject _EduCamera;
    public GameObject _Image;


    // Use this for initialization
    void Start()
    {
        gameObject.SetActive(false);
        _board = GameObject.Find("educationUI");
        _EduCamera = GameObject.Find("edu_camera");

    }

    // Update is called once per frame
    void Update()
    {

        if (_board.GetComponent<de_select_edu>().now_edu == this.gameObject)
        {
            if (_board.GetComponent<de_select_edu>()._state == 1)
                gameObject.GetComponent<RawImage>().texture = explain_2;
            if (_board.GetComponent<de_select_edu>()._state == 2)
            {
                gameObject.GetComponent<RawImage>().texture = explain_3;
                _Image.SetActive(true);
            }
            if (_board.GetComponent<de_select_edu>()._state == 3)
                gameObject.GetComponent<RawImage>().texture = explain_4;
            if (_board.GetComponent<de_select_edu>()._state == 4)
                gameObject.GetComponent<RawImage>().texture = explain_5;
            if (_board.GetComponent<de_select_edu>()._state == 5)
                gameObject.GetComponent<RawImage>().texture = explain_6;
            if (_board.GetComponent<de_select_edu>()._state == 6)
                gameObject.GetComponent<RawImage>().texture = explain_7;
            if (_board.GetComponent<de_select_edu>()._state >= 7)
            {
                gameObject.SetActive(false);
                _Image.SetActive(false);
                _board.GetComponent<de_select_edu>().now_edu = _board.GetComponent<de_select_edu>().edu3;
                _board.GetComponent<de_select_edu>()._state = 0;
                _board.GetComponent<de_select_edu>().edu3_finished = true;
                _EduCamera.GetComponent<sm_eduboard>().isON = false;
            }



        }
    }
}
