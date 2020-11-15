using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBlue : MonoBehaviour
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
        if (other.gameObject.name == "blue box goal")
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.blue;
        }

    }
    void OnTriggerExit(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = m_oldColor;
    }
}
