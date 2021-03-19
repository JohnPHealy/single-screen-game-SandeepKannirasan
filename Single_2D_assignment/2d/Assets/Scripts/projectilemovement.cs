using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilemovement : MonoBehaviour
{
    [SerializeField] private float projectileSpeed;

    private void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * projectileSpeed * Time.deltaTime);

    }




}
