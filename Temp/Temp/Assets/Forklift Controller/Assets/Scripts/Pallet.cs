using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;
public class Pallet : NetworkBehaviour
{
    public bool isGoal = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
            this.tag = "GoalPallet";
            Debug.Log(this.tag);
            isGoal = true;
    }
}
