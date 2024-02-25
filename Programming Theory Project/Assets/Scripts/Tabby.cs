using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabby : Cat
{
    public bool isDomesticated = true;
    public override void MakeSound()
    {
        // base.MakeSound();
        Debug.Log("Tabby meows.");
        Debug.Log("just before calling Run from cat class");
        Run();
    }

    // Update is called once per frame
public void PlaysWithHumans()
{

 }



}
