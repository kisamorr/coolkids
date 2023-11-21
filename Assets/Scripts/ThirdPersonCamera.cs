using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCamera : MonoBehaviour
{
    public Camera playerCamera;
    public float elevation;
    public float distance;

    // ONLY USE THIS IF U HAVE ONE 3POV CAM
    public static ThirdPersonCamera instance;

    float currentScreenshake;
    // 

    private void Awake()
    {
        instance = this;
    }

    void Update()
    {

        //decay screenshake
        currentScreenshake *= 1 - Time.deltaTime;


        //position
        Vector3 idealCamPosition = transform.position;
        idealCamPosition -= transform.forward * distance;
        idealCamPosition += Vector3.up * elevation;

        // creates JITTER
        if (currentScreenshake > 0.001f)
        {
            idealCamPosition.x += Random.Range(-currentScreenshake, currentScreenshake);
            idealCamPosition.y += Random.Range(-currentScreenshake, currentScreenshake);
            idealCamPosition.z += Random.Range(-currentScreenshake, currentScreenshake);
        }

        float cameraTrackSpeed = 2.5f;
        playerCamera.transform.position = Vector3.Lerp(playerCamera.transform.position, idealCamPosition, cameraTrackSpeed * Time.deltaTime);
        // after every frame the camera will be 50% closer to the idealCamPosition


        //rotation
        Vector3 idealCamTarget = transform.position;

        if (currentScreenshake > 0.001f)
        {
            idealCamTarget.x += Random.Range(-currentScreenshake, currentScreenshake) * 0.1f;
            idealCamTarget.y += Random.Range(-currentScreenshake, currentScreenshake) * 0.1f;
            idealCamTarget.z += Random.Range(-currentScreenshake, currentScreenshake) * 0.1f;
        }


        Vector3 direction = (idealCamTarget - playerCamera.transform.position).normalized;
        playerCamera.transform.rotation = Quaternion.LookRotation(direction);

    }

    public void AddScreenShake(float magnitude, Vector3 epicenter)
    {
        currentScreenshake += magnitude / Vector3.Distance(playerCamera.transform.position, epicenter);
        // decays based off of distance of camera from player
    }
}
