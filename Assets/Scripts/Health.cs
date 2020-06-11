using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float startHp = 100;
    private float hp;
    public GameObject bullet;
    public Image healthBar;
    public ParticleSystem deathParticle;

    // Start is called before the first frame update
    void Start()
    {
        hp = startHp;
    }

    // Update is called once per frame
    void Update()
    {
        

        if (hp < 1)
        {
            Kill();
        }
        healthBar.fillAmount = hp / startHp;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            hp--;
        }
    }

    void Kill()
    {
        
        Destroy(this.gameObject);
        Instantiate(deathParticle, transform.position, Quaternion.identity);

    }

}
   



