using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Blob_Plan : MonoBehaviour
{
    //This allows input of slider control for crusher mechanism
    public Slider squashSlider;

    //Animation curve to control enable idle animation behaviour
    public AnimationCurve idle;
    //Range for modifier vairable used in idle animation
    [Range(0, 1)]
    public float b;

    //booleans to determine Blob state to organize functions
    public bool neutral = true;
    public bool perish = false;

    //timer used in combination with rate to control idle animation frequency
    float timer = 0;
    public float rate;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Timer math to maintain continuous count up
        timer += 1 * Time.deltaTime;
        
        //condition to play idle animation
        if((neutral == true) && (perish == false))
        {
            Idle();
        }

        //condition to cease idle animation and squish Blob
        //else return to idle animation when cursher is lifted
        if(squashSlider.value > 0)
        {
            neutral = false;
            //calls squish animation function
            Squish();
        }
        else
        {
            neutral = true;
        }
        //condition to hide Blob with scale when completely crushed
        if(squashSlider.value == 1)
        {
            perish = true;

        }
    }
    //Function containing idle animation
    //idle animation is created by modifying the scale of Blob with a lerp function
    void Idle()
    {
        //timer modulous by rate to control animation speed
        b = timer % rate;

        //idle animation is created by modifying the scale of Blob with a lerp function

        //temporary vector2 to modify scale values
        Vector2 animOne = transform.localScale;
        //modifying scale values using lerp between minimum and maximum size
        animOne.y = Mathf.Lerp(2.4f, 3, idle.Evaluate(b));
        animOne.x = Mathf.Lerp(2.4f, 3, idle.Evaluate(b));
        //add back to transfrom causing sprite to be altered
        transform.localScale = animOne;
    }
    
    //squish function cause flattening animation of Blob
    public void Squish()
    {
        //condition preventing transformation when Blob is flattened
        if (perish == false)
        {
            //Create temporary vector to modify Blob scale values
            Vector2 animTre = transform.localScale;
            //modify scale values by current slider value which controls the crusher
            animTre.y = 3 - (3 * squashSlider.value);
            //add back to transform causing sprite to be altered
            transform.localScale = animTre;
        }
     
    }
    //public to be called by button
    //function reset Blob values when correct button is pressed
    public void ResetBlob()
    {
        //reset booleans to starting state
        perish = false;
        neutral = true;
    }
}
