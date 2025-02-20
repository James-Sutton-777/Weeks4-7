using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlobExtractor : MonoBehaviour
{
    public Slider slider;
    public Slider refrenceSlider;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
      
        slider.value = refrenceSlider.value;
    }
}
