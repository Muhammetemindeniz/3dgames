using Game.pControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Movements
{
    public class Rotate : MonoBehaviour
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

        }
    }
}

