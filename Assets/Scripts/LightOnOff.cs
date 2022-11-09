using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightOnOff : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject pointLight;
    public GameObject emissiveMat;
    public GameObject directLight;
    public GameObject spotLight;

    public Button pointButton;
    public Button emissiveButton;
    public Button directButton;
    public Button spotButton;

    public bool lightOneStat = true;
    public bool lightTwoStat = true;
    public bool lightThreeStat = true;
    public bool lightFourStat = true;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PointControl(){
        if (lightOneStat == true){
            pointLight.SetActive(false);
            lightOneStat = false;
        }
        else {
            pointLight.SetActive(true);
            lightOneStat = true;
        }
    }
    public void MatControl(){
        if (lightTwoStat == true){
            emissiveMat.SetActive(false);
            lightTwoStat = false; 
        }
        else {
            emissiveMat.SetActive(true);
            lightTwoStat = true;
        }
    }
    public void DirectControl(){
        if (lightThreeStat == true){
            directLight.SetActive(false);
            lightThreeStat = false;
        }
        else {
            directLight.SetActive(true);
            lightThreeStat = true;
        }
    }
    public void SpotControl(){
        if (lightFourStat == true){
            spotLight.SetActive(false);
            lightFourStat = false;
        }
        else {
            spotLight.SetActive(true);
            lightFourStat = true;
        }
    }
}
