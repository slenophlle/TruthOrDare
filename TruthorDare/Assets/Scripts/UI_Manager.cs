using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI_Manager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject myInfoPanel;
    public GameObject MainMenu;
    public GameObject Settings;
    public GameObject Shop;
    public GameObject Categorys;
    public GameObject PlayersInfo;

    [Header("Input Fields")]
    public TMP_InputField playerNameInputTMP;
    public TextMeshProUGUI playerInfoTextTMP;

    // New variable to track player count
    private int playerCount = 0;

    public void ToggleProfile()
    {
        TogglePanel(myInfoPanel);
        MainMenu.SetActive(!myInfoPanel.activeSelf);
    }

    public void TogglePlayerInfos()
    {
        TogglePanel(PlayersInfo);
        Categorys.SetActive(!PlayersInfo.activeSelf);
    }

    public void SavePlayerInfos()
    {
        string playerName = playerNameInputTMP.text;
        Debug.Log("Yeni oyuncu: " + playerName);

        if (!string.IsNullOrEmpty(playerName))
        {
            playerInfoTextTMP.text += "\nOyuncu Adý: " + playerName;
            playerNameInputTMP.text = string.Empty;
            playerNameInputTMP.ActivateInputField();
            UpdateContentSize();

            // Increment player count when a new player is added
            playerCount++;
        }
    }

    public void ToggleCategoryScreen()
    {
        TogglePanel(Categorys);
        MainMenu.SetActive(!Categorys.activeSelf);
    }

    public void ToggleSettings()
    {
        TogglePanel(Settings);
        MainMenu.SetActive(!Settings.activeSelf);
    }

    public void ToggleShopScreen()
    {
        TogglePanel(Shop);
        MainMenu.SetActive(!Shop.activeSelf);
    }

    void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf);
    }

    void CloseAllPanels()
    {
        myInfoPanel.SetActive(false);
        MainMenu.SetActive(false);
        Settings.SetActive(false);
        Shop.SetActive(false);
        Categorys.SetActive(false);
        PlayersInfo.SetActive(false);
    }

    private void UpdateContentSize()
    {
        RectTransform contentRectTransform = playerInfoTextTMP.GetComponentInParent<ScrollRect>().content;
        LayoutRebuilder.ForceRebuildLayoutImmediate(contentRectTransform);
    }

    public void SceneLoader()
    {
        if (playerCount >= 2)
        {
            SceneManager.LoadScene(1);
        }
        else
        {
            // Display warning message
            Debug.Log("En az 2 oyuncu girmelisiniz!");
            // Optionally, you could show a UI warning message here
            ShowWarningMessage("En az 2 oyuncu girmelisiniz!");
        }
    }

    // Method to display warning messages
    private void ShowWarningMessage(string message)
    {
        // Implement your UI logic to show the warning message
        // For example, you could use a temporary UI text or popup
        Debug.Log(message); // For now, just log it to the console
    }
}
