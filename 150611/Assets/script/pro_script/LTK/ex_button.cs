using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//  using 
public class ex_button : MonoBehaviour
{
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
       
        //audio.Play(shoot);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ButtonClick()
    {
        main_camera.SetActive(false);
        ex_camera.SetActive(true);
        fire_camera.SetActive(false);
        sm_camera.SetActive(false);
        de_camera.SetActive(false);
        //audio.PlayOneShot(shoot); 
        audio.PlayOneShot(button_click);
    }
}
