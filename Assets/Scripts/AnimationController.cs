using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private int animationVariable = 0;
    private Animator _animator;

    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnMouseDown();
        }      
    }

    void OnMouseDown()
    {
        animationVariable = (animationVariable + 1) % 3;
        _animator.SetInteger("State", animationVariable);
    }
}
