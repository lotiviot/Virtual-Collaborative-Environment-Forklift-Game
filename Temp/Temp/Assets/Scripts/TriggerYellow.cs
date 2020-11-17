using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerYellow : MonoBehaviour
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

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("GoalPallet"))     {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.yellow;
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = m_oldColor;
    }
}
