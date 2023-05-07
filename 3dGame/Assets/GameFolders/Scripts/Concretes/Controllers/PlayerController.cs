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
        [SerializeField] float _turn;
        Movement move;
        Rotate rotate;
        DefaultInput _defaultInput;
        bool _isForceUp;
        float _isLeftRight;
        public float Turn => _turn;
        public float Force => _force;
        private void Awake()
        {
            move = new Movement(this);
            rotate = new Rotate(this);
            _defaultInput =new DefaultInput();
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
            _isLeftRight= _defaultInput.IsLeftRight;
        }
        private void FixedUpdate()
        {
            Debug.Log(_isLeftRight);
            if (_isForceUp) 
            {
                move.FixedTick();
            }
            rotate.FixedTick(_isLeftRight);
        }
    }
}

