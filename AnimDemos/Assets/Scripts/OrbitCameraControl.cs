using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitCameraControl : MonoBehaviour
{

    /// <summary>
    /// the tilt of the cam in degrees
    /// </summary>
    float pitch = 0;
    float targetPitch = 0;
    /// <summary>
    /// the ya angle of the camera rig in degrees
    /// </summary>
    float yaw = 0;
    float targetYaw = 0;
    /// <summary>
    /// how far away the camera should be from its target, in meters
    /// </summary>
    float dollyDis = 10;
    float targetDollyDis = 10;
    /// <summary>
    /// scales horizontal 
    /// </summary>
    public float mouseSensitivityY = 1;
    /// <summary>
    /// scalse vertical
    /// </summary>
    public float mouseSensitivityX = 1;

    public float mouseScrollMultiplier = 5;

    private Camera cam;

    void Start()
    {
        cam = GetComponentInChildren<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            // changing the pitch
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            targetYaw += mouseX * mouseSensitivityX;
            targetPitch += mouseY * mouseSensitivityY;
        }


        float scroll = Input.GetAxisRaw("Mouse ScrollWheel");
        targetDollyDis += scroll * mouseScrollMultiplier;
        targetDollyDis = Mathf.Clamp(targetDollyDis, 2.5f, 15f);

        dollyDis = AnimMath.Slide(dollyDis, targetDollyDis, .05f);// EASE

        cam.transform.localPosition = new Vector3(0, 0, -dollyDis);

        targetPitch = Mathf.Clamp(targetPitch, -89, 89);

        pitch = AnimMath.Slide(pitch, targetPitch, .05f); //EASE
        yaw = AnimMath.Slide(yaw, targetYaw, .05f); // EASE

        transform.rotation = Quaternion.Euler(pitch, yaw, 0);
        

    }
}
