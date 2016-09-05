using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class be_yellcount : MonoBehaviour {

    public Texture2D[] explain = new Texture2D[4];
    public AudioClip voice;

    GameObject _board;
    GameObject _EduCamera;

    float OnTime;
    public int i;

	// Use this for initialization
	void Start () {
        i = -1;
        gameObject.SetActive(false);
        _board = GameObject.Find("educationUI");
        _EduCamera = GameObject.Find("edu_camera");
        OnTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

        if (Time.time - OnTime > 1)
        {
            if (gameObject.GetComponent<RawImage>().texture == explain[3])
            {
                gameObject.SetActive(false);
                _board.GetComponent<be_select_edu>().now_edu = _board.GetComponent<be_select_edu>().edu3;
                _board.GetComponent<be_select_edu>()._state = 0;
                _board.GetComponent<be_select_edu>().edu3_finished = true;
                _EduCamera.GetComponent<sm_eduboard>().isON = false;
            }
            if (i < 3)
            {
                i = i + 1;
                gameObject.GetComponent<RawImage>().texture = explain[i];

                if (i == 3)
                {
                    audio.PlayOneShot(voice);
                }
                  }
            OnTime = Time.time;


            Debug.Log(i);

        }

        
	}

}
