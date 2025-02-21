using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Crusher_Command : MonoBehaviour
{
    //public so that crusher control slider can be refrence in inspector
    public Slider crusherSlider;
    //movement variable which determines distance of displacement when using slider
    public float movement;
    //snapshop of orignal crusher position so it can reset properly
    Vector2 pistonOrigin;
    // Start is called before the first frame update
    void Start()
    {
        //aquire starting crusher position
        pistonOrigin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //create temporary vector to modify sprites values
        Vector2 piston = transform.position;
        //original position is modified by displacement distance multipled by slider value (0 slider value cause no displacement)
        piston.y = pistonOrigin.y + (movement * crusherSlider.value);
        //add back to transfrom to modify sprite
        transform.position = piston;
    }

    public void SliderReset()
    {
        crusherSlider.value = 0;
    }
}
