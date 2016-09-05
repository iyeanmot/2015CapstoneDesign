using UnityEngine;
using System.Collections;

public class sub_board : MonoBehaviour {

    public Texture2D ex1;
    public Texture2D ex2;

    public int state;
    public GameObject camera;
    public GameObject move_camera;
    public GameObject move_char;
    public GameObject ui_camera;
    // Use this for initialization
    public GameObject die;
    void Start()
    {
        camera = GameObject.Find("edu_camera");
        state = 1;
        die = GameObject.Find("Eliza_Prefab3");
        //ui_camera = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            state = state + 1;

        }

    }
    void OnGUI()
    {
        if (state == 1)
        {
            GUI.DrawTexture(new Rect(0, 550, 900 ,200 ), ex1);
        }
        if (state == 2)
        {

            //Destroy(ex1);
            GUI.DrawTexture(new Rect(0, 550, 900, 200), ex2);
        }

        else if (state == 3)
        {
            //move_camera.GetComponent<move_not>().check = true;
            //Debug.Log(move_camera.GetComponent<move_not>().check);
            move_camera.SetActive(true);
            move_char.SetActive(true);
            die.SetActive(false);
            ui_camera.SetActive(true);
            //gameObject.SetActive(false);
            //Destroy(gameObject);
        }

    }
}
