using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public Text distance_text;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = flag.transform.position.x - car.transform.position.x;
        if (distance < 0)
        {
            distance_text.text = "      게임오버";
            
        }
        else
        {
            distance_text.text = "목표 지점까지 " + distance.ToString("F2") + "m";
        }
        
        
    }
    

}
