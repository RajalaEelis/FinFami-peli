using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableMovementAgain : MonoBehaviour
{
    public FirstPersonMovement Controller;

    public FirstPersonLook Cameramovement;

    public Rigidbody m_Rigidbody;
    
    // Start is called before the first frame update
    void Start()
    {
        Controller.enabled = (true);

        Cameramovement.enabled = (true);

        m_Rigidbody.constraints = RigidbodyConstraints.None;

        m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX;

        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
