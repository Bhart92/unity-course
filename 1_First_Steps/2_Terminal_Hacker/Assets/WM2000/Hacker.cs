using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu("Brandon");
    }

    void ShowMainMenu (string name) {
        Terminal.ClearScreen();
        Terminal.WriteLine("Hello " + name);
        Terminal.WriteLine("What would you like to hack into?");
        Terminal.WriteLine("Press 1 for the local library");
        Terminal.WriteLine("Press 2 for the local Police Station");
        Terminal.WriteLine("Enter your selection");  
    }
    
	void OnUserInput(string input) {
        print(input);
        }


    // Update is called once per frame
    void Update()
    {
        
    }
}
