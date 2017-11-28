using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayerC : MonoBehaviour {

    [SerializeField]
    private Stat health;

    [SerializeField]
    public Stat mana;

    [SerializeField]
    private Stat stamina;

    public Stat Mana
    {
        get
        {
            return mana;
        }

        set
        {
            mana = value;
        }
    }

    public Stat Stamina
    {
        get
        {
            return stamina;
        }

        set
        {
            stamina = value;
        }
    }

    public Stat Health
    {
        get
        {
            return health;
        }

        set
        {
            health = value;
        }
    }

    // Use this for initialization
    private void Awake()
    {
        Health.Initialize();
        Mana.Initialize();
        Stamina.Initialize();
    }

    public Boolean canCast() {
        if (mana != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    public void regen() {
        if (Health.CurrentVal < 1000)
        {
            Health.CurrentVal += 0;
        }

        if (Stamina.CurrentVal < 1000)
        {
            Stamina.CurrentVal += 1;
        }

        if (Mana.CurrentVal < 1000)
        {
            Mana.CurrentVal += 1;
        }


        if(Health.CurrentVal < 1000)
        {
            Health.CurrentVal += 0.1f;
            
        }

    }

    // Update is called once per frame
    void Update () {
        regen();

        //health for admin
        if (Input.GetKeyDown(KeyCode.O)) {
            Health.CurrentVal += 50;
        }
        if(Input.GetKeyDown(KeyCode.P)){
            Health.CurrentVal -= 50;
        }
        //mana for admin
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Mana.CurrentVal -= 50;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            Mana.CurrentVal -= 50;
        }
        //stamina for admin
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Stamina.CurrentVal -= 2;
        }
    }
}