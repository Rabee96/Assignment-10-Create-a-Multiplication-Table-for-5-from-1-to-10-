using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log($"{i} * 5 = " + Multiply(i,5));
        }
        
    }

    int Multiply(int num1,int num2){
        return num1*num2;
    }

}
