using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Crusher_Command : MonoBehaviour
{
    public Slider crusherSlider;
    public float movement;
    Vector2 pistonOrigin;
    // Start is called before the first frame update
    void Start()
    {
        pistonOrigin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 piston = transform.position;

        piston.y = pistonOrigin.y + (movement * crusherSlider.value);
        transform.position = piston;
    }
}
