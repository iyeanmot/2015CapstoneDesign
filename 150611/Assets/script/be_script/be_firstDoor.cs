using UnityEngine;
using System.Collections;

public class be_firstDoor : MonoBehaviour
{

    public float fullyOpenYAngle = 100f;
    public bool isNegativeDirection = false;

    private float fullyClosedYAngle;
    private float currentYAngleOffset = 0f;

    private bool isRunning_CoOpenDoor;
    private IEnumerator coOpenDoor;

    private bool isOpen = false;

    public GameObject _Doorknob;
    public GameObject _Click;

    void OnDisable()
    {
        isRunning_CoOpenDoor = false;
    }

    void Start()
    {
        fullyClosedYAngle = transform.localRotation.eulerAngles.y;
    }

    protected virtual void OnTriggerStay(Collider other)
    {
        if (isOpen)
        {
            return;
        }

        if (other.gameObject.CompareTag("Player") )
        {
            _Click.SetActive(true);
        }

        if (other.gameObject.CompareTag("Player") &&
            _Doorknob.GetComponent<be_doorknob>().OpenDoor)
        {
            Debug.Log("ddddd");
            _Doorknob.SetActive(false);
            _Click.SetActive(false);
            Open();
        }
    }
    protected virtual void OnTriggerExit(Collider other)
    {
        _Click.SetActive(false);
    }

    public void Open()
    {
        if (!isRunning_CoOpenDoor)
        {
            coOpenDoor = CoOpenDoor();
            StartCoroutine(coOpenDoor);
        }
    }

    private IEnumerator CoOpenDoor()
    {
        isRunning_CoOpenDoor = true;

        while (currentYAngleOffset < fullyOpenYAngle)
        {
            if (currentYAngleOffset < fullyOpenYAngle - 1f)
            {
                currentYAngleOffset = Mathf.Lerp(currentYAngleOffset, fullyOpenYAngle, .1f);
            }
            else
            {
                currentYAngleOffset = fullyOpenYAngle;
            }
            transform.localRotation = Quaternion.Euler(transform.localRotation.x, ((isNegativeDirection ? -currentYAngleOffset : currentYAngleOffset) + fullyClosedYAngle), transform.localRotation.z);

            yield return null;
        }

        isOpen = true;
        isRunning_CoOpenDoor = false;
    }
}
