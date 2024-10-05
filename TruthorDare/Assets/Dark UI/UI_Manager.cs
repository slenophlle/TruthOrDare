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
        // �stenilen panellerin ba�lang��ta durumu burada belirlenebilir.
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Profil butonuna bas�ld���nda profil panelini a��p kapat
    public void ToggleProfile()
    {
        TogglePanel(myInfoPanel);
        MainMenu.SetActive(!myInfoPanel.activeSelf); // MainMenu'yu ters duruma getirir
    }

    // Kategori ekran�n� a��p kapat
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

    // Ma�aza ekran�n� a��p kapat
    public void ToggleShopScreen()
    {
        TogglePanel(Shop);
        MainMenu.SetActive(!Shop.activeSelf);
    }

    // Genel panel a�ma/kapama fonksiyonu
    void TogglePanel(GameObject panel)
    {
        panel.SetActive(!panel.activeSelf); // A��k ise kapat, kapal� ise a�
    }

    // Di�er t�m panelleri kapat
    void CloseAllPanels()
    {
        myInfoPanel.SetActive(false);
        MainMenu.SetActive(false);
        Settings.SetActive(false);
        Shop.SetActive(false);
        Categorys.SetActive(false);
    }
}
