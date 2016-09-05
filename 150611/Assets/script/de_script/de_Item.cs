using UnityEngine;
using System.Collections;

public class de_Item : MonoBehaviour {

    public GameObject _EduCamera;
    public GameObject _EduBoard;
    public GameObject _EscapeCamera;

    //계단 접근
    public bool firebell;
    public bool isShowede2;
    public bool isEscape;

   //성공
    public bool isSuccess;
    public bool isfinal;
    public Texture2D successd;
    float OnTime;
    public AudioClip sound_success; 

	// Use this for initialization
	void Start () {

        firebell = false;
        isEscape = false;
        isShowede2 = false;

        isSuccess = false;
        isfinal = false;
	
	}
	
	// Update is called once per frame
	void Update () {
        if (isSuccess)
        {
            if (Time.time - OnTime > 5)
                Application.LoadLevel(6);
        }
        //계단에 접근했을때
        if (isShowede2 && !_EduBoard.GetComponent<de_select_edu>().edu2_finished)
        {
            _EduCamera.SetActive(true);
            _EduCamera.GetComponent<sm_eduboard>().Move_Camera(gameObject.transform.position);
            _EduCamera.GetComponent<sm_eduboard>().isON = true;
        }
        if (isEscape && !_EduBoard.GetComponent<de_select_edu>().edu3_finished)
        {
            _EduCamera.SetActive(true);
            _EduCamera.GetComponent<sm_eduboard>().isON = true;
            _EduCamera.GetComponent<sm_eduboard>().Move_Camera(gameObject.transform.position);
            _EduBoard.GetComponent<de_select_edu>().play_edu3();
        }

        if (isEscape && _EduBoard.GetComponent<de_select_edu>().edu3_finished)
        {
            _EscapeCamera.SetActive(true);
            gameObject.SetActive(false);
        }

	
	}
    void OnGUI()
    {
        if (isSuccess)
        {
            if (!isfinal)
            {
                OnTime = Time.time;
                audio.PlayOneShot(sound_success);
            }

            GUI.DrawTexture(new Rect(Screen.width / 2 - 212, Screen.height / 2 - 119 / 2, 424, 119 * 2), successd);
            isfinal = true;
        }


    }
}
