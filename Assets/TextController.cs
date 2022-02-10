using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Text text;
    public enum States {intro, cell, tile_0, tile_1, comb, food_0, food_1, sneak_print, lock_0, lock_1, lock_2, freedom};
    private States myState;
    // Start is called before the first frame update
    void Start()
    {
        text.text = "Your name is Mr. Bhavya. Your look-alike criminal escaped from prison last night, " +
                    "and next day you are spotted and mistaken for your look-alike criminal and so you end up " +
                    "in prison. You were beaten up during your arrest and you wake up in your cell, which stinks heavily. " +
                    "You ask yourself, 'Can I Escape from this HELL?! \n\nPress [ P ] to Play the Game. Good Luck, Have Fun!";
        myState = States.intro;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
        if(myState == States.cell)
        {
            state_cell();
        }
        if(myState == States.tile_0)
        {
            state_tile_0();
        }
        if(myState == States.tile_1)
        {
            state_tile_1();
        }
        if(myState==States.comb)
        {
            state_comb();
        }
        if(myState==States.food_0)
        {
            state_food_0();
        }
        if(myState==States.food_1)
        {
            state_food_1();
        }
        if(myState==States.sneak_print)
        {
            state_sneak_print();
        }
        if(myState==States.lock_0)
        {
            state_lock_0();
        }
        if(myState==States.lock_1)
        {
            state_lock_1();
        }
        if(myState==States.lock_2)
        {
            state_lock_2();
        }
        if(myState==States.freedom)
        {
            state_freedom();
        }
    }
    void state_cell()
    {
        text.text = "You are sitting on your wooden seat. There is a plate on the floor with stale food. There is an " +
                    "iron-door and it is locked from outside. On the floor, there are tiles all around and there is " +
                    "too much darkness. Only 2 small iron-bars window is present. There is a comb in a nearby jar which " +
                    "has very sharp teeth and could be used to cut those 2 iron-bars. At present, a member of clean-up crew " +
                    "has entered your cell. You can see keys hanging on his belt.\n\nPress [ L ] to interact with Lock, " +
                    "[ C ] to interact with Comb, [ F ] to interact with Food, [ T ] to interact with Tiles and " +
                    "[ S ] to Sneak behind and interact with keys ";
        if(Input.GetKeyDown(KeyCode.C))
        {
            myState = States.comb;
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            myState = States.food_0;
        }
        else if(Input.GetKeyDown(KeyCode.T))
        {
            myState = States.tile_0;
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            myState = States.sneak_print;
        }
        else if(Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_0;
        }
    }

    void state_tile_0()
    {
        text.text = "You interact with tiles and find out that they are almost to the point where they can be taken out easily!" +
                    "\n\nPress [ R ] to Return to your Seat.";
        if(Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;  
        }
    }

    void state_comb()
    {
        text.text = "You take the comb and try to cut those iron-bars! Sadly, no luck! But, the comb is still pretty sharp to " +
                    "cut something precisely. You think of recreating a key from this later on.\n\nPress [ R ] to Return to your Seat.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_food_0()
    {
        text.text = "The food on the plate is not edible anymore. You can create any shapes with it. It can almost take any form." +
                    "\n\nPress [ M ] to Mould your stale food and [ R ] to Return to your seat.";
        if(Input.GetKeyDown(KeyCode.M))
        {
            myState = States.food_1;
        }
        else if(Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_food_1()
    {
        text.text = "The food could become anything so you created a clown with it because you liked Joker from Batman." +
                    "\n\nPress [ R ] to Return to your Seat.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_sneak_print()
    {
        text.text = "You have printed the key’s print on your food successfully!\n\nPress [ W ] to Wait for the cleaner to return.";
        if (Input.GetKeyDown(KeyCode.W))
        {
            myState = States.lock_1;
        }
    }

    void state_lock_0()
    {
        text.text = "The door is very strong and you can’t do anything without keys, or perhaps its print maybe?\n\n" +
                    "Press [ R ] to Return to your Seat.";
        if (Input.GetKeyDown(KeyCode.R))
        {
            myState = States.cell;
        }
    }

    void state_lock_1()
    {
        text.text = "The cleaner goes away and you have the keys’ print on your food! Now you have to decide what you need to do! " +
                    "\n\nPress [ L ] to Interact with Lock and [ T ] to interact with Tile";
        if(Input.GetKeyDown(KeyCode.L))
        {
            myState = States.lock_2;
        }
        else if(Input.GetKeyDown(KeyCode.T))
        {
            myState = States.tile_1;
        }
    }

    void state_lock_2()
    {
        text.text = "You already have a print of keys on your food! Maybe you can create a duplicate key with tile and the print!" +
                    "\n\nPress [ R ] to Return to your seat";
        if(Input.GetKeyDown(KeyCode.R))
        {
            myState = States.lock_1;
        }
    }

    void state_tile_1()
    {
        text.text = "You take out a nearby tile, use the comb to make the exact same key like the prints on your food and now ready to " +
                   "test the duplicate key out.\n\nPress [ O ] to Open the door.";
        if(Input.GetKeyDown(KeyCode.O))
        {
            myState = States.freedom;
        }
    }

    void state_freedom()
    {
        text.text = "The door opens, and you see light! You are FREE! You finally did it, Mr. Bhavya! Congratulations on completing " +
                    "the game!\n\nPress [ P ] to Play again!";
        if(Input.GetKeyDown(KeyCode.P))
        {
            myState = States.cell;
        }
    }
}
