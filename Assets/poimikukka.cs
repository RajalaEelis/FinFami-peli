using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class poimikukka : MonoBehaviour
{
    public GameObject paivankakkara;
    public GameObject txti;
    public GameObject vikakeskustelu;
    public void OnTriggerStay()
    {
        txti.SetActive(true);
        if (Input.GetKey(KeyCode.E))
        {
            paivankakkara.SetActive(false);
            txti.SetActive(false);
            vikakeskustelu.SetActive(true);
        }
    }
    public void OnTriggerExit()
    {
        txti.SetActive(false); 
    }
}
