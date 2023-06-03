using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    private float iframe = 1f, iframeCounter;
    [SerializeField] HP HP;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        iframeCounter -= Time.deltaTime;
    }
    void OnCollisionEnter2D (Collider2D collision)
    {
        if (collision.CompareTag("Enemy") || iframeCounter<0f){
        HP.health-=1;iframeCounter=iframe;}}
}