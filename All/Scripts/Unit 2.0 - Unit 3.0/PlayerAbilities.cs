using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAbilities : MonoBehaviour
{
    private Animator anim;

    public GameObject Attack1;

    enum Abilities
    {
        Attack1,
        Attack2,
    }

    Abilities selectedAbility = Abilities.Attack1;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            switch (selectedAbility) {
                case Abilities.Attack1:
                anim.SetBool("Attack1", true);
                    GameObject temp = Instantiate(Attack1, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), Quaternion.identity);
                    temp.transform.rotation = transform.rotation;
                   
                    /*Ray rayout = new Ray(transform.position, transform.forward);
                    temp.transform.position = Vector3.MoveTowards(transform.position, transform.forward, 100);*/
                    break;
        }
        }
        else
        {
            anim.SetBool("Attack1", false);
        }
    }
}
