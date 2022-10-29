using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cratecontroll : MonoBehaviour
{
    public GameObject crack_crate;
    public GameObject explosion;
    
 
    // Start is called before the first frame update


 
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            Instantiate(crack_crate, this.transform.position, this.transform.localRotation);
            
            
            GameObject vfx = Instantiate(explosion, this.transform.position, this.transform.localRotation);
            
            Destroy(vfx,3);
            Destroy(collision.gameObject);

            
            Destroy(this.gameObject);
           
        }
        
    }
}
