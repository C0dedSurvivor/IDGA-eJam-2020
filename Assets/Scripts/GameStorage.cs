using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

class GameStorage : MonoBehaviour
{
    public static Dictionary<string, List<DialogueNode>> interactableDialogues = new Dictionary<string, List<DialogueNode>>();
    public static Dictionary<string, Sprite> sprites = new Dictionary<string, Sprite>();

    //A serialized list of sprites to assist in loading in necessary images for quick-swapping
    [SerializeField]
    private List<Sprite> spriteLoader = new List<Sprite>();

    [SerializeField]
    private Image dialogueBackground;

    [SerializeField]
    private GameObject wateringCan;
    [SerializeField]
    private Image background;
    [SerializeField]
    private List<GameObject> wateringCanButtons;
    [SerializeField]
    private List<GameObject> speakers;

    void Start()
    {
        /*
        interactableDialogues.Add(
            "test interactable", new List<DialogueNode>()
            {
                new DialogueLine("Speaker 1", "Hi, I'm speaking now."),
                new DialogueLine("Speaker 2", "And now I'm speaking."),
                new DialogueLine("Todd", "Buy Skyrim."),
                new DialogueSpriteSwitch(dialogueBackground, "check_mark"),
                new DialogueLine("Todd", "Press the T key to continue.", KeyCode.T),
                new DialogueLine("Todd", "Good, good."),
                new DialogueLine("Todd", "Let's get rid of that check mark."),
                new DialogueHideObject(dialogueBackground.gameObject),
                new DialogueLine("Todd", "Nevermind, I think I just needed to move it."),
                new DialogueMoveObject(dialogueBackground.gameObject, new Vector3(300, 300)),
                new DialogueShowObject(dialogueBackground.gameObject),
                new DialogueLine("Todd", "That's better."),
            }
            );
            */

        switch (SceneManager.GetActiveScene().name)
        {
            case "Room1":
                interactableDialogues.Add(
                    "room1Start", 
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Hi, I'm Productivity! I'm the part of you that makes sure you get done what needs to be done."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "And I'm Passion! I'm the one that makes sure you have some fun and do what you like to do!"),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "We can sometimes be at odds about how you should be using your time..."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Yea, this poopy head keeps trying to get you to do all the boring stuff!"),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Well Passion, we kind of need money to live."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Money shmoney, who needs it if your heart's not in what you're doing!"),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Well, if you want to live in a nice house and not be stuck with your parents you need to sit down and earn money through work."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "But is this where you belong? Stuck cooped up in an office? If you have a creative idea in mind you have to work on it now, or else you might not get the chance   to!"),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "This is what you're doing right here, right now. If it becomes a problem, you can change it later, after you've ensured you don't fall behind your peers."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Your projects are important to you though, and you enjoy working on them. It's important to stay happy."),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Well why don't we let them decide. Look around to see what we each have to say on the matter."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Calendar",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "You have deadlines to reach and limited time to reach them. You need to keep working to get it done in time."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Binder",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Plan out your future, you don't want to be left aimless."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Coffee",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Your co-workers and your connections are key to staying successful."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Butterflies",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "It doesn't matter how good you are now. Start small, you'll improve as you go!"),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Friends",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Your friends are key to staying sane and happy. Make time for them or you'll lose them!"),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1Canvas",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Always be willing to try something new, you never know when you'll find something you really enjoy!"),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room1End",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "I guess we're both needed in a way."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "Yea, as much as I hate to admit it you do kinda need money to do your hobbies..."),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "And while earning it is great you do need to make time to do what you love and destress or you might just implode."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "It's a balancing act!"),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Yes! Making time to listen to both of us is very difficult but important. I'm sure you can do it, though."),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "We shall see, won't we! Remember, persistence is key!"),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                break;
            case "BalanceGame":
                interactableDialogues.Add(
                    "balanceRoomStart",
                    new List<DialogueNode>()
                    {
                    }
                    );
                interactableDialogues.Add(
                    "balanceRoomEnd",
                    new List<DialogueNode>()
                    {
                    }
                    );
                break;
            case "Room2":
                interactableDialogues.Add(
                    "room2Start",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "voidDialogueBox"),
                    new DialogueLine("Parent", "They're your partner? I want to support you but I'm concerned. I've always dreamed of having grandchildren… You made me so happy, and I just want you to have that happiness..."),
                    new DialogueSpriteSwitch(dialogueBackground, "smileyDialogueBox"),
                    new DialogueLine("Partner", "You'll need to give them time, they'll come to accept it."),
                    new DialogueSpriteSwitch(dialogueBackground, "voidDialogueBox"),
                    new DialogueLine("Parent", "I just want you to follow what we did, since it worked out so well for us. I just want you to have a good future."),
                    new DialogueSpriteSwitch(dialogueBackground, "smileyDialogueBox"),
                    new DialogueLine("Partner", "We can forge our own destiny, think about what we want from life and reach that together regardless of what others say."),
                    new DialogueSpriteSwitch(dialogueBackground, "voidDialogueBox"),
                    new DialogueLine("Parent", "Have you seen your friends? They're already having children. I just want you to be able to have support from them like I did from my friends when I had you."),
                    new DialogueSpriteSwitch(dialogueBackground, "smileyDialogueBox"),
                    new DialogueLine("Partner", "Even if they don't say it, they still love you unconditionally. Let's look around, maybe we can find something to convince them more."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room2WateringCan",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "smileyDialogueBox"),
                    new DialogueLine("Partner", "Equip yourself with what you need to address the situation properly."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room2Plant",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "smileyDialogueBox"),
                    new DialogueLine("Partner", "The right space is key to nurture any relationship."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room2Sunlight",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "smileyDialogueBox"),
                    new DialogueLine("Partner", "They will still be a part of your life, even if you make a decision they don’t agree with."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room2End",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "smileyDialogueBox"),
                    new DialogueLine("Partner", "Ok, you ready to give talking to them a try? Yea? Great! I’m right behind you if you need me."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                break;
            case "TreeRoom":
                interactableDialogues.Add(
                    "treeRoomStart",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "voidDialogueBox"),
                    new DialogueLine("Parent", "I’m sure this is just a phase, you’ll grow out of it."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    new DialogueShowObject(wateringCanButtons[0]),
                    }
                    );
                interactableDialogues.Add(
                    "treeRoom1",
                    new List<DialogueNode>()
                    {
                    new DialogueHideObject(wateringCanButtons[0]),
                    new DialogueShowObject(wateringCan),
                    new DialoguePause(1),
                    new DialogueHideObject(wateringCan),
                    new DialogueSpriteSwitch(background, "tree2Background"),
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "voidDialogueBox"),
                    new DialogueLine("Parent", "I always thought you were going to end up with that friend of yours, I liked them a lot."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    new DialogueShowObject(wateringCanButtons[1]),
                    }
                    );
                interactableDialogues.Add(
                    "treeRoom2",
                    new List<DialogueNode>()
                    {
                    new DialogueHideObject(wateringCanButtons[1]),
                    new DialogueShowObject(wateringCan),
                    new DialoguePause(1),
                    new DialogueHideObject(wateringCan),
                    new DialogueSpriteSwitch(background, "tree3Background"),
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "voidDialogueBox"),
                    new DialogueLine("Parent", "You can still be friends with them, I just don’t know if you should be with them..."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    new DialogueShowObject(wateringCanButtons[2]),
                    }
                    );
                interactableDialogues.Add(
                    "treeRoom3",
                    new List<DialogueNode>()
                    {
                    new DialogueHideObject(wateringCanButtons[2]),
                    new DialogueShowObject(wateringCan),
                    new DialoguePause(1),
                    new DialogueHideObject(wateringCan),
                    new DialogueSpriteSwitch(background, "tree4Background"),
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "voidDialogueBox"),
                    new DialogueLine("Parent", "Could you please explain to me your feelings for them?"),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    new DialogueShowObject(wateringCanButtons[3]),
                    }
                    );
                interactableDialogues.Add(
                    "treeRoom4",
                    new List<DialogueNode>()
                    {
                    new DialogueHideObject(wateringCanButtons[3]),
                    new DialogueShowObject(wateringCan),
                    new DialoguePause(1),
                    new DialogueHideObject(wateringCan),
                    new DialogueSpriteSwitch(background, "tree5Background"),
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "voidDialogueBox"),
                    new DialogueLine("Parent", "I.. I love you. You’re the child I raised, and I’ll try to set aside my opinions and support you."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                break;
            case "Room3":
                interactableDialogues.Add(
                    "room3Start",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "expectationDialogueBox"),
                    new DialogueLine("Expectation", "Hi, I’m Expectation! I’m the part of you that looks towards the future you want!"),
                    new DialogueSpriteSwitch(dialogueBackground, "realityDialogueBox"),
                    new DialogueLine("Reality", "But I’m Reality, here to keep you in line with what you can actually reach."),
                    new DialogueSpriteSwitch(dialogueBackground, "expectationDialogueBox"),
                    new DialogueLine("Expectation", "But come on, look at this place! It’s so lovely! Wealth, friends, adventures, this is what you can achieve!"),
                    new DialogueSpriteSwitch(dialogueBackground, "realityDialogueBox"),
                    new DialogueLine("Reality", "It’s important to stay reasonable. You might not accomplish all of that. Stay grounded in the now, and use that to temper your future."),
                    new DialogueSpriteSwitch(dialogueBackground, "expectationDialogueBox"),
                    new DialogueLine("Expectation", "You could land an excellent job! The perfect dream job, exactly what you wanted."),
                    new DialogueSpriteSwitch(dialogueBackground, "realityDialogueBox"),
                    new DialogueLine("Reality", "But if it’s not, that’s not awful, right? As long as you’re making a living, you can go until you find a chance for what you really want."),
                    new DialogueSpriteSwitch(dialogueBackground, "expectationDialogueBox"),
                    new DialogueLine("Expectation", "And the connections! If you know the right people, you’ll be able to get anything you want!"),
                    new DialogueSpriteSwitch(dialogueBackground, "realityDialogueBox"),
                    new DialogueLine("Reality", "Do you really need all that, though? You’ve got close friends, and I’m sure they’ll be able to introduce you to people. You don’t need the attention of the high-and-mighty to succeed."),
                    new DialogueSpriteSwitch(dialogueBackground, "expectationDialogueBox"),
                    new DialogueLine("Expectation", "Ah whatever, just look around at this great stuff and make a decision."),
                    new DialogueSpriteSwitch(dialogueBackground, "realityDialogueBox"),
                    new DialogueLine("Reality", "But remember to stay grounded..."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room3Clock",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "realityDialogueBox"),
                    new DialogueLine("Reality", "Time is the key to all things. Persistence and time will get you where you want to go, even if it seems far fetched."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room3Painting",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "expectationDialogueBox"),
                    new DialogueLine("Expectation", "The picture of our reality that we paint for ourselves is open to our own interpretation. Don’t be afraid to muddle the colors and end up somewhere unexpected!"),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room3Water",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "realityDialogueBox"),
                    new DialogueLine("Reality", "Stay focused. You can achieve more than you might think you’re capable of if you focus on it."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                interactableDialogues.Add(
                    "room3End",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueSpriteSwitch(dialogueBackground, "realityDialogueBox"),
                    new DialogueLine("Reality", "Ah great, you found everything. Now let’s put it all together. Remember everything you’ve learned, and use them as stepping stones to be the best “you” you can be."),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    }
                    );
                break;
            case "Room4":
                interactableDialogues.Add(
                    "room4Start",
                    new List<DialogueNode>()
                    {
                    new DialogueShowObject(dialogueBackground.gameObject),
                    new DialogueShowObject(speakers[0]),
                    new DialogueSpriteSwitch(dialogueBackground, "productivityDialogueBox"),
                    new DialogueLine("Productivity", "Keep putting your all into everything you do, and stay on track..."),
                    new DialogueHideObject(speakers[0]),
                    new DialogueShowObject(speakers[1]),
                    new DialogueSpriteSwitch(dialogueBackground, "passionDialogueBox"),
                    new DialogueLine("Passion", "But find the time to do what makes you happy, and don’t take life too seriously. There’s more to it than just working all day!"),
                    new DialogueHideObject(speakers[1]),
                    new DialogueShowObject(speakers[2]),
                    new DialogueSpriteSwitch(dialogueBackground, "smileyDialogueBox"),
                    new DialogueLine("Partner", "Make the decisions that are right for you..."),
                    new DialogueHideObject(speakers[2]),
                    new DialogueShowObject(speakers[3]),
                    new DialogueSpriteSwitch(dialogueBackground, "voidDialogueBox"),
                    new DialogueLine("Parent", "But try not to leave behind those you love."),
                    new DialogueHideObject(speakers[3]),
                    new DialogueShowObject(speakers[4]),
                    new DialogueSpriteSwitch(dialogueBackground, "realityDialogueBox"),
                    new DialogueLine("Reality", "Never forget where you are..."),
                    new DialogueHideObject(speakers[4]),
                    new DialogueShowObject(speakers[5]),
                    new DialogueSpriteSwitch(dialogueBackground, "expectationDialogueBox"),
                    new DialogueLine("Expectation", "But always look towards where you want to be."),
                    new DialogueHideObject(speakers[5]),
                    new DialogueShowObject(speakers[6]),
                    new DialogueSpriteSwitch(dialogueBackground, "allDialogueBox"),
                    new DialogueLine("All", "If you can do that, you'll really live a life worth celebrating!"),
                    new DialogueHideObject(dialogueBackground.gameObject),
                    new DialogueHideObject(speakers[6]),
                    new DialogueSpriteSwitch(background, "EndScreen"),
                    new DialogueLine("", ""),
                    }
                    );
                break;
        }

        foreach (Sprite sprite in spriteLoader)
        {
            sprites.Add(sprite.name, sprite);
        }
    }
}
