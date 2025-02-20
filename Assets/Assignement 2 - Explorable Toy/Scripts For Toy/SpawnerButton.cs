using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerButton : MonoBehaviour
{
    //control script to instantiate particles in background

    //create public game object
    public GameObject particle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //public function to be called by button
    //spawns particle
    public void SpawnParticle()
    {
        //spawn particle
        Instantiate(particle);
    }
}
