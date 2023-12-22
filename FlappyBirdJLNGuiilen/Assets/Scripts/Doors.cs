using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Doors : MonoBehaviour
{
    public GameObject Barriers;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Bird>().transform.position = new Vector2(transform.position.x, 0f);
        Instantiate(Barriers);
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void Clone()
    {

    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<Bird>() != null)
        {
            GameControl.Instance.shipScore();
        }
    }
}
