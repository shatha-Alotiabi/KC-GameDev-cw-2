using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class space12 : MonoBehaviour
{
    int age = 17;
    int height = 180;
    string heroSuperPower = "sword";
    string name = "Zoro";
    bool ishero = true;
    string villainName = "mikan";
    int villainHeight = 178;
    int villainAge = 15;
    string villainSuperpower = "ice";

    // Start is called before the first frame update
    void Start()
    {
        print("The hero's name is " + name + " and his age is " + age);
        print("The hero's height is " + height);
        print("The prophecy says that he is a " + ishero + "hero, with a superpower of " + heroSuperPower);
        print("The villain's name is " + villainName + " and the villan age is " + villainAge);
        print("The villain's height is " + villainHeight);
        print("The villain's superpower is " + villainSuperpower);
        int ageDifference = age - villainAge;
        print(ageDifference);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
