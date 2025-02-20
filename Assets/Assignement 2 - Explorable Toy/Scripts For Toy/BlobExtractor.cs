using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlobExtractor : MonoBehaviour
{
    //public slider so that it can recognize itself
    //unity was complainging about null refrence and this fixed it
    public Slider slider;
    //slider public to be linked to control slider
    public Slider refrenceSlider;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      //updates extrator slider in correlation to crusher control slider
        slider.value = refrenceSlider.value;
    }
}
