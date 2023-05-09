using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Controllers
{
    public class StartFloorController : MonoBehaviour
    {
        private void OnCollisionExit(Collision collision)
        {
            PlayerController player=collision.gameObject.GetComponent<PlayerController>();
            if(player!=null)
                Destroy(this.gameObject);
        }
    }
}

