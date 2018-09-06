using UnityEngine;
using System.Collections;

public class LookAtTarget : MonoBehaviour {

	public GameObject[] target;
    private GameObject lookingTarget;

	void Start () {
        transform.LookAt(target[0].transform);
    }
	
	// Update is called once per frame
	void Update () {
        float fov = Camera.main.fieldOfView;
        if (Input.GetKey(KeyCode.Alpha1))
        {
            lookingTarget = target[1];
            Camera.main.fieldOfView = Mathf.Atan(Vector3.Distance(lookingTarget.transform.position, transform.position) / lookingTarget.transform.localScale.x) * 2;
            fov = Camera.main.fieldOfView;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            lookingTarget = target[2];
            Camera.main.fieldOfView = Mathf.Atan(Vector3.Distance(lookingTarget.transform.position, transform.position) / lookingTarget.transform.localScale.x) * 2;
            fov = Camera.main.fieldOfView;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            lookingTarget = target[3];
            Camera.main.fieldOfView = Mathf.Atan(Vector3.Distance(lookingTarget.transform.position, transform.position) / lookingTarget.transform.localScale.x) * 2;
            fov = Camera.main.fieldOfView;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            lookingTarget = target[4];
            Camera.main.fieldOfView = Mathf.Atan(Vector3.Distance(lookingTarget.transform.position, transform.position) / lookingTarget.transform.localScale.x) * 2;
            fov = Camera.main.fieldOfView;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            lookingTarget = target[5];
            Camera.main.fieldOfView = Mathf.Atan(Vector3.Distance(lookingTarget.transform.position, transform.position) / lookingTarget.transform.localScale.x) * 2;
            fov = Camera.main.fieldOfView;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            lookingTarget = target[6];
            Camera.main.fieldOfView = Mathf.Atan(Vector3.Distance(lookingTarget.transform.position, transform.position) / lookingTarget.transform.localScale.x) * 2;
            fov = Camera.main.fieldOfView;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            lookingTarget = target[7];
            Camera.main.fieldOfView = Mathf.Atan(Vector3.Distance(lookingTarget.transform.position, transform.position) / lookingTarget.transform.localScale.x) * 2;
            fov = Camera.main.fieldOfView;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            lookingTarget = target[8];
            Camera.main.fieldOfView = Mathf.Atan(Vector3.Distance(lookingTarget.transform.position, transform.position) / lookingTarget.transform.localScale.x) * 2;
            fov = Camera.main.fieldOfView;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            lookingTarget = target[9];
            Camera.main.fieldOfView = Mathf.Atan(Vector3.Distance(lookingTarget.transform.position, transform.position) / lookingTarget.transform.localScale.x) * 2;
            fov = Camera.main.fieldOfView;
        }
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            lookingTarget = target[10];
            Camera.main.fieldOfView = Mathf.Atan(Vector3.Distance(lookingTarget.transform.position, transform.position) / lookingTarget.transform.localScale.x) * 2;
            fov = Camera.main.fieldOfView;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            lookingTarget = target[0];
            Camera.main.fieldOfView = 55f;
            fov = Camera.main.fieldOfView;
        }
        if (lookingTarget)
        {
            transform.LookAt(lookingTarget.transform);
            
        }

        fov += Input.GetAxis("Mouse ScrollWheel") * -2f;
        fov = Mathf.Clamp(fov, 0.01f, 90f);
        Camera.main.fieldOfView = fov;
    }
}
