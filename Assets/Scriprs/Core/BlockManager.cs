using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour
{
    public static BlockManager instance;
    [SerializeField]
    List<Transform> _blocks = new List<Transform>();
    StartBlock _startBlock;
    EndBlock _endBlock;
    Dictionary<int, Block> _blocksDict = new Dictionary<int, Block>();
    Transform _blockGroupTrm;
    void Awake()
    {
        _blockGroupTrm = GameObject.Find("BlockGroup").GetComponent<Transform>();
        for (int i = 0; i < _blockGroupTrm.childCount; i++)
        {
            _blocks.Add(_blockGroupTrm.GetChild(i));
            _blocksDict.Add(i, _blockGroupTrm.GetChild(i).GetComponent<Block>());
        }
    }
    //bool CheckBlack(Block nextBlock)
    //{
    //    bool isNextBlack;
    //    if (nextBlock == )
    //        return isNextBlack;
    //}
    void Update()
    {

    }
}
