using Game.Inputs;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
namespace Game.pControl
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force;
        Rigidbody _rb;
        DefaultInput _defaultInput;
        bool _isForceUp;
        private void Awake()
        {
            _rb = GetComponent<Rigidbody>();
            _defaultInput=new DefaultInput();
        }
        void Update()
        {
            if (_defaultInput.IsForceUp)
            {
                _isForceUp = true;
            }
            else
            {
                _isForceUp = false;
            }

        }
        private void FixedUpdate()
        {
            if (_isForceUp) 
            {
                _rb.AddForce(Vector3.up*Time.deltaTime*_force);
            }
        }
    }
}

