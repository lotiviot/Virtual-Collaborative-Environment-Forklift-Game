using UnityEngine;
using Mirror;

public class fpsBody : NetworkBehaviour {

    //THIS SCRIPT IS A EXAMPLE FOR THIS ASSET, YOU CAN USE YOUR OWN SCRIPT

    public GameObject fpsCamera;
    public string horizontalInputName;
    public string verticalInputName;
    public float Speed;
    public float runSpeedMultiplicated;

    public CharacterController charController;

    public void Start()
    {
        if(!isLocalPlayer){
            return;
        }
        fpsCamera.SetActive(true);
        charController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if(!isLocalPlayer){
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
    }

    private void PlayerMovement()
    {
        float horizInput = Input.GetAxis(horizontalInputName) * Speed;
        float vertInput = Input.GetAxis(verticalInputName) * Speed;

        Vector3 forwardMovement = transform.forward * vertInput;
        Vector3 rightMovement = transform.right * horizInput;

        charController.SimpleMove(forwardMovement + rightMovement);
    }

}
