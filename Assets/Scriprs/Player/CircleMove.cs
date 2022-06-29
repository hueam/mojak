using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMove : MonoBehaviour
{
    private Transform _centerTrm;
    private Transform _outerTrm;

    private float _angle;
    [SerializeField] private float _speed = 180f;

    private void Awake()
    {
        _centerTrm = transform.Find("Blue");
        _outerTrm = transform.Find("Red");
        _angle = 180f;
    }

    private void Update()
    {
        Vector3 dir = _outerTrm.position - _centerTrm.position;

        dir = Quaternion.Euler(0, 0, Time.deltaTime * _speed) * dir;
        _outerTrm.position = _centerTrm.position + dir;
    }

    public void ChangeCircle()
    {
        Transform temp = _outerTrm;
        _outerTrm = _centerTrm;
        _centerTrm = temp;
    }
    public void Match()
    {
        
        if(Physics2D.OverlapCircle(_outerTrm.position, 0.5f, 1 << 9))
        {
            Block block = Physics2D.OverlapCircle(_outerTrm.position, 0.5f, 1 << 9).GetComponent<Block>();
            block.OnBlock(_outerTrm);
            ChangeCircle();
        }
        else
        {
            Debug.Log("¹Û");
        }
    }
}