using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public static gamemanager instance;
    public Transform prefab;
    static int wall = 30;
    static int size = 10;
    public int[,] arr = new int[size, size];
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        map_gen();
        make_board();
    }

    public void map_gen()
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
    void make_board()
    {
        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                int yy = y;
                int xx = x;
                Transform cell = Instantiate(prefab, new Vector3(yy, xx, 0), Quaternion.identity);
                cell.GetComponent<can>().x = x;
                cell.GetComponent<can>().y = y;
            }
        }
    }


}
