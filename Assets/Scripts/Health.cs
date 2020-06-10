using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public int hp;
    public GameObject bullet;
    public Image healthBar;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       

        if (hp < 1)
        {
            Kill();
        }
        healthBar.fillAmount = hp / 100f;
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
    }

}
   



