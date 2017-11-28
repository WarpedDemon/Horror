using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CombatDetectHit : MonoBehaviour {

    public Slider healthBar;

    Animator anim;

    public string oppenent;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != oppenent) {
            return;
        }

        healthBar.value -= 20;

        //Debug.Log("Hit");

        if (healthBar.value <= 0) {
            anim.SetBool("isDeath", true);
        }
    }

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
