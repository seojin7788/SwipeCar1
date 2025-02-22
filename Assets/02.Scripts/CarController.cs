using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float MoveSpeed = 0f;
    bool Click = false;
    GameDirector reset;

    Vector2 StartPos; // 시작지점

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        /*if (reset.Gameover)
        {
            transform.position = new Vector3(-6, -3.7f, 0);
            Click = false;
            reset.Gameover = false;
        }*/
        //transform.position = new Vector3(MoveSpeed, -3.7f, 0);
        transform.Translate(MoveSpeed, 0, 0);
        if (Click)
        {
            if (Input.GetMouseButtonDown(1))
            {
                transform.position = new Vector3(-6, -3.7f, 0);
                Click = false;
                MoveSpeed = 0f;
            }
        }

        if (!Click)
        {
            if (Input.GetMouseButtonDown(0))
            {
                StartPos = Input.mousePosition;

            }
            if (Input.GetMouseButtonUp(0))
            {
                Vector2 EndPos = Input.mousePosition;
                float swipeLenth =Mathf.Abs( EndPos.x - StartPos.x);
                /*if (swipeLenth < 0)
                {
                    swipeLenth *= -1;
                }
                */
                MoveSpeed = swipeLenth / 1000f;
                
                Click = true;
            }


        }

        MoveSpeed *= 0.98f;

    }
}
