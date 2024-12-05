using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slipperySurfaceEffect : MonoBehaviour
{
    public float slideForce = 5f;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.collider.CompareTag("SlipperySurface"))
        {
            Vector3 slideDirection = Vector3.ProjectOnPlane(Vector3.down, collision.contacts[0].normal).normalized;
            rb.AddForce(slideDirection * slideForce, ForceMode.Acceleration);
        }
    }
}
