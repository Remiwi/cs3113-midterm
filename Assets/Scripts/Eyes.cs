using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    Transform eyes;
    Camera cam;
    [SerializeField] float maxDistance = 1f;

    void Start()
    {
        eyes = transform.GetChild(0).transform;
        cam = Camera.main;
    }

    void Update()
    {
        if (Input.GetJoystickNames().Length == 0)
        {
            Vector3 mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
            Vector3 camPos = cam.transform.position;
            Vector3 pos = (mousePos - camPos);
            pos.x = 2 * (1 / (1 + Mathf.Exp(-pos.x))) - 1;
            pos.y = 2 * (1 / (1 + Mathf.Exp(-pos.y))) - 1;
            pos.z = 0;
            eyes.localPosition = pos * maxDistance;
        }
        else {
            Vector3 pos = new Vector3(Input.GetAxis("Horizontal2"), Input.GetAxis("Vertical2"), 0);
            eyes.localPosition = pos * maxDistance;
        }
    }
}
