using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien01Script : MonoBehaviour
{
    public LogicScript logic;

    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {   

    }

    // Destroy the alien if it collides with a bullet
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 7) // If the bullet hits the alien
        {
            anim.Play("Explosion");
            Destroy(gameObject, 0.3f);
            Destroy(collision.gameObject); // Destroy the bullet
            logic.IncreaseScore(1);
        }
    }
}
