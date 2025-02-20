using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Light_control : MonoBehaviour
{
    bool lights = false;
    SpriteRenderer darkness;
    public AnimationCurve flicker;
    [Range(0, 1)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        darkness = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Color alpha = darkness.color;
        alpha.a = Mathf.Lerp(0, 0.9f, flicker.Evaluate(t));
        darkness.color = alpha;
        
        if (lights == true)
        {
           t -= 2 * Time.deltaTime;
        }
        
        if(lights == false)
        {
            t += 2 * Time.deltaTime;

        }
    }

    public void SwitchPressed()
    {
        lights = !lights;
    }
}
