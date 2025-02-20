using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpawnerButton : MonoBehaviour
{
    public GameObject Blob;
    public Slider flattened;

    bool alive = false;
    bool noSpawn = false;
    GameObject CurrentBlob;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(alive == true)
        {
            Vector2 checker = CurrentBlob.transform.localPosition;
            if(checker.y <= 0.1)
            {
                alive = false;
            }

            if(flattened.value == 1)
            {
                alive = false;
                noSpawn = true;
            }
        }
    }

    public void NewBlob()
    {
        if(alive == false && noSpawn == false)
        {
        
        alive = true;
        Instantiate(Blob);
        CurrentBlob = Blob;
        }
    }

    public void Terminate()
    {
        //CurrentBlob.Gonzo();
    }

}
