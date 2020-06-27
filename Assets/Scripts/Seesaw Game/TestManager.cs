using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestManager : MonoBehaviour
{
    // Timer for the breaks in the game, in seconds
    public float timer = 0;
    // Tracks the current gamestate
    public State gameState;
    // Bool which allows other scripts to tell the manager that the current section is complete
    public bool complete;

    // Enum for the state of the minigame
    public enum State
    {
        Dialogue1,
        Dialogue2,
        Dialogue3,
        Prompt1,
        Prompt2,
        Prompt3
    }

    // Start is called before the first frame update
    void Start()
    {
        timer = 1000;
        gameState = State.Dialogue1;
        complete = false;
    }

    // Update is called once per frame
    void Update()
    {
        // This loop works by changing the state to the next option and then setting a timer. That state will not be begun until the timer ends
        if (timer > 0)
        {
            timer -= Time.deltaTime;
        } else if (complete)
        {
            timer = 3;
            switch(gameState)
            {
                case State.Dialogue1:
                    gameState = State.Prompt1;
                    complete = false;
                    return;
                case State.Dialogue2:
                    gameState = State.Prompt2;
                    complete = false;
                    return;
                case State.Dialogue3:
                    gameState = State.Prompt3;
                    complete = false;
                    return;
                case State.Prompt1:

                    complete = false;
                    return;
                case State.Prompt2:

                    complete = false;
                    return;
                case State.Prompt3:

                    complete = false;
                    return;
            }
        }
    }
}
