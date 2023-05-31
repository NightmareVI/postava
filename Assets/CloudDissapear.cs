using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDissapear : MonoBehaviour
{
 [SerializeField] private float _delay;
 [SerializeField] Collider2D collider;
 [SerializeField] Animator _animator;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Delay());

        }
    }
    private IEnumerator Delay()
    {
        _animator.SetTrigger("Warning");
        yield return new WaitForSeconds(_delay);
        _animator.SetTrigger("Fall");
        collider.enabled =false;
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
