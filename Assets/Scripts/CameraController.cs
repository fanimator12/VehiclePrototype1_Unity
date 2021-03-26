using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Camera[] cameras;
    private int currentCameraIndex;

    // Start is called before the first frame update
    void Start()
    {
        currentCameraIndex = 0;
        
        // Turn off every camera except the first default one
        for (int i = 1; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(false);
        }

        // If any cameras were added to the controller, enable the first one
        if (cameras.Length > 0)
        {
            cameras[0].gameObject.SetActive(true);
            Debug.Log("Camera with name: " + cameras[0] + ", is now enabled");
        }
    }

    // Update is called once per frame
    void Update()
    {
        // If the c button is pressed, switch to the next camera
        if (Input.GetKeyDown(KeyCode.C))
        {
            cameras[currentCameraIndex].enabled = false;
            if (currentCameraIndex++ > cameras.Length - 1) currentCameraIndex = 0;
            cameras[currentCameraIndex].enabled = true;
        }
    }
}
