# Calculator

A simple console-based calculator application built in C#. It takes two numbers from the user, performs a chosen arithmetic operation, and lets the user repeat calculations without restarting the program.

## Features

- Supports **addition, subtraction, multiplication, and division**
- Handles **division by zero** gracefully (no crash, clear error message)
- Handles **invalid input** (non-numeric values, invalid operation names) without crashing
- Lets the user **perform multiple calculations** in a single run
- Clear, formatted result output

## Technologies Used

- **Language:** C#
- **Runtime:** .NET (Console Application)

## How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/Marwan-Haitham2142023/Marwan-Haitham2142023-Assignment2.git
   cd Marwan-Haitham2142023-Assignment2
   ```
2. Run the program:
   ```bash
   dotnet run
   ```
3. Follow the on-screen prompts:
   - Enter the first number
   - Enter the second number
   - Enter the operation: `Add`, `Subtract`, `Multiply`, or `Divide`
   - View the result
   - Choose `y` to calculate again, or any other key to exit

## Example

```
Enter first number:
10
Enter second number:
0
Enter operation (Add, Subtract, Multiply, Divide):
Divide
Error: Division by zero.
Do you want to perform another calculation? (y/n)
n
```

## Screenshot / Demo

![Calculator demo](screenshot.png)

*(Replace `screenshot.png` with an actual screenshot or GIF of the app running, placed in the repo root.)*

## Project Structure

```
Marwan-Haitham2142023-Assignment2/
├── Program.cs        # Main program and calculator logic
├── .gitignore         # Ignored files (bin/, obj/, etc.)
└── README.md          # Project documentation
```

## Git Workflow

This project was developed using feature branches merged into `main` via pull requests:

- `feature/basic-calculator` — core arithmetic logic
- `feature/repeat-calculation` — loop to allow repeated calculations
- `feature/input-validation` — division-by-zero and invalid input handling
- `docs/update-readme` — project documentation