using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class be_edu3 : MonoBehaviour
{

    public Texture2D explain_1;
    public Texture2D explain_2;

    public GameObject yellcount;
    GameObject _board;
    GameObject _EduCamera;


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

        if (_board.GetComponent<be_select_edu>().now_edu == this.gameObject)
        {
            if (_board.GetComponent<be_select_edu>()._state == 1)
                gameObject.GetComponent<RawImage>().texture = explain_2;
            if (_board.GetComponent<be_select_edu>()._state >= 2)
            {
                gameObject.SetActive(false);
                yellcount.SetActive(true);
            }



        }
    }
}
