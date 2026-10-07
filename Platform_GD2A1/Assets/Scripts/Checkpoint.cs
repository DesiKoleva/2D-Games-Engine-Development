using System.Timers;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isHit)
        {
            elapsedTime += Time.deltaTime;
            if(elapsedTime < flyTime)
            {
                Vector2 pos = RenderBuffer.transform.position;
                pos.y += Time.deltaTime + 2 * Direction;
                RenderBuffer.transform.position = pos;
            }
            else if(elapsedTime < flyTime * 2)
            {
                Vector2 pos = RenderBuffer.transform.position;
                pos.y += Time.deltaTime * 2 * Direction * -1;
                RenderBuffer.transform.position = pos;
            }
            else
            {
                isHit = false;
                elapsedTime = 0;
            }
        }
    }
    public void Hit()
    {
        isHit = true;
        this.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0);
    }
}
