using System;
using UnityEngine;
using TreeSharpPlus;
using System.Collections;

public class AgentBehavior : Behavior
{
    AgentState State;
    protected Node BuildTreeRoot()
    {
        return
            new DecoratorLoop(
                new Sequence(
                    new LeafWait(6000),
                    this.Node_Gesture("being_cocky")));
    }

    void Start()
    {
        base.StartTree(this.BuildTreeRoot());
    }
}
