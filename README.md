# Notification Channel Parser

This is a C# console application that parses notification titles to identify and assign them to different notification channels. The application recognizes specific tags enclosed in square brackets and outputs the valid channels found in the input.

## Features

- Parses notification titles for specific channel tags.
- Supports tags: `[BE]`, `[FE]`, `[QA]`, and `[Urgent]`.
- Ignores irrelevant content and extracts only valid channels.
- Case-insensitive tag recognition.

## Running the Application
To run the application, execute the following command:

dotnet run
