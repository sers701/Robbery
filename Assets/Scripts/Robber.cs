using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robber : MonoBehaviour
{
    [SerializeField] private float _WalkSpeed;

    private void FixedUpdate()
    {
        transform.position = transform.position - transform.forward * Input.GetAxis("Horizontal") * _WalkSpeed * Time.fixedDeltaTime;
    }

}
