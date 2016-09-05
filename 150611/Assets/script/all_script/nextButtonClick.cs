using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class nextButtonClick : MonoBehaviour
{
    GameObject _board;
    GameObject _State;
    public AudioClip button_click;
    // Use this for initialization
    void Start()
    {

        //버튼 클릭 했을시 해당 함수 실행.
        GetComponent<Button>().onClick.AddListener(() => ButtonClick());
        _board = GameObject.Find("edu_camera");
        _State = GameObject.Find("Player_State");
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ButtonClick()
    {   
        //텍스트 길이만큼 끝났을때 tu1
        if (_State.GetComponent<have_State>().Player_State == have_State.State.SHOWTURIAL1 &&
            _board.GetComponent<edu_board>().state == 2)
        {
            _State.GetComponent<have_State>().Player_State = have_State.State.PLAYGAME;
           // Debug.Log(_State.GetComponent<have_State>().Player_State);
        }

        //텍스트 길이만큼 끝났을때 tu2
        if (_State.GetComponent<have_State>().Player_State == have_State.State.SHOWTURIAL2
            && _board.GetComponent<edu_board>().state == _board.GetComponent<edu_board>().Tutorial2.Length-1)
        {
            _State.GetComponent<have_State>().Player_State = have_State.State.PLAYGAME;
            _board.GetComponent<edu_board>().playmode_On = 0;
        }

        //모드 체크
        if(_State.GetComponent<have_State>().Player_State == have_State.State.SHOWTURIAL1 ||
            _State.GetComponent<have_State>().Player_State == have_State.State.SHOWTURIAL2)
            _board.GetComponent<edu_board>().state = _board.GetComponent<edu_board>().state + 1;

        Debug.Log(_board.GetComponent<edu_board>().state);
        Debug.Log(_State.GetComponent<have_State>().Player_State);
        audio.PlayOneShot(button_click);
    }
}
