using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseGridPlacingTD : MonoBehaviour
{
    public GameObject Tile;
    public GameObject Cursor;
    Vector2 pos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pos = new Vector2(Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).x), Mathf.RoundToInt(Camera.main.ScreenToWorldPoint(Input.mousePosition).y));
        Cursor.transform.position = pos;
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(Tile, pos, Quaternion.identity);
        }
    }
}
