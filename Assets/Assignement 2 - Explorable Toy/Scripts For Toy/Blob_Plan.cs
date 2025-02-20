using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blob_Plan : MonoBehaviour
{

    //public Slider squashSlider;

    SpriteRenderer burn;

    public AnimationCurve idle;
    [Range(0, 1)]
    public float b;

    public bool neutral = true;
    public bool flatten = false;
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
        
        if(neutral == true)
        {
            Idle();
        }

        if (perish == true)
        {
            Gonzo();
        }
       // if(squashSlider.value > 0)
       // {
        //    neutral = false;
       //     Squish();
       // }
        else if(perish == false)
        {
            neutral = true;
        }

        Die();
    }

    void Idle()
    {
        b = timer % rate;

        Vector2 animOne = transform.localScale;
        animOne.y = Mathf.Lerp(0.8f, 1.2f, idle.Evaluate(b));
        animOne.x = Mathf.Lerp(0.8f, 1.2f, idle.Evaluate(b));
        transform.localScale = animOne;
    }
    
    public void Gonzo()
    {
        neutral = false;
        flatten = false;
        perish = true;

        Vector2 animTwo = transform.localScale;
        if (animTwo.y >= 0)
        {
            animTwo.y -= perishRate;
            animTwo.x -= perishRate;
            transform.localScale = animTwo;
        }

        Color burnt = burn.color;
        burnt.b -= 1;
        burnt.g -= 1;
        burnt.r -= 1;
        burn.color = burnt;
    }

    public void Squish()
    {
        //Vector2 animTre = transform.localScale;
        
           // animTre.y = 1 - squashSlider.value;
            //transform.localScale = animTre;
     
    }

    public void Die()
    {
        Vector2 lifeInsurance = transform.localScale;
        if (lifeInsurance.y <= 0)
        {
            Destroy(gameObject);
        }


    }
}
