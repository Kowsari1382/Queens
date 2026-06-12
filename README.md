# 👑 N-Queens Problem Solver

A console-based C# application that solves the classic **N-Queens problem** using a recursive backtracking algorithm. The program finds and displays all valid configurations to place $N$ queens on an $N \times N$ chessboard such that no two queens threaten each other.

## 📋 Table of Contents

- [Features](#-features)
- [Algorithm Details](#-algorithm-details)
- [Technologies Used](#-technologies-used)
- [Prerequisites](#-prerequisites)
- [Installation](#-installation)
- [How to Use](#-how-to-use)
- [Example Usage](#-example-usage)
- [Project Structure](#-project-structure)
- [Contributing](#-contributing)
- [License](#-license)

## ✨ Features

- **Dynamic Board Size**: Solve the problem for any $N \times N$ chessboard.
- **Custom Starting Position**: Allows the user to specify the column for the first queen, restricting the search space.
- **Recursive Backtracking**: Efficiently explores all possible configurations using a depth-first search approach.
- **Conflict Detection**: Implements a `promising` function to instantly prune invalid paths by checking for column and diagonal attacks.
- **Clear Output**: Displays all valid solutions with the exact row (line) and column positions for each queen.

## 🧠 Algorithm Details

This project utilizes the **Backtracking** technique to solve the N-Queens problem:

1. **Row-by-Row Placement**: The algorithm attempts to place one queen in each row, starting from the first row.
2. **Promising Function**: Before placing a queen in a specific column, the `promising(int i)` method checks if the position is safe. A position is considered "promising" if it does not conflict with any previously placed queens:
   - **Column Check**: Ensures no two queens are in the same column (`col[i] == col[k]`).
   - **Diagonal Check**: Ensures no two queens are on the same diagonal (`Math.Abs(col[i] - col[k]) == i - k`).
3. **Backtracking**: If a valid position is found, the algorithm recursively moves to the next row. If it reaches a dead end (no valid columns in the current row), it backtracks to the previous row and tries the next available column.
4. **Solution Found**: When queens are successfully placed in all $N$ rows, the configuration is printed.

## 🛠 Technologies Used

| Technology | Purpose |
|------------|---------|
| C# | Programming language |
| .NET Framework | Runtime environment |
| Console Application | User interface |

## 📦 Prerequisites

Before running this project, ensure you have:

- [Visual Studio](https://visualstudio.microsoft.com/) (2019 or later) OR
- [.NET Framework](https://dotnet.microsoft.com/download) (4.0 or higher)
- Windows Operating System

## 🚀 Installation

### 1. Clone the Repository

```bash
git clone https://github.com/Kowsari1382/Queens.git
cd Queens
```

### 2. Open in Visual Studio

1. Open Visual Studio.
2. Click on **Open a project or solution**.
3. Navigate to the cloned repository and select `Queens/Queens.sln`.
4. Click **Open**.

### 3. Build and Run

- Press `F5` or click the **Start** button to run the application.
- Alternatively, build the project first (`Ctrl+Shift+B`) and run the executable from the `bin/Debug` folder.

## 🎮 How to Use

1. **Enter Board Size**: When prompted, input the number of queens (which also defines the $N \times N$ board size). For a standard chessboard, enter `8`.
2. **Set First Queen**: Input the starting column for the first queen (1-based index). The algorithm will only find solutions where the first queen is in this specific column.
3. **View Solutions**: The program will recursively search and print all valid configurations that satisfy your constraints.

## 🔢 Example Usage

Let's solve the **4-Queens problem** and force the first queen to be in column `2`:

```text
Hello, input number of queens:
4
input column of first queen:
2
line:1 column:2
line:2 column:4
line:3 column:1
line:4 column:3

good luck!
```
*Note: For $N=4$ and starting at column 2, there is exactly one valid solution: (2, 4, 1, 3).*

## 📁 Project Structure

```text
Queens/
└── Queens/
    ├── Queens/
    │   ├── Properties/          # Assembly info and resources
    │   ├── bin/Debug/           # Compiled binaries
    │   ├── obj/Debug/           # Build objects
    │   ├── App.config           # Application configuration
    │   ├── Program.cs           # Main logic (Backtracking & Promising)
    │   └── Queens.csproj        # Project file
    └── Queens.sln               # Solution file
```

### Key Methods in `Program.cs`

| Method | Description |
|--------|-------------|
| `Main()` | Handles user input for board size and first queen's column, then initiates the backtracking process. |
| `queens(int i)` | Recursive function that attempts to place the queen in row `i` and explores subsequent rows. |
| `promising(int i)` | Checks if the queen placed at row `i` is in a valid position (no column or diagonal conflicts with previous rows). |

## 🤝 Contributing

Contributions are welcome! If you have suggestions for improvements or new features:

1. Fork the repository.
2. Create a new branch (`git checkout -b feature/AmazingFeature`).
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`).
4. Push to the branch (`git push origin feature/AmazingFeature`).
5. Open a Pull Request.

### Ideas for Contributions

- **Visualize the Board**: Add a graphical representation of the chessboard using Windows Forms or WPF.
- **Performance Metrics**: Display the number of recursive calls and execution time.
- **Optimization**: Implement bitmasking or other optimization techniques to speed up the search.
- **All Solutions Mode**: Add an option to find all solutions without restricting the first queen's position.

## 📝 License

This project is open source and available for educational purposes.

## 👨‍💻 Author

**Sajjad Kowsari**

- GitHub: [@Kowsari1382](https://github.com/Kowsari1382)

## 📞 Support

If you encounter any issues or have questions, please open an issue on GitHub.

---

<div align="center">

**Happy Solving! ♟️**

**If you find this project useful, please consider giving it a ⭐!**

</div>
