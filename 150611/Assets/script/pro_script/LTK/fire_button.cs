using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class fire_button : MonoBehaviour {

    public GameObject main_camera;
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
        main_camera.SetActive(false);
        ex_camera.SetActive(false);
        fire_camera.SetActive(true);
        sm_camera.SetActive(false);
        de_camera.SetActive(false);audio.PlayOneShot(button_click);
    }
}
