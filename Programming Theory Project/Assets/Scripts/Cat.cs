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

    private void Start()
    {
        MakeSound();
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

}
