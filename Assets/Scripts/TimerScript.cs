using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    Slider slider;
    float t;
    void Start()
    {
        //This only works if the script is only used in one object. Otherwise we would have to make it public before the start up
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        slider.value = t % slider.maxValue;
    }
}
