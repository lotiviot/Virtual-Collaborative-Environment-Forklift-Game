using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerRed : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private Color m_oldColor = Color.green;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "red box goal")
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.red;
        }

    }
    void OnTriggerExit(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = m_oldColor;
    }
}
