using Game.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Movements
{
    public class Rotate
    {
        PlayerController _playerController;
        Rigidbody _rb;
        public Rotate(PlayerController PlayerController)
        {
            _playerController = PlayerController;
            _rb = _playerController.GetComponent<Rigidbody>();
        }
        public void FixedTick(float dir)
        {
            if (dir == 0) {if (_rb.freezeRotation) _rb.freezeRotation = false;
                return; }
                
            if (!_rb.freezeRotation) _rb.freezeRotation = true;

            _playerController.transform.Rotate(Vector3.back * Time.deltaTime * _playerController.Turn * dir);
        }
    }
}

