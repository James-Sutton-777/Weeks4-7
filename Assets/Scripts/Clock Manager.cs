using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager : MonoBehaviour
{
    public Transform hand;
    public Transform birb;
    public AudioSource chirp;
    public AudioClip kak;
    float h = 0;
    float p = 30;
    float t = 0;
    float a = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hand.rotation.eulerAngles.z);
        Debug.Log(h);
        t += 3 * Time.deltaTime;
        if(t == 30)
        {
            t = 0;
            a += 1;
            Vector3 size = birb.transform.localScale;
            size.x = 1;
            size.y = 1;
            birb.transform.localScale = size;
            chirp.PlayOneShot(kak);
        }
        if(a == 12)
        {
            a = 0;
        }

        


        
       
            hourCheck();
       

    }

    void hourCheck()
    {
        h = (12 -(hand.rotation.eulerAngles.z/p));
    }
}
