using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crate_create_controll : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Collider[] cols = Physics.OverlapSphere(this.transform.position, 2);

        foreach(Collider c in cols)
        {
            Rigidbody rb = c.GetComponent<Rigidbody>();

            if(rb)
            {
                rb.AddExplosionForce(Random.Range(7,15), this.transform.position, Random.Range(7,15), 1, ForceMode.Impulse);
            }
        }
        Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
