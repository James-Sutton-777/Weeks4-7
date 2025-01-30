using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public SpriteRenderer sr;
    //refrence itself, usually done in a seperate script
    public EnableDisable script;

    public GameObject go;

    public AudioSource audioS;
    public AudioClip ac;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            //sr.enabled = false;

            //script.enabled = false;
            //go.SetActive(false);
            
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //sr.enabled = true;

            //script.enabled = true;

            //go.SetActive(true);
            audioS.PlayOneShot(ac);

        }
        
        if(Input.GetKey(KeyCode.Space))
        {
            //so it only plays when no audio is playing
            if (audioS.isPlaying == false)
            {
                //audioS.Play();
                //audioS.PlayOneShot(ac);
            }
        }
    }
}
