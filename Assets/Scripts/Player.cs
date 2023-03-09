using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 


    float speed = 2;

    private CharacterController controller;
    public float horizontalMove;
    public float verticalMove;

    public GameObject bulletPrefab;
    public Transform bulletOrigin;
    public int ammo = 0;



    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalMove = Input.GetAxis("Vertical");
        horizontalMove= Input.GetAxis("Horizontal");
        
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = PoolManager.Instance.GetPooledObjects(ammo, bulletOrigin.position, bulletOrigin.rotation);
            bullet.SetActive(true);
        }
    }

    void FixedUpdate()
    {
        controller.Move(new Vector3(horizontalMove, 0, verticalMove) * speed);
    }

}
