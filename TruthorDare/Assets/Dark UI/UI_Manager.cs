using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public GameObject myInfoPanel;
    public GameObject MainMenu;
    public GameObject Settings;
    public GameObject Shop;
    public GameObject Categorys;

    // Start is called before the first frame update
    void Start()
    {
        // Ýstenilen panellerin baþlangýçta durumu burada belirlenebilir.
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Profil butonuna basýldýðýnda profil panelini açýp kapat
    public void ToggleProfile()
    {
        TogglePanel(myInfoPanel);
        MainMenu.SetActive(!myInfoPanel.activeSelf); // MainMenu'yu ters duruma getirir
    }

    // Kategori ekranýný açýp kapat
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

    // Maðaza ekranýný açýp kapat
    public void ToggleShopScreen()
    {
        TogglePanel(Shop);
        MainMenu.SetActive(!Shop.activeSelf);
    }

    // Genel panel açma/kapama fonksiyonu
    void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf); // Açýk ise kapat, kapalý ise aç
    }

    // Diðer tüm panelleri kapat
    void CloseAllPanels()
    {
        myInfoPanel.SetActive(false);
        MainMenu.SetActive(false);
        Settings.SetActive(false);
        Shop.SetActive(false);
        Categorys.SetActive(false);
    }
}
