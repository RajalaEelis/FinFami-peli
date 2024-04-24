using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TalkWithIndian : MonoBehaviour
{

    public GameObject CONVERSATION;
    public GameObject FirstOK;

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
        CONVERSATION.SetActive(true);

        Controller.enabled = (false);

        player.transform.position = (new Vector3(46,0,0));
        playerCam.transform.rotation = Quaternion.Euler(0, 0, 0);

        FirstOK.SetActive(true);

        Cameramovement.enabled = (false);
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        Cursor.lockState = CursorLockMode.None;
    }
}
