using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTalkWithMom : MonoBehaviour
{
    public GameObject TalkWithMom;
    public FirstPersonLook Cameramovement;

    

    public GameObject player;
    public GameObject playerCam;

    public Rigidbody m_Rigidbody;
    public FirstPersonMovement Controller;

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
       
        TalkWithMom.SetActive(true);

        Controller.enabled = (false);

        player.transform.position = (new Vector3(-17, 1, -120));
        playerCam.transform.rotation = Quaternion.Euler(0, 330, 0);



        Cameramovement.enabled = (false);
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        Cursor.lockState = CursorLockMode.None;
    }
}
