# ManyMinecraftMods
Create mod profiles (ManyPacks) and load them,

### How to install
Either download the `.zip` file and extract it before running the `.exe` file inside, or download the graphical installer and follow the instructions.

### How to use
ManyMinecraftMods has two main functions: creating ManyPacks (`.mpk` files) and importing them to your mods folder.

#### Creating a ManyPack
First, select a folder containing the mods and any config files for them using the "Select Folder of Mods" button. Fill in the metadata before hitting the "Create .mpk File" button at the buttom and choosing a save location. The ManyPack has been created.

#### Importing a ManyPack
First, you clear your mods directory using the "Clear then push" button. Your mods directory will be empty after this. Then, use the "Select .mpk File" button to choose a ManyPack to import. Once it is chosen, either press the "Push to mods folder" button or the "Clear then push" button. They will import the ManyPack and clear the mods directory then import the ManyPack respectively.

### How to build
Create a Windows Forms Project with the .NET Framework (tested for 4.5). Install `JSON.NET` via `nuget`, before adding a reference to `System.IO.Compression.FileSystem` and `System.IO.Compression`. Replace your `Form1.cs` and `Form1.Designer.cs` with the ones in the project.
