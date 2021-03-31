using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Animator animator;
    protected Vector2 direction;
    

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        move();
    }

    public void move()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        moveAnimate(direction);
    }

    public void moveAnimate(Vector2 direction) 
    {
        animator.SetFloat("x",direction.x);
        animator.SetFloat("y", direction.y);
    }
}
