using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    // Timer for the breaks in the game, in seconds
    public float timer = 0;
    // Tracks the current gamestate
    public State gameState;

    // Enum for the state of the minigame
    public enum State
    {
        Prompt1,
        Prompt2,
        Prompt3
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 1000;
        gameState = State.Prompt1;
    }

    // Update is called once per frame
    void Update()
    {
    // This loop works by changing the state to the next option and then setting a timer. That state will not be begun until the timer ends
        timer = 3;
        switch(gameState)
        {
            case State.Prompt1:

                
                return;
            case State.Prompt2:

                
                return;
            case State.Prompt3:

                
                return;
        }
        
    }
}
