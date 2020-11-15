using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public GameObject blue;
    public GameObject red;
    public GameObject yellow;
    // Start is called before the first frame update
    void Start()
    {
        blue = GameObject.Find("Goal Suite/Goal Plane Blue");
        red = GameObject.Find("Goal Suite/Goal Plane Red");
        yellow = GameObject.Find("Goal Suite/Goal Plane Yellow");
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(blue.GetComponent<Renderer>().material.GetColor("_Color"));
        // Debug.Log(red.GetComponent<Renderer>().material.GetColor("_Color"));
        // Debug.Log(yellow.GetComponent<Renderer>().material.GetColor("_Color"));
        if (blue != null)
            {

            }
        }
}
