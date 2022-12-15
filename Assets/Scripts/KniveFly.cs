using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KniveFly : MonoBehaviour
{
    public float Speed = 3f;

   
    

    private void Start()
    {
        Destroy(this.gameObject, 10f);
    }

    void Update()
    {
      transform.Translate(Vector3.up * Speed * Time.deltaTime);
    }



    private void OnTriggerEnter2D(Collider2D other)
    {
       if (other.gameObject.CompareTag("Enemy"))
       {
        Destroy(gameObject);
       }
    }
}
