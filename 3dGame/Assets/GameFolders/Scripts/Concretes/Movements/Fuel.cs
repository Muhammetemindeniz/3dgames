using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Movements
{
    public class Fuel : MonoBehaviour
    {
        [SerializeField] float _maxFuel=100f;
        [SerializeField] float _currentFuel;
        [SerializeField] ParticleSystem _particalSystem;
        public bool IsEmpty => _currentFuel <= 0;
        private void Awake()
        {
            _currentFuel = _maxFuel;
        }

        public void FuelIncrease(float increase)
        {
            _currentFuel += increase;
            _currentFuel = Mathf.Min(_currentFuel,_maxFuel);
            if(_particalSystem.isPlaying) _particalSystem.Stop();
        }
        public void FuelDecrease(float decrease)
        {
            _currentFuel -= decrease;
            _currentFuel = Mathf.Max(_currentFuel, 0);
            if(_particalSystem.isStopped) _particalSystem.Play();
        }
    }
}

