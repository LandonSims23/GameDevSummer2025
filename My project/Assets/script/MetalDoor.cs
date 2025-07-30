using UnityEngine;
using System.Collections;

public class MetalDoor : MonoBehaviour
{
    [SerializeField] bool canOpen;
    [SerializeField] GameObject thePlayer;
    [SerializeField] GameObject theCam;
    [SerializeField] GameObject textOnScreen;
    [SerializeField] AudioSource lockedDoor;


    private void Update()
    {
        if (canOpen == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(OpeningDoor());
            }
        }
    }

    void OnMouseOver()
    {
        if (PlayerCasting.distancefromtarget < 5)
        {
            canOpen = true;
            UIController.actionText = "OpenDoor";
            UIController.commandText = "Open";
            UIController.uiActive = true;
        }
        else
        {
            canOpen = false;
            UIController.actionText = "";
            UIController.commandText = "";
            UIController.uiActive = false;
        }
    }


    void OnMouseExit()
    {
        canOpen = false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.uiActive = false;
    }
    IEnumerator OpeningDoor()
    {
        theCam.SetActive(true);
        thePlayer.SetActive(false);
        textOnScreen.SetActive(true);
        lockedDoor.Play();
        yield return new WaitForSeconds(3);
        textOnScreen.SetActive(false);
        thePlayer.SetActive(true);
        theCam.SetActive(false);
    }
}
