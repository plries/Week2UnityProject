using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveStuff : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {

        if (hit.gameObject.tag == "Interactive")
        {
            Debug.Log("Hit something!");
        }

    }
}
