using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public TMP_Text headerText;
    public TMP_Text questionText;
    public GameOrderController gameOrderController;
    private void Start()
    {
        if (GameInfo.isRandomPlayer)
        {
            headerText.text = "Cevap ver bakalým " + gameOrderController.GetRandomPlayerName() + "Dogruluk mu Cesaret mi?";
        }
        else
        {
            headerText.text = "Cevap ver bakalým " + gameOrderController.GetNextPlayerName() + "Dogruluk mu Cesaret mi?";
        }
    }
    public void OnTruthButtonPressed()
    {

    }
    public void OnDareButtonPressed()
    {



    }
}
