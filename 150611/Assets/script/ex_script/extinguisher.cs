using UnityEngine;
using System.Collections;

public class extinguisher : MonoBehaviour
{
    //public bool fire;
    public GameObject player;
    public GameObject camera;
    public GameObject gotexting; //습득한 서화기

        void Start()
    {
        player = GameObject.Find("Player");
        camera = GameObject.Find("Main Camera");
        gotexting = GameObject.Find("get_extinguisher");//습득한 소화기

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider col)
    {
        if (Input.GetMouseButtonDown(0)) //소화기습득
        {
            if (col.name == "Player")
            {
                player.GetComponent<getItem>().getexing = true;
                gameObject.SetActive(false); // 놓인 소화기 비활성

            }
        }
    }
    void OnTriggerExit(Collider col)
    {
        player.GetComponent<getItem>().getexing = false;
    }
}
