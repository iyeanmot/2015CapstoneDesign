using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class de_escapeCamera : MonoBehaviour {


    //기우는 방향벡터
    Vector3 _left;
    Vector3 _right;


    //기우는 방향        1이면 왼쪽 2면 오른쪽
    int tilt;
    float Ontime;

    //게이지
    GameObject GagePointer;

    //성공
    public bool isSuccess;
    public bool isfinal;
    public Texture2D successd;
    float OnTime;
    public AudioClip sound_success;

    //경고음
    public AudioClip sound_warn;
    float soundInterval = 2f;
    float lastSound =.0f;

    //안내
    GameObject tutorial;
    public bool Showtuto; 

    //다시시작
    Vector3 originalPosition;
    Quaternion originalRotation;
    Transform originalGagepointer;
	// Use this for initialization
	void Start () {

        Showtuto = true;
       
        //gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 96, 0));
        this.transform.eulerAngles = new Vector3(0, 96, 0);
        //1~2까지
        //tilt = (int)Random.Range(1, 3);
        tilt = 2;
        Ontime = Time.time;

        _left = new Vector3(0, 0, 1);
        _right = new Vector3(0, 0, 1);
        
        GagePointer = GameObject.Find("gagepoint");
        tutorial = GameObject.Find("tutorial");

        isSuccess = false;
        isfinal = false;

        originalPosition = transform.position;
        originalRotation = transform.rotation;
        originalGagepointer = GagePointer.transform;
	}
	
	// Update is called once per frame
    void Update()
    {
        ////강제 초기화
        //if (gameObject.transform.rotation.eulerAngles.z > 350)
        //{
        //    Debug.Log("ddddd");
        //    gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, 96, 0));
        //}
        if (Showtuto)
        {
            if (Time.time - Ontime > 5)
            {
                tutorial.SetActive(false);
                Showtuto = false;
                Ontime = Time.time;
            }
        }
        if (!Showtuto)
        {


            //3초마다 방향 바꿔주기
            if (Time.time - Ontime > 5)
            {
                tilt = (int)Random.Range(1, 3);
                Debug.Log(tilt);
                Ontime = Time.time;
            }
            if (gameObject.transform.rotation.eulerAngles.z > 15 && gameObject.transform.rotation.eulerAngles.z < 16)
            {
                Reset();
                Debug.Log("over");
            }
            if (gameObject.transform.rotation.eulerAngles.z < 345 && gameObject.transform.rotation.eulerAngles.z > 344)
            {
                Debug.Log("over");
                Reset();
            }

            if (gameObject.transform.rotation.eulerAngles.z < 15 ||
                gameObject.transform.rotation.eulerAngles.z > 345)
            {
                //tilt == 1 왼쪽으로 기울기
                if (tilt == 1)
                {
                    gameObject.transform.Rotate(_left, 3 * Time.deltaTime);
                    GagePointer.transform.localPosition = new Vector3(GagePointer.transform.localPosition.x - 30 * Time.deltaTime, 25, 0);
                }

                //tilt == 2 오른쪽으로 기울기
                if (tilt == 2)
                {
                    gameObject.transform.Rotate(_right, 360 - 3 * Time.deltaTime);
                    GagePointer.transform.localPosition = new Vector3(GagePointer.transform.localPosition.x + 30 * Time.deltaTime, 25, 0);
                }
            }

            //왼쪽
            if (Input.GetKeyDown("a"))
            {
                tilt = 1;
                //Debug.Log("wwww");
            }
            //오른쪽
            if (Input.GetKeyDown("d"))
            {
                tilt = 2;
            }

            //아래로 이동
            if (gameObject.transform.position.y > 0.1)
            {
                gameObject.transform.Translate(0, -1 * Time.deltaTime, 0);
            }
            else
                isSuccess = true;

            if (isSuccess)
            {
                if (Time.time - OnTime > 5)
                    Application.LoadLevel(6);
            }
            if (gameObject.transform.rotation.eulerAngles.z > 13 && gameObject.transform.rotation.eulerAngles.z <= 15)
            {
                if ((Time.time - lastSound) < soundInterval)
                {
                    return;
                }
                else
                {
                    audio.PlayOneShot(sound_warn);
                    lastSound = Time.time;
                }
            }
            if (gameObject.transform.rotation.eulerAngles.z >= 345 && gameObject.transform.rotation.eulerAngles.z < 347)
            {
                if ((Time.time - lastSound) < soundInterval)
                {
                    return;
                }
                else
                {
                    audio.PlayOneShot(sound_warn);
                    lastSound = Time.time;
                }
            }
        }

    }
    void Reset()
    {
        transform.position = originalPosition; transform.rotation = originalRotation;
        GagePointer.transform.localPosition = originalGagepointer.position;

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
