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
    // The method is based on a string and int, which gets defined at the top of the script. In the method 2 new variabels will be made and not defined, one string and one int.
    // In the method the defined lvl will get 1 higher and then returned, and then in the start method it will be debugged, with the old 2 variabels.
    private int Calling(string name, int lvl)
    {
        Debug.Log(name);
        Debug.Log(lvl);
        lvl++;
        return lvl;
    }

}
