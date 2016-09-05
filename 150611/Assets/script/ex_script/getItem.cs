using UnityEngine;
using System.Collections;

public class getItem : MonoBehaviour
{

    public bool getexing;
    public bool isSuccess;
    public Texture2D successd;
    public GameObject got_extinguisher;
    float OnTime;
    public bool firecheck1;
    public bool firecheck2;
    public bool firecheck3;
    int second_tutorial_on;
    public GameObject edu_camera;
    GameObject Player_State;

    public bool isfinal;
    public AudioClip sound_success; 

	// Use this for initialization
	void Start () {
        getexing = false;
        isSuccess = false;
        //got_extinguisher = GameObject.Find("get_extinguisher"); 

        firecheck1 = true;
        firecheck2 = true;
        firecheck3 = true;
        second_tutorial_on = 0;
        Player_State = GameObject.Find("Player_State");
	}
	
	// Update is called once per frame
	void Update () {
        if (!firecheck1 && !firecheck2 && !firecheck3)
        {
            Debug.Log("OK");
            isSuccess = true;
        }
        if (isSuccess)
        {
            if (Time.time - OnTime > 5)
                Application.LoadLevel(6);
        }

        if (getexing)
        {
            //얻은 소화기
            //Instantiate(extinguisher);
            got_extinguisher.SetActive(true);
            second_tutorial_on = second_tutorial_on + 1;
            //Debug.Log("get"+Player_State);
            //if (Player_State == State.SHOWTURIAL)
        
        }
        if (second_tutorial_on == 1)
        {            
            show_second();
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
    void show_second()
    {
        edu_camera.GetComponent<edu_board>().move_camera.SetActive(false);
        edu_camera.GetComponent<edu_board>().move_char.SetActive(false);
        edu_camera.GetComponent<edu_board>().speech.SetActive(true);
        edu_camera.GetComponent<edu_board>().camera.SetActive(true);
        edu_camera.GetComponent<edu_board>().Amy.SetActive(true);
        second_tutorial_on = second_tutorial_on + 1;
        Player_State.GetComponent<have_State>().Player_State = have_State.State.SHOWTURIAL2;
        
    }
}
