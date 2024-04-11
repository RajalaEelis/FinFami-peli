using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerMessage : MonoBehaviour
{
    public GameObject MessageBox;
    public FirstPersonMovement Controller;

    public FirstPersonLook Cameramovement;

    public GameObject playerCam;
    
    public Rigidbody m_Rigidbody;

    public GameObject SecondMSG;

    public Transform lookAtDaddy;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter()
    {
        MessageBox.SetActive(true);
        playerCam.transform.LookAt(lookAtDaddy);
        Controller.enabled = (false);
        
        SecondMSG.SetActive(false);

        playerCam.transform.rotation = Quaternion.Euler(-5, 0, 0);
        playerCam.transform.position = (new Vector3(23,38,-165));

        Cameramovement.enabled = (false);
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        Cursor.lockState = CursorLockMode.None;
        

    }
}
