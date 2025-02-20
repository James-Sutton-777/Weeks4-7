using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blob_Plan : MonoBehaviour
{

    public Slider squashSlider;

    SpriteRenderer burn;

    public AnimationCurve idle;
    [Range(0, 1)]
    public float b;

    public bool neutral = true;
    public bool perish = false;
    float timer = 0;
    public float rate;
    public float perishRate;
    // Start is called before the first frame update
    void Start()
    {
        burn = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        
        if((neutral == true) && (perish == false))
        {
            Idle();
        }

        if(squashSlider.value > 0)
        {
            neutral = false;
            Squish();
        }
        else
        {
            neutral = true;
        }
        
        if(squashSlider.value == 1)
        {
            perish = true;

        }
    }

    void Idle()
    {
        b = timer % rate;

        Vector2 animOne = transform.localScale;
        animOne.y = Mathf.Lerp(2.4f, 3, idle.Evaluate(b));
        animOne.x = Mathf.Lerp(2.4f, 3, idle.Evaluate(b));
        transform.localScale = animOne;
    }
    

    public void Squish()
    {
        if (perish == false)
        {
            Vector2 animTre = transform.localScale;

            animTre.y = 3 - (3 * squashSlider.value);
            transform.localScale = animTre;
        }
     
    }

    public void ResetBlob()
    {
        perish = false;
        neutral = true;
    }
}
