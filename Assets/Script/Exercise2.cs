using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
        string [] words={"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};

        string sentence ="";
        int num=0;
        while(num<7){

            int index=Random.Range(0,7);
            sentence=sentence+" "+words[index];
            num++;
        }
        Debug.Log(sentence);
    }

}
