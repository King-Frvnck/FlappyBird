using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D col)
    {
        if(col.gameObject.tag == "Player")
        {
            transform.position += Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x;
            //This line moves the background to the right.
            //We use GetComponent<SpriteRenderer>().bounds.size.x to get the bacckgrounds size
        }
    }
}
