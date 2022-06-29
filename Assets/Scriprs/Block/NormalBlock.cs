using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalBlock : Block
{
    public override void OnBlock(Transform outerTrm)
    {
        outerTrm.position = transform.position;
    }
}
