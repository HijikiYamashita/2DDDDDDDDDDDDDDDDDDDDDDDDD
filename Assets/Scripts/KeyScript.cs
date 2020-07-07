using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyScript : MonoBehaviour
{
    public GameObject nextKey;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (nextKey == null)
        {
            SceneManager.LoadScene("Battle");
        }
        else
        {
            Instantiate(nextKey, nextKey.transform.position, nextKey.transform.rotation);
        }
        Destroy(this.gameObject);
    }
}
