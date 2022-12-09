using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    
    private SpriteRenderer spriteRenderer;

    public Sprite[] sprites;
   // private int spriteIndex;
    private Vector3 direction;
    public float gravity = -9.8f;
    public float strength = 5f;
    // Start is called before the first frame update
    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Start()
    {
       // InvokeRepeating(nameof(AnimateSprite),0.15f, 0.15f);
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer(); 
    }
    void MovePlayer()
    {
       if(Input .GetKeyDown(KeyCode.Space))
        {
            direction = Vector3.up * strength;
        }
       if(Input .touchCount>0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Began)
            {
                direction = Vector3.up * strength;
            }  
        }
        direction.y += gravity * Time.deltaTime;
        transform.position += direction * Time.deltaTime;
    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag=="obstacle")
        {
            FindObjectOfType<GameManager>().GameOver();
        }
        else if(other.gameObject.tag=="Scoring")
        {
            FindObjectOfType<GameManager>().IncreaseScore();
        }
    }
}
