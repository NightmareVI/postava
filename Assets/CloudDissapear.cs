using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudDissapear : MonoBehaviour
{
 [SerializeField] private float _delay;
 [SerializeField]Collider2D collider;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(Delay());

        }
    }
    private IEnumerator Delay()
    {
        yield return new WaitForSeconds(_delay);
        collider.enabled =false;
        yield return new WaitForSeconds(0.5f);
        Destroy(gameObject);
    }
}
