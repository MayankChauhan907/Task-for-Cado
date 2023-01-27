using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject _playerPrefab;
    [SerializeField] List<Transform> _playerPos;
    [SerializeField] GameManager _gameManager;

    // Start is called before the first frame update
    void Start()
    {
        int PlayerId = PhotonNetwork.LocalPlayer.ActorNumber;
        GameObject player = PhotonNetwork.Instantiate(_playerPrefab.name, _playerPos[PlayerId - 1].transform.position, Quaternion.identity);
        PhotonView view = player.GetPhotonView();
        if (view.IsMine)
        {
            _gameManager.SetPlayer(player);
            Debug.Log("Player send to Game Manager");
        }
    }

}
