using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightChange : MonoBehaviour
{

    public Slider pointSlider;
    public Light pointLight;
    public Slider directSlider;
    public Light directLight;
    public Slider spotSlider;
    public Light spotLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pointLight.intensity = pointSlider.value;
        directLight.intensity = directSlider.value;
        spotLight.intensity = spotSlider.value;
    }
}
