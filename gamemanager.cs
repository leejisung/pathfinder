using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    static int wall = 30;
    static int size = 10;
    public int[,] arr = new int[size, size];
    // Start is called before the first frame update
    void Start()
    {
        map_gen();

    }

    void map_gen()
    {
        for (int y = 0; y < size; y += 1)
        {
            for (int x = 0; x < size; x += 1)
            {
                arr[y, x] = 0;
            }
        }
        int block = wall;
        while (block != 0)
        {
            int x = Random.Range(0, size);
            int y = Random.Range(0, size);
            if ((y == x & x == 0) | (y == x & x == size) | arr[y, x] == 1)
            {
                continue;
            }
            else
            {
                arr[y, x] = 1;
                block -= 1;
            }
        }
    }


}
