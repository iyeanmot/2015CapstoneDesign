using UnityEngine;
using System.Collections;

public class fire_hp : MonoBehaviour
{
    public float hp;                                //불 생명
    float hp_max;
    public bool hp_check;                           //불 변화량 측정 및 게이지 표현
    public bool fire_check;                         //불 끄기 on/off 소화기를 가지고 있을 때
    public GameObject exting_man;                   //주인공
    public GameObject exting;
    public float delta_hp;                          //hp변화량
    public GameObject gage;

    bool be_small;
    //변화량 체크에 필요한 시간 및 변수
    float Ontime;
    float before_hp;

    Vector3 basic_scale;

    // Use this for initialization
    void Start()
    {
        //alpha = 0;
        //exting_man = GameObject.Find("Player");
        //exting = GameObject.Find("get_extinguisher");
        hp = 100;

        fire_check = false;
        Ontime = Time.time;


        basic_scale = gameObject.transform.localScale;
        hp_max = 100;
        be_small = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (fire_check)     //불끄기 On
        {
            if (Input.GetMouseButtonDown(0))
            {
                exting.GetComponent<gotexting>().spreadExting();

                if (hp > 0)
                {
                    hp -= 10;
                    be_small = true;
                    //hp에 따른 불 크기 조절 

                }
            }
        }

        if (hp <= 0)
        {
            //gage.GetComponent<show_gage>().reset();
            gage.SetActive(false);
            
            Destroy(gameObject);        //불 사라짐
            hp_check = false;
            fire_check = false;
            exting_man.GetComponent<getItem>().firecheck1 = false;
            // exting_man.GetComponent<getItem>().isSuccess = true;
            Debug.Log(exting_man.GetComponent<getItem>().firecheck1);
        }

        if (hp_check)
        {
            gage.SetActive(true);//게이지 On

            if (hp > 100)
                hp = 100;
            else

                hp = hp + 0.5f;
        }
        if (Time.time - Ontime < 0.5f)
        {
            delta_hp = before_hp - hp;
            before_hp = hp;
            //Debug.Log(delta_hp);
            Ontime = Time.time;

            gage.GetComponent<show_gage>().fire_hp_delta = delta_hp;
        }
        //불 작아지기
        if (be_small)
        {
            gameObject.transform.localScale = new Vector3(basic_scale.x * (hp / hp_max),
                                                          basic_scale.y * (hp / hp_max),
                                                          basic_scale.z * (hp / hp_max));
            be_small = false;
            // be_big = true;
            // Debug.Log(gameObject.transform.localScale.x);

        }
        //불 커짐
        if (gameObject.transform.localScale.x >= basic_scale.x ||
gameObject.transform.localScale.y >= basic_scale.y ||
gameObject.transform.localScale.z >= basic_scale.z)
        {

        }
        else
        {
            gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * 1.005f,
                                              gameObject.transform.localScale.y * 1.005f,
                                              gameObject.transform.localScale.z * 1.005f);
        }



    }
    void OnTriggerEnter(Collider col)
    {
        if (exting_man.GetComponent<getItem>().getexing)
        {
            fire_check = true;  //소화기를 가지고 불에 들어옴
            hp_check = true;    //게이지 On 변화량 측정 시작

        }
        //gage.GetComponent<show_gage>().test = true;
        //Debug.Log(exting_man.GetComponent<getItem>().getexing);

    }
    void OnTriggerStay(Collider col)
    {

    }
    void OnTriggerExit(Collider col)
    {

        gage.SetActive(false);
        fire_check = false;  //소화기를 가지고 불에 들어옴
        hp_check = false;    //게이지 On 변화량 측정 시작
    }


}
