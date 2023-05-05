using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Game.Movements {
    public class Movement : MonoBehaviour
    {
        Rigidbody _rb;
        public Movement(Rigidbody rb)
        {
            _rb= rb;
        }
        public void FixedTick(float force)
        {
            _rb.AddRelativeForce(Vector3.up*Time.deltaTime*force);
        }
    }

}
