using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GameManager : MonoBehaviourPunCallbacks
{
    PlayerMovement _playerMovemrnt;

    public void SetPlayer(GameObject player)
    {
        _playerMovemrnt = player.GetComponentInChildren<PlayerMovement>();
        if (_playerMovemrnt == null)
        {
            Debug.LogError("Playermovement is null");
        }
    }

    public void StartDance()
    {
        _playerMovemrnt.StartDance();
    }

    public void StopDance()
    {
        _playerMovemrnt.StopDance();
    }
}
