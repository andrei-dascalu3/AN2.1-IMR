using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInMovement : MonoBehaviour
{
    private Collider checkerCollider;
    [SerializeField] private Canvas myCanvas;

    IEnumerator OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "CheckPlane")
        {
            myCanvas.enabled = true;
            checkerCollider = col.gameObject.GetComponent<Collider>();
            checkerCollider.enabled = false;

            yield return new WaitForSeconds(5);
            
            checkerCollider.enabled = true;
            myCanvas.enabled = false;
        }
    }
}
