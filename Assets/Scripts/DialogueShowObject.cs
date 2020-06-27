using System.Collections.Generic;
using UnityEngine;

class DialogueShowObject : DialogueNode
{
    public GameObject target;

    public DialogueShowObject(GameObject target, List<DialogueNode> path = null) : base(path)
    {
        this.target = target;
    }
}
