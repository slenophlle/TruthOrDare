using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserRemover : MonoBehaviour
{
    UserAddPrefabElement userAddPrefabElement;
    private void Start()
    {
        userAddPrefabElement = GetComponent<UserAddPrefabElement>();
    }
    private void OnEnable()
    {
        if (userAddPrefabElement == null)
        {
            userAddPrefabElement = GetComponent<UserAddPrefabElement>();
        }
    }
    public void OnRemoveUserButtonClicked()
    {
        GameInfo.players.Remove(userAddPrefabElement.userName.text);
        Destroy(gameObject);
    }

}
