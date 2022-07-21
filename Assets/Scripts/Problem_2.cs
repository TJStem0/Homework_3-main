using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_2 : MonoBehaviour
{
    /*
     * Using a loop go through the disorder array and print out true or false if the numbers are in rising order
     * It should be false, as 2 is smaller than 5. In order would be 0,2,5.
    */
    bool isInOrder;

    void Start()
    {
        int[] disorder = new int[3]{0,5,2};

        for (int i = 0; i < disorder.Length - 1; i++)
        {
            if (disorder[i] < disorder[i + 1])
            {
                isInOrder = true;
            } else
            {
                isInOrder = false;
            }
        }

        print(isInOrder);
    }
}
