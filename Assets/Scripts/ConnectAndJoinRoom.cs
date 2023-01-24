using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;

public class ConnectAndJoinRoom : MonoBehaviourPunCallbacks
{
    [SerializeField] TMP_InputField _createInputField, _joinInputField;

    public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(_createInputField.text);
    }

    public void JoinRoom()
    {
        PhotonNetwork.JoinRoom(_joinInputField.text);
    }

    public override void OnJoinedRoom()
    {
        Debug.Log("You are joined the room");
    }
}
