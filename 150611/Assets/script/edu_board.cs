    using UnityEngine;
using System.Collections;

public class edu_board : MonoBehaviour
{

    public Texture2D[] Tutorial1 = new Texture2D[3];
    public Texture2D[] Tutorial2 = new Texture2D[6];

    public int state;
    public GameObject camera;
    public GameObject move_camera;
    public GameObject move_char;
    public GameObject speech;
    public GameObject Amy;
    public GameObject Player_State;
    public int playmode_On;
    public GameObject explain_image;
    // Use this for initialization
    public AudioClip sound;
    void Start()
    {
        camera = GameObject.Find("edu_camera");
        state = 1;
        playmode_On = 0;
        //audio.PlayOneShot(sound);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Player_State.GetComponent<have_State>().Player_State == have_State.State.PLAYGAME)
        {
            //Destroy(ex2);
            //Player_State = State.PLAYGAME;
            if (playmode_On == 0)
            {
                Set_Playmode();
            }
        }

        //if (Player_State == State.SHOWTURIAL1)
        //{
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        state = state + 1;
        //        Debug.Log(state);
        //    }

        //}

    }
    void OnGUI()
    {
        if (Player_State.GetComponent<have_State>().Player_State == have_State.State.SHOWTURIAL1)
        {
            //if(state > 2)
            //    Player_State.GetComponent<have_State>().Player_State = have_State.State.PLAYGAME;
            GUI.DrawTexture(new Rect(Screen.width / 3-100, Screen.height / 2 +100, 600, 200), Tutorial1[state]);

        }
        if (Player_State.GetComponent<have_State>().Player_State == have_State.State.SHOWTURIAL2)
        {
            
            GUI.DrawTexture(new Rect(Screen.width / 3-100, Screen.height / 2+100, 600, 200), Tutorial2[state]);
            if(state ==1)
                explain_image.SetActive(true);

        }

        //if (state == 1)
        //{
        //    GUI.DrawTexture(new Rect(Screen.width / 3, Screen.height / 2 + 100, 600, 200), Tutorial[0]);
        //}
        //if (state == 2)
        //{

        //    //Destroy(ex1);
        //    GUI.DrawTexture(new Rect(Screen.width / 3, Screen.height / 2 + 100, 600, 200), Tutorial[1]);
        //}
        //if (state == 3)
        //{
        //    //Destroy(ex2);
        //    GUI.DrawTexture(new Rect(Screen.width / 3, Screen.height / 2 + 100, 600, 200), Tutorial[2]);
        //    //Player_State = State.PLAYGAME;
        //    Set_Playmode();
        //}
        //if (state == 4)
        //{
        //    GUI.DrawTexture(new Rect(Screen.width / 3, Screen.height / 2 + 100, 600, 200), Tutorial[3]);
        //}
        //if (state == 5)
        //{
        //    GUI.DrawTexture(new Rect(Screen.width / 3, Screen.height / 2 + 100, 600, 200), Tutorial[4]);
        //}
        //if (state == 6)
        //{
        //    GUI.DrawTexture(new Rect(Screen.width / 3, Screen.height / 2 + 100, 600, 200), Tutorial[5]);
        //}
        //if (state == 7)
        //{
        //    GUI.DrawTexture(new Rect(Screen.width / 3, Screen.height / 2 + 100, 600, 200), Tutorial[6]);
        //}
        //if (state == 8)
        //{
        //    GUI.DrawTexture(new Rect(Screen.width / 3, Screen.height / 2 + 100, 600, 200), Tutorial[7]);
        //}
        //if (state == 9)
        //{
        //    GUI.DrawTexture(new Rect(Screen.width / 3, Screen.height / 2 + 100, 600, 200), Tutorial[8]);
        //    Player_State = State.PLAYGAME;
        //    Set_Playmode();
        //}
    }

    void Set_Playmode()
    {
        //캐릭터, 캐릭터 카메라 on
        //안내문, 소방관 off
        move_camera.SetActive(true);
        move_char.SetActive(true);
        speech.SetActive(false);
        //소방관, 에듀카메라 위치이동
        camera.transform.localPosition
                    = new Vector3(-29.73f, 6.92f, 24.27f);
        camera.transform.localEulerAngles
                    = new Vector3(0, -22f, 0);
        camera.SetActive(false);
        Amy.SetActive(false);
        state = 0;
        playmode_On = playmode_On + 1;
    }
}
