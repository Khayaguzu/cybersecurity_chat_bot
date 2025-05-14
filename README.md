Cybersecurity Awareness Chatbot
Overview
This is a simple console-based chatbot designed to help users learn about cybersecurity awareness. The chatbot provides information on various cybersecurity topics, such as phishing, strong passwords, VPNs, malware, and safe browsing.

Features
Plays a voice greeting when the program starts.

Displays an ASCII art logo from an image.

Greets the user and starts a conversation.

Provides predefined responses to cybersecurity-related questions.

Responds to emotional context (e.g., worried, frustrated).

Saves emotional and topical queries in a memory file.

Allows viewing of saved chat history.

Simulates a typing effect for a more interactive experience.

Allows users to exit the chat by typing "exit".

Technologies Used
C# (.NET)

System.Drawing for image processing (ASCII art generation)

System.Media for playing sound files

System.Threading for simulated typing effect

File I/O for chat history storage

Prerequisites
.NET installed on your system

A console environment (Windows Command Prompt, PowerShell, or Terminal)

A welcome.wav file in the root directory of the project

A logo.png file in the root directory of the project

Installation & Setup
Clone this repository or download the source code.

Ensure that welcome.wav and logo.png are placed in the project root directory.

Open the project in Visual Studio or any C# compatible IDE.

Build and run the project.

How to Use
Run the program.

Enter your name when prompted.

Start asking cybersecurity-related questions.

Use emotional phrases like "I'm curious about malware" to log memory.

Type "show history" to view saved emotional questions.

Type "exit" to close the chat.

Example Questions
"What is a strong password?"

"Tell me about phishing."

"How does a VPN work?"

"What is malware?"

Project Structure
Program.cs (Main Class)
Startup Sequence: Plays audio and shows an ASCII image.

User Onboarding: Prompts for a name and greets the user.

Conversation Loop: Processes user input, detects emotion or topic, and responds with relevant answers.

Emotion Detection: If user input contains emotional triggers (e.g., worried, curious), it logs the input along with the user's name to a text file.

Topic Matching: Matches keywords like password, phishing, etc., and gives a random response from a predefined list.

Typing Simulation: Chat responses appear character by character for realism.

check_writeFile.cs (Memory Handler)
Handles the saving and retrieving of emotionally-driven user queries:

check_file(): Checks for existence of memory.txt; creates it if missing.

return_memory(): Returns the full list of stored emotional user inputs.

save_memory(List<string>): Saves updated memory list back to the file.

Known Issues
If welcome.wav or logo.png is missing, the program may display an error.

ASCII art generation may not look perfect depending on console font settings.

File handling doesn't currently support concurrent writes.

Future Enhancements
Add more AI-based response generation.

Implement a GUI version of the chatbot.

Improve ASCII image rendering.

Integrate external APIs for up-to-date cybersecurity news.

Add natural language understanding for broader input flexibility.

