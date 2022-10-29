using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class controllplayer : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    public GameObject bullet;
    public GameObject bulletSpawn;
    public float bulletSpeed;
    private int box;
    private int bulletCount;
    public Text scoreUI;
    public Text bulletnow;
    // Start is called before the first frame update
    void Start()
    {
        box = 0;
        bulletCount = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
        float moveVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        this.transform.Translate(0, 0, moveVertical);

        float moveHorizontal = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        this.transform.Rotate(0, moveHorizontal, 0);
        if (bulletCount > 0)
        {
            //fire Bullet
            if (Input.GetMouseButtonDown(0))
            {
                GameObject b = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.localRotation);
                b.GetComponent<Rigidbody>().AddForce(bulletSpawn.transform.forward * bulletSpeed);
                Destroy(this.bullet.transform, 2);
                bulletCount--;
                bulletnow.text = "Bullet : " + bulletCount;
                if (Collider.Equals(b,gameObject.tag =="box"))
                {
                    box++;
                    scoreUI.text = "Score : " + box;
                    System.Console.WriteLine(box);
                }
            }
        
        }
       

        

    }
    public class Controllplayer : MonoBehaviour { 
    private void onCollisionEnter(Collider other) {
        if (other.gameObject.tag == "boundary")
        {
            SceneManager.LoadScene("SampleScene");
        }


    }

    }
}
