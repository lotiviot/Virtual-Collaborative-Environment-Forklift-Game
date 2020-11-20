using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class Pallet : NetworkBehaviour
{
    public bool isGoal = false;
    private int colors = 0;
    private Renderer renderer;
    public GameObject top;
    public GameObject middle;
    public GameObject bottoms;
    public Material red;
    public Material blue;
    public Material yellow;
    public Material pallet;
    // Start is called before the first frame update
    void Start()
    {
        renderer = top.GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            this.tag = "GoalPallet";
            isGoal = true;
            colors++;
            changeMaterial();
        }
    }
    private void changeMaterial()
    {
        try
        {
            Renderer render = GetComponent<Renderer>();
            switch(colors)
            {
                case 1:
                    
                    renderer.material = red;
                    break;
                case 2:
                    renderer.material = blue;
                    break;
                case 3 : 
                    renderer.material = yellow;
                    break;
                default:
                    colors = 0;
                    renderer.material = pallet;
                    break;
            }
        }
        catch (System.Exception)
        {
            Debug.Log("error");            
        }
    }
}
