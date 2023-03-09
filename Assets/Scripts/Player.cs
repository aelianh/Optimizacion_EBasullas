using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{   [SerializeField] float speed = 5f;
    [SerializeField] float dirX;

    Rigidbody _rigidB;

    public GameObject bulletPrefab;
    public Transform bulletOrigin;
    public int ammo = 0;

    // Start is called before the first frame update
    void Awake()
    {
        _rigidB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = PoolManager.Instance.GetPooledObjects(ammo, bulletOrigin.position, bulletOrigin.rotation);
            bullet.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        _rigidB.velocity = new Vector3(dirX * speed, _rigidB.velocity.y, _rigidB.velocity.z);
    }
}
