using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace Game.Inputs
{
    public class DefaultInput
    {
        DefaultAction _input;
        public bool IsForceUp { get; private set; }
        public float IsLeftRight { get; private set; }
        public DefaultInput()
        {
            _input = new DefaultAction();
            _input.Rocket.ForceUp.performed += context => IsForceUp = context.ReadValueAsButton();
            _input.Rocket.LeftRight.performed += context=> IsLeftRight=context.ReadValue<float>();

            _input.Enable();
        }
    }
}
