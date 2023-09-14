// **** Begin Main*******//

double temp = GetTemperature();

string clothes = WhatToWear(temp);

DisplayMessage(clothes);


// ***** End Main ********//

static double GetTemperature(){
    System.Console.WriteLine("What is the current temperature outside (farenheit)");
    double temp = double.Parse(Console.ReadLine());
    return temp;
}

static string WhatToWear(double temp){
    string clothes;
    if(temp < 55){
        clothes = "jacket";
    } else{
        clothes = "shirt";
    }

    return clothes;
}

static void DisplayMessage(string clothes){
    if(clothes == "jacket"){
        System.Console.WriteLine("I didn't know it got cold in Alabama!!🤯");
    } else{
        System.Console.WriteLine("That is a okay");
    }
}