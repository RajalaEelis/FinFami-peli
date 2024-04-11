using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPHome : MonoBehaviour
{
    
    public GameObject player;

    public FirstPersonMovement Controller;

    public FirstPersonLook Cameramovement;

    public Rigidbody m_Rigidbody;
    
    
    // Start is called before the first frame update
    void Start()
    {
        player.transform.position = this.transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    public void OK()
    {
        Controller.enabled = (true);
       
        Cameramovement.enabled = (true);

        m_Rigidbody.constraints = RigidbodyConstraints.None;

        m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX;

        Cursor.lockState = CursorLockMode.Locked;
    }
}
