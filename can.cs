using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class can : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite red;
    public Sprite black;
    public Sprite white;
    public int x;
    public int y;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        color_update();
    }

    void color_update()
    {
        if (gamemanager.instance.arr[y,x]==0)
        {
            spriteRenderer.sprite = white;
        }
        else if (gamemanager.instance.arr[y, x] == 1)
        {
            spriteRenderer.sprite = black;
        }
        else if (gamemanager.instance.arr[y, x] == 2)
        {
            spriteRenderer.sprite = red;
        }

    }
}
