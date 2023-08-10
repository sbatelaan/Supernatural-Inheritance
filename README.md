# Supernatural-Inheritance


This beginner-level C# project is designed to help you become familiar with the concepts of classes, inheritance, and method overrides in C#. The project simulates a magical guild where different types of magicians can cast storms with varying strengths and essences.

## Project Overview

The project focuses on the following key concepts:

- **Classes:** The project uses several classes to represent different types of magicians: `Pupil`, `Mage`, `Archmage`, and `Storm`.

- **Inheritance:** The magician classes (`Mage` and `Archmage`) inherit properties and methods from the base class (`Pupil`). This reduces code duplication and helps structure the hierarchy of magician ranks.

- **Method Overrides:** The `Archmage` class overrides a method (`CastRainStorm()`) inherited from its parent class (`Mage`). This demonstrates how to customize behavior while leveraging inheritance.

## Project Structure

- `Program.cs`: Contains the `Main` method where instances of the magician classes are created and their methods are called to demonstrate their functionality.

- `Pupil.cs`: Defines the `Pupil` class, which represents the lowest rank of magicians. It has a constructor and a `CastWindStorm()` method.

- `Mage.cs`: Defines the `Mage` class, which inherits from `Pupil`. It adds a `CastRainStorm()` method that is marked as `virtual`.

- `Archmage.cs`: Defines the `Archmage` class, which inherits from `Mage`. It overrides the `CastRainStorm()` method and adds a `CastLightningStorm()` method.

- `Storm.cs`: Defines the `Storm` class, which represents a storm created by a magician. It has properties for essence, strength, and the caster. It also has a constructor and an `Announce()` method.

## Getting Started

1. Clone or download the project to your local machine.

2. Open the project in your preferred C# development environment (e.g., Visual Studio, Visual Studio Code).

3. Review the code and comments in the different files to understand the class structure, inheritance, and method overrides.

4. Run the program to see the examples of class instantiation, method calls, and the effects of inheritance and overrides.

## Project Walkthrough

The provided code demonstrates how different magician classes (`Pupil`, `Mage`, `Archmage`) can create storms with varying strengths and essences (`Storm` class). The `Main` method in `Program.cs` creates instances of these classes and calls their methods to create and announce storms.

Feel free to modify the project, add new methods, experiment with different properties, and explore more about classes, inheritance, and method overrides in C#.
