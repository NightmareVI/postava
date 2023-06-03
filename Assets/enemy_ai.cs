using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_ai : MonoBehaviour
{
    [SerializeField] float speed=1f;
    private Rigidbody2D rb;
    Vector3 localScale;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        localScale=transform.localScale;
        
    }
    private void Update() 
        {if(IsFacingRight())

    {
    rb.velocity = new Vector2(speed, 0f);
    }else
    {
    rb.velocity = new Vector2(-speed, 0f);
    }}


    private bool IsFacingRight()
    {
        return transform.localScale.x > Mathf.Epsilon;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Platform"))
            localScale.x *= -1f;
            transform.localScale = localScale;
    }
   
  
   
}
