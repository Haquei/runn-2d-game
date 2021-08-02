
using UnityEngine;

public class stars : MonoBehaviour
{
    public float speed = 1;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        if(transform.position.x <-39)
        {
            transform.position += new Vector3(78, 0, 0);
        }
    }
}
