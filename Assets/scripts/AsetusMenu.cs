using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AsetusMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject asetusMenuUI;
   
   public AudioMixer audioMixer;

    public FirstPersonLook Cameramovement;
    public GameObject playerCam;

    public void SetVolume (float volume){

        audioMixer.SetFloat("volume", volume);
   } 
    public void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            
                Pause();
           
        }
    }

    public void Resume ()
    {
       asetusMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cameramovement.enabled = (true);
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Pause()
    {
        asetusMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        Cameramovement.enabled = (false);
    }

    public void PoistuPelista()
    {
        Debug.Log("poistupelistä");
        Application.Quit();
    }

}
