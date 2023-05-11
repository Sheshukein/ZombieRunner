using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class WeaponZoom : MonoBehaviour
{
    [SerializeField] Camera fpsCamera;
    [SerializeField] float zoomedOutFOV = 60f;
    [SerializeField] float zoomedInFOV = 20f;
    [SerializeField] float zoomOutSensitivity = 2f;
    [SerializeField] float zoomInSensitivity = 0.5f;

    [SerializeField] FirstPersonController fpsController;

    bool zoomedInToggle = false;

    void OnDisable()
    {
        ZoomOut();
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(1))
        {
            if(zoomedInToggle == false)
            {
                ZoomIn();
            }
            else
            {
                ZoomOut();
            }

        }
    }

    public void ZoomIn()
    {
        zoomedInToggle = true;
        fpsCamera.fieldOfView = zoomedInFOV;
        fpsController.m_MouseLook.XSensitivity = zoomInSensitivity;
        fpsController.m_MouseLook.YSensitivity = zoomInSensitivity;
    }

    public void ZoomOut()
    {
        fpsCamera.fieldOfView = zoomedOutFOV;
        zoomedInToggle = false;
        fpsController.m_MouseLook.XSensitivity = zoomOutSensitivity;
        fpsController.m_MouseLook.YSensitivity = zoomOutSensitivity;
    }
}
