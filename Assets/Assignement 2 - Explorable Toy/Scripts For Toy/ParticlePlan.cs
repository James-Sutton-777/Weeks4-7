using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ParticlePlan : MonoBehaviour
{
    //animation curve controling particle x axis movement
    public AnimationCurve curveX;
    //float and range modifying x axis position
    [Range(0,1)]
    public float xAxis;
    //animation curve controling particle y axis movement
    public AnimationCurve curveY;
    //float and range modifying y axis position
    [Range(0,1)]
    float yAxis;

    //vector for start position of particle
    Vector2 start;
    //vector for end position of particle
    Vector2 end;

    // Start is called before the first frame update
    void Start()
    {
        //create random x start position with static x position
        start.x = Random.Range(-2, 8);
        start.y = 6;
        //create random y start position with static y position
        end.x = Random.Range(-2, 8);
        end.y = -2;

        //object destroys self in 7 seconds
        Destroy(gameObject, 7);
    }

    // Update is called once per frame
    void Update()
    {
        //incrementally increase x axis modifier by delta time to appproach end vector from start
        xAxis += Time.deltaTime;
        //incrementally increase y axis modifier by delta time to appproach end vector from start
        yAxis += Time.deltaTime;
        //create temporary vector to modify position
        Vector2 position = transform.position;
        //modify x axis position with associated modifier using lerp to creat trave route
        position.x = Mathf.Lerp(start.x, end.x, curveX.Evaluate(xAxis));
        //modify y axis position with associated modifier using lerp to creat trave route
        position.y = Mathf.Lerp(start.y, end.y, curveX.Evaluate(yAxis));
        //add vector back to transform to modify sprite position
        transform.position = position;
        
    }
}
