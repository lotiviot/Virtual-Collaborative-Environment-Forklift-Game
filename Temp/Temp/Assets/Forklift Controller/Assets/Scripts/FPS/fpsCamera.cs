﻿using UnityEngine;


public class fpsCamera : MonoBehaviour {


    //THIS SCRIPT IS A EXAMPLE FOR THIS ASSET, YOU CAN USE YOUR OWN SCRIPT

    public string mouseXInputName, mouseYInputName;
    public float mouseSensitivity;

    public Transform playerBody;
    public GameObject FPS;
    public GameObject PauseMenu;
    public Rigidbody bulletPrefab;
    private float limit;

    private void Awake()
    {
        LockCursor();
        limit = 0.0f;
        //FPS = GameObject.Find("FPS/FPS Camera");
        //PauseMenu = GameObject.Find("FPS/HUD/PauseMenu");
        Debug.Log(FPS);
    }


    public void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        CameraRotation();
        if(Input.GetKeyDown(KeyCode.Y)){
            FPS.SetActive(false);
            PauseMenu.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void CameraRotation()
    {
        float mouseX = Input.GetAxis(mouseXInputName) * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis(mouseYInputName) * mouseSensitivity * Time.deltaTime;

        limit += mouseY;

        if (limit > 90.0f)
        {
            limit = 90.0f;
            mouseY = 0.0f;
            limitRotationToValue(270.0f);
        }
        else if (limit < -90.0f)
        {
            limit = -90.0f;
            mouseY = 0.0f;
            limitRotationToValue(90.0f);
        }

        transform.Rotate(Vector3.left * mouseY);
        playerBody.Rotate(Vector3.up * mouseX);
    }


    private void limitRotationToValue(float value)
    {
        Vector3 eulerRotation = transform.eulerAngles;
        eulerRotation.x = value;
        transform.eulerAngles = eulerRotation;
    }
}
