using Game.Inputs;
using Game.Movements;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using UnityEngine;
namespace Game.pControl
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField] float _force;
        Movement move;
        DefaultInput _defaultInput;
        bool _isForceUp;
        private void Awake()
        {
            move = new Movement(GetComponent<Rigidbody>());
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
                move.FixedTick(55f);
            }
        }
    }
}

