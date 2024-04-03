using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KenkaSCRIPT : MonoBehaviour
{
    public GameObject Player;
    public GameObject TP;
    public GameObject MSG;
    public FirstPersonMovement Controller;
    public FirstPersonLook Cameramovement;
    public Rigidbody m_Rigidbody;
    public GameObject Mutsi;
    public GameObject MutsiTP;
    void OnTriggerEnter()
    {
        MSG.SetActive(true);
        Controller.enabled = (false);
        Cameramovement.enabled = (false);
        m_Rigidbody.constraints = RigidbodyConstraints.FreezeAll;
        Cursor.lockState = CursorLockMode.None;
    }

    public void Teleport()
    {
        Player.transform.position = TP.transform.position;

        m_Rigidbody.constraints = RigidbodyConstraints.None;

        m_Rigidbody.constraints = RigidbodyConstraints.FreezeRotationZ | RigidbodyConstraints.FreezeRotationX;

        Mutsi.transform.position = MutsiTP.transform.position;
        Mutsi.transform.rotation = MutsiTP.transform.rotation;
    }
}
