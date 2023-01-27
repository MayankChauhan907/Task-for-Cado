using UnityEngine;
using Photon.Pun;
using TMPro;

public class UsernameDisplay : MonoBehaviour
{
    [SerializeField] PhotonView View;
    [SerializeField] TMP_Text _username;

    private void Start()
    {
        _username.text = View.Owner.NickName;
    }
}
