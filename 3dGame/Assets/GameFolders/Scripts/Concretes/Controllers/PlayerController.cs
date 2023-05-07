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

        Movement _move;
        Rotate _rotate;
        Fuel _fuel;
        DefaultInput _defaultInput;
        bool _canForceUp;
        float _isLeftRight;
        public float Turn => _turn;
        public float Force => _force;
        private void Awake()
        {
            _move = new Movement(this);
            _rotate = new Rotate(this);
            _fuel=GetComponent<Fuel>();
            _defaultInput =new DefaultInput();
        }
        void Update()
        {
            if (_defaultInput.IsForceUp && !_fuel.IsEmpty)
            {
                _canForceUp = true;
            }
            else
            {
                _canForceUp = false;
                _fuel.FuelIncrease(.02f);
            }
            _isLeftRight= _defaultInput.IsLeftRight;
        }
        private void FixedUpdate()
        {
            Debug.Log(_isLeftRight);
            if (_canForceUp) 
            {
                _move.FixedTick();
                _fuel.FuelDecrease(.03f);
            }
            _rotate.FixedTick(_isLeftRight);
        }
    }
}

