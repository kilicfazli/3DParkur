using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (animator != null)
            {
                animator.SetTrigger("PlayAnimation");
                Debug.LogWarning("Animator çalýþtý");
            }
            else
            {
                Debug.LogWarning("Animator atanmadý");
            }
        }
    }
}
