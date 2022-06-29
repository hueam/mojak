using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public static BlockManager instance;
    [SerializeField]
    List<Block> _blocks = new List<Block>();
    StartBlock _startBlock;
    EndBlock _endBlock;
    int _nowBlockIndex;
    Transform _blockGroupTrm;
    void Awake()
    {
        _blockGroupTrm = GameObject.Find("BlockGroup").GetComponent<Transform>();
        for (int i = 0; i < _blockGroupTrm.childCount; i++)
        {
            Block block = _blockGroupTrm.GetChild(i).GetComponent<Block>();
            _blocks.Add(block);
        }
        _nowBlockIndex = 0;
    }
    public bool ChangeBlock(Block onBlock)
    {
        bool isNextBlock = false;
        if(_blocks[_nowBlockIndex+1] == onBlock)
        {
            isNextBlock = true;
            _nowBlockIndex++;
        }
        return isNextBlock;
    }
    void Update()
    {

    }
}
