using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class main_camera : MonoBehaviour {

    public GameObject main_camera1;
    public GameObject ex_camera;
    public GameObject fire_camera;
    public GameObject sm_camera;
    public GameObject de_camera;
     public AudioClip button_click;
    
    // Use this for initialization
    void Start()
    {
        //버튼 클릭 했을시 해당 함수 실행.
        GetComponent<Button>().onClick.AddListener(() => ButtonClick());
    }

    // Update is called once per frame
    void Update()
    {

    }
    void ButtonClick()
    {
        Application.LoadLevel(0);
        audio.PlayOneShot(button_click);
    }
}
