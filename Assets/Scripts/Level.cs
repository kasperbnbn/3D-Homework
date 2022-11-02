using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public string Name = "Thure";// Here the first int this defined and is what our character is called.
    private int Lvl = 1;// This is the first int, which defines our starting lvl.
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Calling(Name, Lvl));// We print the updated variabels.


    }

    // Update is called once per frame
    void Update()
    {
       
    }
    //A new method is created and is used to update our lvl and return it so it can get printed.
    private int Calling(string name, int lvl)
    {
        Debug.Log(name);
        Debug.Log(lvl);
        lvl++;// The new variabel gets 1 higher here
        return lvl; // This is where to return the data.
    }

}
