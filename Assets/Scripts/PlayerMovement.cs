using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using Photon.Pun;

public class PlayerMovement : MonoBehaviourPunCallbacks
{
    NavMeshAgent _agent;
    [SerializeField] LayerMask _layer;
    PhotonView View;
    Animator _anim;

    // Start is called before the first frame update
    void Start()
    {
        View = GetComponent<PhotonView>();
        if (!View)
        {
            Debug.LogError("PhotonView Is Missing");
        }
        _anim = GetComponent<Animator>();
        if (!_anim)
        {
            Debug.LogError("Animator is Not Found");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!View.IsMine)
        {
            return;
        }
        if (Input.GetMouseButtonDown(0))
        {
            //Ray Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //RaycastHit hit;
            _anim.SetBool("Dance", true);

            /*if (Physics.Raycast(Ray, out hit, _layer))
            {
                _agent.SetDestination(hit.point);
                _anim.SetBool("Run", true);
            }*/
        }
        if (Input.GetMouseButtonDown(1))
        {
            _anim.SetBool("Dance", false);
        }
    }
}
