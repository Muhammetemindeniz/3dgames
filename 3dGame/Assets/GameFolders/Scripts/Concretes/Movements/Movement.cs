using Game.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Movements {
    public class Movement
    {
        Rigidbody _rb;
        PlayerController _playerController;
        public Movement(PlayerController playerController)
        {
            
            _playerController = playerController;
            _rb = _playerController.GetComponent<Rigidbody>();
        }
        public void FixedTick()
        {
            _rb.AddRelativeForce(Vector3.up*Time.deltaTime*_playerController.Force);
        }
    }

}
