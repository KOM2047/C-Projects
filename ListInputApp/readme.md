# User Input Occurrence Counter

## Overview

This C# console application collects user inputs, automatically detects their data types, and counts how many times each unique input appears.

## Features

- **Automatic Type Detection**: The program attempts to parse user input into an integer, double, boolean, or DateTime. If none of these match, the input remains a string.
- **Dynamic Input Collection**: Users can enter multiple values until they type `"exit"` to stop.
- **Occurrence Counting**: Uses a generic method to store inputs in a list and count their occurrences.
- **Console Output**: Displays each unique input alongside its frequency.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (Recommended: Version 5.0 or later)

## How to Run

1. **Clone or Download the Repository**
   - Copy the project files to your local machine.

2. **Open the Terminal or Command Prompt**
   - Navigate to the folder containing the C# source file.

3. **Build and Run the Project**
   - Build the project:
     ```bash
     dotnet build
     ```
   - Run the application:
     ```bash
     dotnet run
     ```

4. **Usage**
   - The application prompts for input.
   - Enter values one at a time.
   - Type `exit` when done.
   - The program will display the number of times each input appeared.

## Code Structure

### `Main` Method
- Reads user input using `Console.ReadLine()`.
- Calls `ParseInput` to automatically determine the correct data type.
- Stores parsed values in a list and calls `CountOccurrences`.

### `ParseInput` Method
- Converts user input into different data types (int, double, bool, DateTime).
- Defaults to a string if no conversion applies.

### `CountOccurrences<T>` Method
- Uses a dictionary to count occurrences of each unique value.
- Prints results in the format: `{value}: {count} time(s)`.

## Potential Enhancements

- **Additional Data Type Parsing**: Extend `ParseInput` to support more types.
- **Input Validation**: Add error handling for unexpected formats.
- **File Input Support**: Modify the program to read from a file instead of console input.

## License

This project is open-source under the MIT License.

## Contributions

Feel free to submit issues or pull requests to improve functionality.

