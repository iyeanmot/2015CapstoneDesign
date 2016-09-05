using UnityEngine;
using System.Collections;

public class sm_Item : MonoBehaviour {

    //손수건
    public bool gethanki;
    public GameObject got_hanki;

    //edu2켜기
    public GameObject _EduCamera;
    public GameObject _EduBoard;

    //낮은 자세
    public bool isDown;
    public GameObject _PlayerCamera;
    Vector3 _downPosition;

    //성공
    public bool isSuccess;
    public bool isfinal;
    public Texture2D successd;
    float OnTime;
    public AudioClip sound_success;


	// Use this for initialization
	void Start () {

        //_EduCamera = GameObject.Find("edu_camera");

        gethanki = false;
        isSuccess = false;
        isDown = false;
        _downPosition = new Vector3(0, 0, 0);

        isfinal = false;
    
	}
	
	// Update is called once per frame
	void Update () {

        //성공 시 씬 넘어감
        if (isSuccess)
        {
            if (Time.time - OnTime > 5)
                Application.LoadLevel(6);
        }

        if (gethanki && !_EduBoard.GetComponent<select_edu>().edu2_finished)
        {
            got_hanki.SetActive(true);
            _EduCamera.SetActive(true);
            _EduCamera.GetComponent<sm_eduboard>().isON = true;
            isDown = true;
            _downPosition = new Vector3(0, 0.3f, 0);
        }

        if (isDown && gameObject.transform.localPosition.y != 0)
        {
            _PlayerCamera.transform.localPosition = _downPosition;
            //GetComponent<CharacterMotor>().movement.maxForwardSpeed = 1;
            GetComponent<CharacterMotor>().movement.maxSidewaysSpeed = 1;
        }

        if (GetComponent<CharacterMotor>().movement.maxForwardSpeed == 1)
        {
            if (Input.GetKey(KeyCode.LeftShift))
            {
                GetComponent<CharacterMotor>().movement.maxForwardSpeed = 3;

            }
          
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

            GUI.DrawTexture(new Rect(Screen.width/2-212,Screen.height/2-119/2, 424, 119*2), successd);
            isfinal = true;
        }
    }
	
	
}

