using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tabby : Cat
{
    public bool isDomesticated = true;

    public void Start()
    {
        //Inheritance example: Name, MakeSound() and DisplayLifeSpan() are inherited from Cat
        //Polymorphism - overiding = assigning "Tabby to Cat.Name is an example of overriding
        Name = "Tabby";  //Name is defined in Cat
        MakeSound();
        DisplayLifeSpan();
        PlaysWithHumans();
    }

    public override void MakeSound()
    {
        Debug.Log(Name +" cat meows.");
    }

    //Polymorphism - overiding DisplayLifeSpan()
    public override void DisplayLifeSpan()
    {
        SetLifeSpan(20);  //SetLifeSpace is an encapsualtion method in Cat
        Debug.Log(Name + " cats can live up to " + GetLifeSpan() + " years");
    }

    // Update is called once per frame
    public void PlaysWithHumans()
    {
        Debug.Log(Name + " cats will play with humans.");
    }



}
