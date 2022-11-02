using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    public string Name = "Thure";
    private int Lvl = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Calling(Name, Lvl));
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    private int Calling(string name, int lvl)
    {
        Debug.Log(name);
        Debug.Log(lvl);
        lvl++;
        return lvl;
    }

}
