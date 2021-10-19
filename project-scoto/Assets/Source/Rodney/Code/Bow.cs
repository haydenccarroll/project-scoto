/*
 * Filename: Bow.cs
 * Developer: Rodney McCoy
 * Purpose: Weapon Superclass instance to control Bow
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/*
 * Main Class
 */
public class Bow : Weapon 
{    

    void Start() 
    {
        m_maxTime = 15; 
        m_discovered = true;
    }

    /*
     * overriden function used to fire weapon
     * Parameters:
     * position -- position vector to instantiate projectile
     * rotation -- rotation quaternion to instantiace projectile
     */
    public override void Fire(Vector3 position, Quaternion rotation) 
    {
        rotation *= Quaternion.Euler(-90,0,0);
        Instantiate(m_projectile, position - rotation*Vector3.up*.75F, rotation);
    }
}

