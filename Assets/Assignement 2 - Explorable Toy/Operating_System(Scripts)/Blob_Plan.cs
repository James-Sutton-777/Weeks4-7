using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blob_Plan : MonoBehaviour
{
    public AnimationCurve idle;
    [Range(0, 1)]
    public float b;

    bool neutral = true;
    bool flatten = false;
    bool perish = false;
    float timer = 0;
    public float rate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        Debug.Log(timer);
        if(neutral == true)
        {
            Idle();
        }
    }

    void Idle()
    {
        b = timer % rate;

        Vector2 animOne = transform.localScale;
        animOne.y = Mathf.Lerp(0.8f, 1.2f, idle.Evaluate(b));
        animOne.x = Mathf.Lerp(0.8f, 1.2f, idle.Evaluate(b));
        transform.localScale = animOne;
    }
}
