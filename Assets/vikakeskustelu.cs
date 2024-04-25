using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vikakeskustelu : MonoBehaviour
{
    public GameObject LastOK;
    public GameObject Laatikko;

    
    public FirstPersonMovement Controller;

    public FirstPersonLook Cameramovement;

    public GameObject player;

    public GameObject playerCam;

    public Rigidbody m_Rigidbody;

    

    private void OnTriggerEnter()
    {
        LastOK.SetActive(true);
        Laatikko.SetActive(true);
        

        Controller.enabled = (false);

        

        playerCam.transform.rotation = Quaternion.Euler(-5, 0, 0);
        player.transform.position = (new Vector3(23, 38, -165));

        Cameramovement.enabled = (false);
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        Cursor.lockState = CursorLockMode.None;
    }
}
