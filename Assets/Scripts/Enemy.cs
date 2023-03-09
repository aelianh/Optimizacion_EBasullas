using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void Update()
    {
        transform.position += transform.forward * 1 * Time.deltaTime;
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
