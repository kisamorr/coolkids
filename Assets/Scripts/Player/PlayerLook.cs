using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Transform target;

    public Camera cam;
    private float xRotation = 0f;
    private float yRotation = 0f;

    public float xSensitivity = 15f;
    public float ySensitivity = 15f;

    public bool InvertY;

    public float rotationSmoothing = 10;
    public float rotationSensitivity = 7;
    public float distance = 10;
    public float VerticalRotLimit = 40;

    private Vector3 _angle = new Vector3();
    private Quaternion _oldRotation = new Quaternion();

    private Transform _t;

    public Vector2 CurrentRotation { get { return _angle; } }



    public void ClampAngle(ref Vector3 angle)
    {
        if (angle.x < -180) angle.x += 360;
        else if (angle.x > 180) angle.x -= 360;

        if (angle.y < -VerticalRotLimit) angle.y = -VerticalRotLimit;
        else if (angle.y > VerticalRotLimit) angle.y = VerticalRotLimit;

        if (angle.z < -180) angle.z += 360;
        else if (angle.z > 180) angle.z -= 360;
    }

    private void Update()
    {
        if(target)
        {
            _angle.x += Input.GetAxis("Mouse X") * rotationSensitivity;

            if (InvertY)
            {
                _angle.y -= Input.GetAxis("Mouse Y") * rotationSensitivity;
            }
            else
            {
                _angle.y += Input.GetAxis("Mouse Y") * rotationSensitivity;
            }

            ClampAngle(ref _angle);

        }
    }

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -15f, 15f);

        yRotation += (mouseX * Time.deltaTime) * xSensitivity;

        //// apply this to camera transform
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        transform.rotation = Quaternion.Euler(xRotation, yRotation, transform.rotation.z);

        //Debug.Log($"camera rotation is {cam.transform.localRotation}");
    }

    void LateUpdate()
    {
        if (target)
        {
            Quaternion angleRotation = Quaternion.Euler(_angle.y, _angle.x, 0);
            Quaternion currentRotation = Quaternion.Lerp(_oldRotation, angleRotation, Time.deltaTime * rotationSmoothing);

            _oldRotation = currentRotation;

           // _t.position = target.position - currentRotation * Vector3.forward * distance;
           // _t.LookAt(target.position, Vector3.up);
        }
    }
    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector3(1, 1, 1));

    }

}
