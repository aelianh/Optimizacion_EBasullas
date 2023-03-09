using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * 10 * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other)
    {
        this.gameObject.SetActive(false);
    }

    void OnBecomeInvisible()
    {
        enabled = false;
    }
}
