using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorDestroy : MonoBehaviour
{
    public Animator animator;
    public float destroyDelay = 1f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("buraya girdi");
            animator.SetTrigger("PlayAnimation");
            Debug.Log("buraya da girdi");
            StartCoroutine(StartAnimationAndDestroy());
        }
    }

    private IEnumerator StartAnimationAndDestroy()
    {      
        yield return new WaitForSeconds(destroyDelay);

        gameObject.gameObject.SetActive(false);
    }
}
