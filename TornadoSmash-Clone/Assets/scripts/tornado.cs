using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tornado : MonoBehaviour
{
  

    public Transform tornadoCenter;
    public float pullforce;
    public float refreshRate;


    private void Update()
    {
        if (GameObject.FindObjectOfType<objects>() == null)
        {
            SceneManager.LoadScene(2) ;
            
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cube")
        {
            StartCoroutine(pull(other, true));

            
        }     
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "cube")
        {
            StartCoroutine(pull(other, false));
        }
    
    }

    IEnumerator pull(Collider x,bool pullable)
    {
        if (pullable)
        {
            Vector3 Force = tornadoCenter.position - x.transform.position;
            x.GetComponent<Rigidbody>().AddForce(Force.normalized * pullforce * Time.deltaTime);
            yield return refreshRate;
            StartCoroutine(pull(x, pullable));

        }
    }

}
