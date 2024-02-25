using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public string Name = "unknown name";
    public bool HasStealth = true;
    public bool HasNightVision = true;
    public bool IsHunter = true;
    public string Size = "unknown size";
    public bool LikesWater;
 
    private int lifeSpan = 0;

    // ENCAPSULATION of lifeSpan
    public void SetLifeSpan(int value)
    {
        lifeSpan = value;
    }

    public int GetLifeSpan()    
    {
        return lifeSpan;
    }


    private void Start()
    {
        Name = "Generic cat object";
        lifeSpan = 0;

    }
    public virtual void MakeSound()
    {
        Debug.Log("No sound defined for generic cat object");
    }

    public virtual void Jump()
    {
        Debug.Log("Cat jumps");
    }

    public virtual void Run()
    {
        Debug.Log("Cat Runs");
    }

    //ABSTRACTION of DisplayLifeSpan()
    public virtual void DisplayLifeSpan()
    {
        string lifeSpanMsg = "";
        
        if (lifeSpan <= 0)
        {
            lifeSpanMsg = "No life span set for " + Name;
        }
        else
        {
            lifeSpanMsg = "Life span is " + lifeSpan + " years.";
        }

        Debug.Log(lifeSpanMsg);
    }

}
