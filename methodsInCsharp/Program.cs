
int num =3;
num =5; // this is stateful becuz it is changing the previous state
Console.WriteLine("hello"); // this is stateless because it doesn't hamper other LOC.
Console.WriteLine(num);


//this is instance of a Random class -- It is called an object.
Random dice = new();
int roll = dice.Next(); // this also the stateful method since it is using the state variable dice checking the previous state.
Console.WriteLine(roll);
/*Have you ever questioned what that new is for??
    1. request address in computer's memory,
    2. create new object and store it in the address
    3. return the address and store in dice object.
Now here the dice is like a variable thats stores the state of Random Class
*/

