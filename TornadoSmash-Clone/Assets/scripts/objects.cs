using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objects : MonoBehaviour
{

    Vector3 temp;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "tornado")
        {
            //transform.localScale = new Vector4(Mathf.PingPong(Time.deltaTime,1), transform.localScale.x, transform.localScale.y, transform.localScale.z);
            temp = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
            temp.x -= Time.deltaTime * 10f;
            temp.y -= Time.deltaTime * 10f;
            temp.z -= Time.deltaTime * 10f;
            transform.localScale = temp;
            Destroy(gameObject, 6f);

        }

        if (other.gameObject.tag == "border")
        {
            Destroy(gameObject);

        }

    }
 
 
}
