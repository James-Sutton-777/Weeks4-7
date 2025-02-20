using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.ParticleSystem;

public class ParticlePlan : MonoBehaviour
{

    public AnimationCurve curveX;
    [Range(0,1)]
    public float xAxis;
    public AnimationCurve curveY;
    [Range(0,1)]
    float yAxis;
    Vector2 start;
    Vector2 end;

    // Start is called before the first frame update
    void Start()
    {
        start.x = Random.Range(-2, 8);
        start.y = 6;
        end.x = Random.Range(-2, 8);
        end.y = -2;

        Destroy(gameObject, 7);
    }

    // Update is called once per frame
    void Update()
    {
        xAxis += Time.deltaTime;
        yAxis += Time.deltaTime;
        Vector2 position = transform.position;
        position.x = Mathf.Lerp(start.x, end.x, curveX.Evaluate(xAxis));
        position.y = Mathf.Lerp(start.y, end.y, curveX.Evaluate(yAxis));

        transform.position = position;
        
    }
}
