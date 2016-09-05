using UnityEngine;
using System.Collections;

public class fire_hp_check : MonoBehaviour {
    public int hp;
    public bool hp_check;
    public GameObject hp_object;
	// Use this for initialization
	void Start () {
        hp = 10;
        hp_check = false;
        hp_object = GameObject.Find("First Person Controller");
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.localScale = new Vector3(gameObject.transform.localScale.x * hp / 10, gameObject.transform.localScale.y * hp / 10, gameObject.transform.localScale.z * hp / 10);

        if (hp_check == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (hp > 0)
                {
                    hp -= 1;
                    Debug.Log(hp);
                }
                else if (hp <= 4)
                {
                    hp_check = false;
                    Application.LoadLevel(0);

                }
            }
        }
	}
    void OnTriggerEnter(Collider col)
    {
        hp_check = true;
    }
    void OnTriggerExit(Collider col)
    {
        hp_check = false;
        //Debug.Log("2");
    }
}
