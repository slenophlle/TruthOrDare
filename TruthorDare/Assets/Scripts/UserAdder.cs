using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UserAdder : MonoBehaviour
{
    public TMP_InputField userNameIF;
    public GameObject userAddPrefab;
    public GameObject prefabRootObject;
    public void OnAddUserButtonClicked()
    {
        GameObject instantiatedObject = Instantiate(userAddPrefab, prefabRootObject.transform);
        UserAddPrefabElement userAddPrefabElement = instantiatedObject.GetComponent<UserAddPrefabElement>();
        userAddPrefabElement.userName.text = userNameIF.text;
        GameInfo.players.Add(userNameIF.text);
    }
}
