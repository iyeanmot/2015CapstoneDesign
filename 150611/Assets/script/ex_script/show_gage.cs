using UnityEngine;
using System.Collections;

public class show_gage : MonoBehaviour
{
    //public bool isshow_gage;
   // public GameObject player;

    public GameObject sting;
    public GameObject fire;
    public bool test;
    //public GameObject fire_hp;

    public float fire_hp_delta;
    
    //public bool On_fire1;
    //public bool On_fire2;
    //public bool On_fire3;

    //public bool ismove;
    // Use this for initialization
    void Awake()
    {
        gameObject.SetActive(false);
       
    }
    void Start()
    {
        test = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (test)
        {
            sting.transform.eulerAngles = new Vector3(0, 0, 0);
            test = false;
        }
        else 
            sting.transform.Rotate(new Vector3(0, 0, 1), fire_hp_delta *4 * 20 * Time.deltaTime);

        //if (sting.transform.rotation.z > 0)
        //{
        //    fire_hp_delta = -0.5f;
        //    sting.transform.Rotate(new Vector3(0, 0, 1), fire_hp_delta * 16 / 5 * 2 * Time.deltaTime);
        //}
    }

}
