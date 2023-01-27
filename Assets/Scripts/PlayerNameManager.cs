using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class PlayerNameManager : MonoBehaviour
{
    [SerializeField] TMP_InputField _username;

    private void Start()
    {
        if (PlayerPrefs.HasKey("username"))
        {
            _username.text = PlayerPrefs.GetString("username");
            PhotonNetwork.NickName = PlayerPrefs.GetString("username");
        }
    }

    public void OnUsernameIPFValueChange()
    {
        PhotonNetwork.NickName = _username.text;
        PlayerPrefs.SetString("username", _username.text);
    }
}
