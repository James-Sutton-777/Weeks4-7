using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Light_control : MonoBehaviour
{
    //boolean determining if lights are on or off
    bool lights = false;
    //spriterender to alter component values
    SpriteRenderer darkness;
    //animation curve to determine light behaviour when turn off or on
    public AnimationCurve flicker;
    //ranged float controls black screen alpha
    [Range(0, 1)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        //assign objects spriterender component to modifiable variable
        darkness = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //create temporary color variable to alter values
        Color alpha = darkness.color;
        //use lerp function to alter alpha based on t value
        alpha.a = Mathf.Lerp(0, 0.9f, flicker.Evaluate(t));
        //add back to spriterender to modify sprite
        darkness.color = alpha;
        
        //when boolean is true alpha decrease revealing scene
        if (lights == true)
        {
           t -= 2 * Time.deltaTime;
        }

        //when boolean is true alpha increase hiding scene
        if (lights == false)
        {
            t += 2 * Time.deltaTime;

        }
    }

    //public function that can be called by button
    //switches state of light boolean
    public void SwitchPressed()
    {
        //set lights boolean to opposite value of current state
        lights = !lights;
    }
}
