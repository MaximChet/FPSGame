using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject arrowPrefab;
    public Transform arrowLocaiton;
    public float shotPower;
    public AudioSource shootSound;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(arrowPrefab, arrowLocaiton.position, arrowLocaiton.rotation).GetComponent<Rigidbody>().AddRelativeForce(Vector3.forward * shotPower);
            shootSound.Play();
        }
    }

}
