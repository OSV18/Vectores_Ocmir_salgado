using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] int Camera;
    [SerializeField] GameObject[] cameras;




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ShowCam();
    }


    /*    
        void ActivateCameras()
        {
            switch (Camera)
            {
                case 1:
                    Input.GetKeyDown(KeyCode.F1);
                    cameras[0].SetActive(true);
                    break;

                case 2:
                    Input.GetKeyDown(KeyCode.F2);
                    cameras[1].SetActive(true);
                    break;

                case 3:
                    Input.GetKeyDown(KeyCode.F3);
                    cameras[2].SetActive(true);
                    break;
            }

        }

    */
    void ShowCam()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            cameras[0].SetActive(true);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(true);
            cameras[2].SetActive(false);
            cameras[3].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(true);
            cameras[3].SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F4))
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(false);
            cameras[2].SetActive(false);
            cameras[3].SetActive(true);
        }
    }

}