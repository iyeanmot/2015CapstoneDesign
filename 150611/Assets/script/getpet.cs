using UnityEngine;
using System.Collections;

public class getpet : MonoBehaviour {
    public bool fire_attack;
    public int extingItem3;
    public GameObject man3;
    public GameObject extinguisher_man3;
	// Use this for initialization
	void Start () {
        fire_attack = false;
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (extingItem3 == 1)
        {
            extinguisher_man3.SetActive(true);
            extinguisher_man3.transform.position = man3.transform.position;
            extinguisher_man3.transform.rotation = man3.transform.rotation;
            man3.SetActive(false);
        }
    }
    void OnTriggerEnter(Collider col)
    {
    }
}
