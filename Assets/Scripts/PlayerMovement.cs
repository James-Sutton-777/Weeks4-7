using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    Vector3 playerPos;
    public float speed = 5;
    public float range = 3;
    public GameObject canvas;
    public GameObject banana;
    public Image reaction;
    public Sprite[] sprite;
    bool check = false;
    bool checkLast = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = transform.position;
        {
                playerPos.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;
                playerPos.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime;
            
            transform.position = playerPos;
        }

        if(Vector3.Distance(playerPos, banana.transform.position) <= range)
        {
            canvas.SetActive(true);

            check = true;

        }
        else
        {
            canvas.SetActive(false);

            check = false;
        }

        if(check != checkLast)
        {
            reaction.sprite = sprite[Random.Range(0, sprite.Length)];
        }

        checkLast = check;
    }
}
