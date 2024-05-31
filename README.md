# ScriptGrabber

The initial release of ScriptGrabber, a versatile Windows application designed to help developers organize and consolidate their C# scripts from multiple folders into a single, well-structured document. This tool was created to enhance productivity by providing a quick reference to scripts, especially useful when interacting with tools like ChatGPT.

I wanted to be able to quickly gather all my scripts into one document so I can reference all my scripts as ChatGPT would get bogged down after a bit and the only thing I could do is start in a new window. While it does remember what you talk about now, I found that it would still forget stuff and the only way would be to "refresh" its memory. It would become tedious, so this app can quickly gather all your scripts and make a document to upload.

It will not add subfolders so you can specify exactly what scripts you want to add by choosing the right folders. Although I might add that later. Really just made it for my needs but in case anyone else finds this useful, here you go.

## Features

- **Add Multiple Script Folders:** Easily add multiple folders containing C# scripts.
- **Manage Folders:** Remove individual folders or clear all folders with a single click.
- **Project Description:** Include a project description at the top of the generated document.
- **Save and Load Projects:** Save the current project setup and reload it anytime.
- **Generate Consolidated Document:** Compile all scripts into a single, well-organized document with clearly defined sections.
- **Desktop Icon:** Create a desktop shortcut during installation for easy access.
- **Future Plans:** Potentially support other file types based on user feedback and requirements.

## Screenshots

![DSS_ScreenShot](https://github.com/tonydpatterson/ScriptGrabber/assets/2945988/721d46cf-0495-4b11-b8b5-0a9852679fb9)

## Requirements

- .NET 6.0 (or later)
- Windows OS

## Installation

### Using the Installer

1. Download the latest installer from the [releases page](https://github.com/tonydpatterson/ScriptGrabber/releases).
2. Run the installer (`ScriptGrabberSetup.exe`).
3. Follow the on-screen instructions to complete the installation.

### From Source

1. Clone the repository:
   ```bash
   git clone https://github.com/tonydpatterson/ScriptGrabber.git
   ```
2. Open the project in Visual Studio.
3. Build the project in Release mode.
4. Run the application from the `bin\Release\net6.0-windows` directory.

## Usage

### How to Use ScriptGrabber

1. **Launch the Application:**
   - Open ScriptGrabber from the Start Menu or Desktop shortcut.

2. **Add Script Folders:**
   - Click the "Add Folder" button.
   - Browse to and select the folder containing your C# scripts.
   - Repeat to add multiple folders.

3. **Remove or Clear Folders:**
   - To remove a folder, select it from the list and click "Remove Folder".
   - To clear all folders, click the "Clear Folders" button.

4. **Enter Project Description:**
   - Type a description of your project in the "Project Description" text box.

5. **Save Project:**
   - Click the "Save Project" button to save your current project setup.
   - Choose a location and filename for the project file.

6. **Load Project:**
   - Click the "Load Project" button to load a previously saved project file.
   - Browse to and select the project file to load.

7. **Set Save Location:**
   - Click the "Save Location" button to choose where the consolidated document will be saved.

8. **Generate Document:**
   - Click the "Generate Document" button to create a single document containing all your scripts and the project description.

9. **Open Save Location:**
   - After generating the document, click "Open Save Location" to open the folder containing the generated document.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.
