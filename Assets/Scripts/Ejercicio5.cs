using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5 : MonoBehaviour
{
    public int num1;
    public int num2;
    // Start is called before the first frame update
    void Start()
    {
        int res;

        if (num2 == 0)
        {
            Debug.Log("ERROR, no se puede dividir por 0");
        }
        else
        {
            res = num1 / num2;

            Debug.Log(num1 + "/" + num2 + "=" + res);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
