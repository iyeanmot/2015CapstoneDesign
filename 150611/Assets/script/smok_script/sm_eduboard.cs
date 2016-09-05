using UnityEngine;
using System.Collections;

public class sm_eduboard : MonoBehaviour {

    GameObject _board;
    public GameObject _player;
    public bool isON;

	// Use this for initialization
	void Start () {

        _board = GameObject.Find("educationUI");
        isON = true;
	}
	
	// Update is called once per frame
	void Update () {


        //카메라 끄기
        if (!isON)
        {
            gameObject.SetActive(false);
            _player.SetActive(true);
        }
	
	}
    public void Move_Camera(Vector3 Player_Position)
    {
        gameObject.transform.position = Player_Position;
    }
}
