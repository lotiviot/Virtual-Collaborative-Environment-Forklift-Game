using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class TriggerYellow : NetworkBehaviour
{
    [SyncVar(hook=nameof(Status))]
    public bool trigger;
    private Color m_oldColor = Color.green;
    // Start is called before the first frame update
    void Start()
    {
        trigger = false;
        Renderer render = GetComponent<Renderer>();
        GetComponent<Renderer>().material.color = m_oldColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Status(bool oldVal,bool newVal)
    {
        trigger = newVal;
        if(trigger)
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.yellow;
        }
        else
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = m_oldColor;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("YellowGoalPallet"))
        {   
            trigger = true;
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.yellow;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("YellowGoalPallet"))
        {   
            trigger = true;
            Renderer render = GetComponent<Renderer>();
            render.material.color = m_oldColor;
        }
    }
}

