# OOP Project in C#

A C# project designed to apply Object-Oriented Programming (OOP) principles, with a focus on class relationships and design patterns. This project demonstrates practical use of OOP principles such as encapsulation, inheritance, and polymorphism, along with commonly used design patterns.

## Table of Contents
- [Overview](#overview)
- [Task Description](#task-description)
- [Features](#features)
- [Requirements](#requirements)
- [Setup](#setup)

## Overview

This project was developed to demonstrate Object-Oriented Programming concepts in C#. Key aspects of the project include:
- **Class relationships**: Illustrating interactions between different classes.
- **Design patterns**: Implementing design patterns to achieve flexible and reusable code.
- **Unit testing**: Comprehensive unit tests to ensure code quality and reliability.
- 
## Task Description

This project is based on the following task:

Cathy has several hobby animals: fishes, birds, and dogs. Each animal has a name, and their exhilaration level is between 0 and 100 (where 0 means the animal dies). The project simulates Cathy's daily routines and their effects on the exhilaration levels of her animals based on the following conditions:

- **Good day**: Cathy is in a good mood and takes care of all her animals. Their exhilaration levels increase as follows:
  - Fishes: +1
  - Birds: +2
  - Dogs: +3

- **Ordinary day**: Cathy takes care of only the dogs. Exhilaration levels change as follows:
  - Fishes: -3
  - Birds: -1
  - Dogs: No change

- **Bad day**: Cathy is in a bad mood, and all animals lose exhilaration:
  - Fishes: -5
  - Birds: -3
  - Dogs: -10

If the exhilaration level of every living animal is at least 5, Cathy's mood improves by one.
### Input
All data is stored in a text file:
1. The first line contains the number of animals.
2. Each subsequent line contains:
   - The type of animal (`F` - Fish, `B` - Bird, `D` - Dog)
   - The name of the animal (one word)
   - The initial level of exhilaration
3. The last line contains the daily moods of Cathy, represented as characters (`g` - good, `o` - ordinary, `b` - bad).

### Output
At the end of the simulation, the program determines the name(s) of the animal(s) with the lowest exhilaration level that are still alive. If multiple animals share the same level, all their names are listed.

## Features

- Modular, maintainable code using OOP principles.
- Design patterns such as Singleton for Good, Ordinary, Bad classes and visitor pattern between animals and cathy classes.
- Extensive unit testing to ensure functionality.

## Requirements

- .NET SDK (version 5.0 or later)
- IDE like Visual Studio or Visual Studio Code

## Setup

1. Clone the repository:

   ```bash
   git clone https://github.com/sareh24/OOP-project.git

