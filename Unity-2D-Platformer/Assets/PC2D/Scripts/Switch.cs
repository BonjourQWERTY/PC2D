using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public bool close = false;
    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(close == true && wall.transform.position.y < 3f)
        {
            wall.transform.Translate(Vector2.down * Time.deltaTime);

        }
        
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && transform.position.y > -4f)
        {
            transform.Translate(Vector2.down * Time.deltaTime);
        }
        else if (collision.tag == "Player" && wall.transform.position.y < 3f)
        {
            wall.transform.Translate(Vector2.up * Time.deltaTime);
        }

    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        transform.position = new Vector2(transform.position.x, 2f);
        close = true;
    }
}
