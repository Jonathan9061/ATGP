using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TDC : MonoBehaviour
{
    public Transform[] Checks;
    public GameObject[] Tiles;
    bool up;
    bool down;
    bool right;
    bool left;
    int degree;
    public LayerMask layer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

            CheckSurroundings();
            DegreeAndDirectionality();
           ChooseTile();
        
    }

    void CheckSurroundings()
    {

        up = Physics2D.OverlapCircle(Checks[0].transform.position, 0.1f, layer);
        right = Physics2D.OverlapCircle(Checks[1].transform.position, 0.1f, layer);
        left = Physics2D.OverlapCircle(Checks[3].transform.position, 0.1f, layer);
        down = Physics2D.OverlapCircle(Checks[2].transform.position, 0.1f, layer);
    }

    void DegreeAndDirectionality()
    {
        if (up)
        {
            degree += 1;
        }
        if (down)
        {
            degree += 1;
        }
        if (right)
        {
            degree += 1;
        }
        if (left)
        {
            degree += 1;
        }
    }

    void ChooseTile()
    {
        foreach(Transform child in transform)
        {
            if(child.gameObject.layer == 3)
            {
                Destroy(child.gameObject);
            }
        }
        if(degree == 0)
        {
            GameObject currChild = Instantiate(Tiles[0], transform.position, Quaternion.identity);
            currChild.transform.parent = gameObject.transform;
            
        }
        if (degree == 1)
        {
            if (up)
            {

                GameObject currChild = Instantiate(Tiles[1], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }
            if (right)
            {

                GameObject currChild = Instantiate(Tiles[2], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }
            if (down)
            {

                GameObject currChild = Instantiate(Tiles[3], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }
            if (left)
            {

                GameObject currChild = Instantiate(Tiles[4], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }

        }
        if (degree == 2)
        {
            if (up && right)
            {

                GameObject currChild = Instantiate(Tiles[5], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }
            if (right && down)
            {

                GameObject currChild = Instantiate(Tiles[6], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }
            if (down && left)
            {

                GameObject currChild = Instantiate(Tiles[7], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }
            if (left && up)
            {

                GameObject currChild = Instantiate(Tiles[8], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }
            if(right && left)
            {

                GameObject currChild = Instantiate(Tiles[9], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }
            if (up && down)
            {

                GameObject currChild = Instantiate(Tiles[10], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }

        }
        if (degree == 3)
        {
            if (up && right && left)
            {

                GameObject currChild = Instantiate(Tiles[11], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }
            if (right && down && left)
            {

                GameObject currChild = Instantiate(Tiles[12], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }
            if (down && left && up)
            {

                GameObject currChild = Instantiate(Tiles[13], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }
            if (right && up && down)
            {

                GameObject currChild = Instantiate(Tiles[14], transform.position, Quaternion.identity);
                currChild.transform.parent = gameObject.transform;
            }

        }
        if (degree == 4)
        {
            Debug.Log("4");
            GameObject currChild = Instantiate(Tiles[15], transform.position, Quaternion.identity);
            currChild.transform.parent = gameObject.transform;


        }

        degree = 0;
        up = false;
        down = false;
        right = false;
        left = false;
    }
}
