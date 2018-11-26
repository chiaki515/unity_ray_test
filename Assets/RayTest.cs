using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour {

    GameObject clickedGameObject;
    Vector2 smlSize;

    void Start(){
        smlSize = new Vector2(0.5f, 0.5f);
    }

    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            clickedGameObject = null;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit2d = Physics2D.Raycast((Vector2)ray.origin, (Vector2)ray.direction);

            if (hit2d)
            {
                clickedGameObject = hit2d.transform.gameObject;
                hit2d.transform.localScale = smlSize;
            }

            Debug.Log(clickedGameObject);
        }
    }

}
