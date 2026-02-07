# Practical 03 

This practical covers three object-oriented programming concepts in C#: inheritance, polymorphism, and abstraction. Use the instructions below to implement and observe each concept.

## Inheritance
1. Create a class `Sponsor` with a protected variable `owner` initialized to `"Rakuteen"`.
2. Create a new class `Team` that extends `Sponsor` and has a private member `teamName`.
3. Create a method `printInfo()` that concatenates `owner` and `Sponser` and returns the string from the method.
4. Call `printInfo()` from `Main()`.

## Polymorphism
1. Create a class `Bird`.
2. Add a method named `Voice()` that prints the message `"Turr Turr"`.
3. Create a class `Duck` that extends `Bird`.
4. Add a method named `Voice()` that prints the message `"Quack Quack"`.
5. Define `Bird` and `Duck` in `Main()` as:
   ```csharp
   Bird myBird = new Bird();
   Duck myDuck = new Bird();

   myBird.Voice();
   myDuck.Voice();

   // Observe the output
   ```

## Abstraction
1. Create a class `Laptop` with the following private fields:
   - `string brand`
   - `string model`
2. Create properties to get and set `brand` and `model`.
3. Add the following method:
   ```csharp
   public void LaptopDetails()
   {
      Console.WriteLine("Brand: " + Brand);
      Console.WriteLine("Model: " + Model);
   }
   ```
4. Add the following private method:
   ```csharp
   private void MotherBoardInfo()
   {
      Console.WriteLine("MotherBoard Information");
   }
   ```
5. Try to access `LaptopDetails()` and `MotherBoardInfo()` from `Main()` after class initialization.
