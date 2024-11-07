using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while(true){
            int randNumber=Random.Range(1,21);
            if(randNumber==5)
                continue;
            else if (randNumber==15)
                break;
            else 
                Debug.Log(randNumber);
        }
    }
}
