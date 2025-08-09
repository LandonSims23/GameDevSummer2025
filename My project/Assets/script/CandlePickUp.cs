using UnityEngine;
using System.Collections;

public class CandlePickUp : MonoBehaviour
{
    [SerializeField] bool canPick;

    [SerializeField] GameObject textOnScreen;
    [SerializeField] GameObject tableCandle;
    [SerializeField] GameObject handCandle;
    


    private void Update()
    {
        if (canPick == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                this.GetComponent<BoxCollider>().enabled = false;
                tableCandle.SetActive(false);
                handCandle.SetActive(true);
            }
        }
    }

    void OnMouseOver()
    {
        if (PlayerCasting.distancefromtarget < 5)
        {
            canPick = true;
            UIController.actionText = "Candle";
            UIController.commandText = "Pick Up";
            UIController.uiActive = true;
        }
        else
        {
            canPick = false;
            UIController.actionText = "";
            UIController.commandText = "";
            UIController.uiActive = false;
        }
    }


    void OnMouseExit()
    {
        canPick = false;
        UIController.actionText = "";
        UIController.commandText = "";
        UIController.uiActive = false;
    }
    
}
