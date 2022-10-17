using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CamSwitch : MonoBehaviour
{
    public GameObject fpCam;
    public GameObject threepCam;
    public GameObject sceneCam;
    public GameObject motionCam;

    public Button fpButton;
    public Button threepButton;

    public Button sceneButton;

    public Button motionButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateCamOne(){
        fpCam.SetActive(true);
        threepCam.SetActive(false);
        sceneCam.SetActive(false);
        motionCam.SetActive(false);
    }

    public void ActivateCamTwo(){
        fpCam.SetActive(false);
        threepCam.SetActive(true);
        sceneCam.SetActive(false);
        motionCam.SetActive(false);
    }

    public void ActivateCamThree(){
        fpCam.SetActive(false);
        threepCam.SetActive(false);
        sceneCam.SetActive(true);
        motionCam.SetActive(false);
    }

    public void ActivateCamFour(){
        fpCam.SetActive(false);
        threepCam.SetActive(false);
        sceneCam.SetActive(false);
        motionCam.SetActive(true);
    }
}
