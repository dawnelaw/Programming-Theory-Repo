using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsianLeopard : Cat
{
    private int lifeSpan;

    public void Start()
    {
        Name = "Tabby";  //Name is defined in Cat
        MakeSound();
        DisplayLifeSpan();
        
    }
    // Start is called before the first frame update
    public override void MakeSound()
    {
        // base.MakeSound();
        Debug.Log("Asian Leopard meow very loudly.");
    }

    public override void DisplayLifeSpan()
    {
        SetLifeSpan(11);  //SetLifeSpace is an encapsulation method in Cat
        Debug.Log("Asian Leopard live up to " + GetLifeSpan() + " years");
    }

    public void CarriesPreyIntoTrees()
    {

    }
}
