using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public string blue;
    public string red;
    public string yellow;
    GameObject blueObj = GameObject.Find("Goal Suite/Goal Plane Blue");
    int counter = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (blueObj != null)
        {
            counter++;
        }
    }
}
