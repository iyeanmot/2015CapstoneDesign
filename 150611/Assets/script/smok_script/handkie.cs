using UnityEngine;
using System.Collections;

public class handkie : MonoBehaviour
{
    //public bool fire;
    public GameObject player;
    public GameObject click;
    // Use this for initialization
    //new Vector3 changePosition;


    void Start()
    {
        //changePosition = camera.transform.position;

        //changePosition.x = changePosition.x + 1;
        //changePosition.y = changePosition.y + 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider col)
    {

        click.SetActive(true);
        if (Input.GetMouseButtonDown(0))
        {
            if (col.name == "Player")
            {
                player.GetComponent<sm_Item>().gethanki = true;
                click.SetActive(false);
                gameObject.SetActive(false);
            }
        }

    }
	void OnTriggerExit(Collider col)
	{
		click.SetActive(false);
	}
}
