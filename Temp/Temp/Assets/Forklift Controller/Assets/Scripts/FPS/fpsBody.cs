using UnityEngine;
using Mirror;

public class fpsBody : NetworkBehaviour 
{

    //THIS SCRIPT IS A EXAMPLE FOR THIS ASSET, YOU CAN USE YOUR OWN SCRIPT

    
    public GameObject fpsCamera;
    [SyncVar(hook=nameof(goAway)) ]
    public bool isVisible;
    public string horizontalInputName;
    public string verticalInputName;
    public float Speed;
    public float runSpeedMultiplicated;
   // [SyncVar(hook=nameof(isVisible))]
    
    //[SerializeField]
    //bool hasBody;
    //[NonSerialized] // usually don't want these to be assignable in editor
    //public StringEvent OnItemNameChange = new StringEvent();
    public CharacterController charController;

    public override void OnStartClient()
    {
        if(!isLocalPlayer)
        {
            return;
        }
        //isVisible(hasBody,hasBodyServ);
        fpsCamera.SetActive(true);
        this.name="player"+netId;
        charController = GetComponent<CharacterController>();
    }
    public void goAway(bool oldPlayer, bool newPlayer)
    {
        GameObject me = this.gameObject;
        me.SetActive(newPlayer);
    }
    public void OnDisable()
    {
        isVisible = false;
    }

    public void OnEnable()
    {
        isVisible = true;
    }


    private void Update()
    {
        if(!isLocalPlayer)
        {
            return;
        }
        PlayerMovement();

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            Speed = Speed * runSpeedMultiplicated;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            Speed = Speed / runSpeedMultiplicated;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 forwardMovement = transform.up * 1;
        }
    }

    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName) * Speed;
        float vertInput = Input.GetAxis(verticalInputName) * Speed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charController.SimpleMove(forwardMovement + rightMovement);
    }

   /*private void isVisible(bool oldBool, bool newBool)
    {
        EnsureInit();
        oldBool = newBool;
        
       // StringEvent OnItemNameChange = new StringEvent();
    }*/


}

//class StringEvent : UnityEvent<bool> { }