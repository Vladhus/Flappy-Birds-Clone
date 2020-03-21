using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class repitinggackground : MonoBehaviour
{
    private BoxCollider2D groundcollider;
    private float groundHorizontalLenght;
    // Start is called before the first frame update
    void Start()
    {
        groundcollider = GetComponent<BoxCollider2D>();
        groundHorizontalLenght = groundcollider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -groundHorizontalLenght)
        {
            repositionbackground();
        }
    }
    private void repositionbackground()
    {
        Vector2 groundOffset = new Vector2(groundHorizontalLenght * 2f, 0);
        transform.position = (Vector2)transform.position + groundOffset;
    }
}
