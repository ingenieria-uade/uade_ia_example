# IA Training
<img src="RawContent/logo_uade.png" width="64">

## 1. About this project
This is a Unity Game Project example for the "Artifical Intelligence" subject students. 


## 2. C# Code Style Guide
* Use 4 spaces indentation. ✅
* Lines should be no longer than 100 characters long. ✅
* All braces get their own line as it is a C# convention ✅:
```csharp
class MyClass
{
    void DoSomething()
    {
        if (someTest)
        {
          // ...
        }
        else
        {
          // ...
        }
    }
}
```
* Use **camelCase** for parameters and local variables. ✅
* Use **PascalCase** for namespaces, clases, fields, properties and methods. ✅
* Use the prefix "m_" for class fields. ✅
* Use US English spelling. ✅
* Ensure just one **return** per method/function. Use Structured Programming best practices to write your algorithms. ✅

### Example code:
```csharp
using UnityEngine;

namespace ProjectName
{
    public class MyClass
    {
        public static string YES = "yes"; 
        public static uint MaxLives; 

        public uint Lives {get; set;}
        
        public string color = "red";

        [SerializeField]
        private float m_Speed = 5;
        private float m_Timer;


        void Start()
        {
        }

        void Update()
        {
        }

        public bool DoSomething(string myValue)
        {
            bool success = false;
            // ...

            if (myValue == YES)
            {
                success = true;
            }
            else
            {
                // ...
            }

            return success;
        }

        
        private void DoSomethingElse()
        {
            // ...
        }
    }
}
```

## 3. Sources Content Structure
<pre>
|-- <a href="#3.1">RawContent</a>
|-- Documentation
|-- MyGameExample
    |-- Assets
        |-- <a href="#3.2">Graphics</a>
            |-- Animations
            |-- Audio
            |-- Materials
            |-- Models
            |-- Prefabs
            |-- Shaders
            |-- Textures
            |-- UI
        |-- <a href="#3.3">Libs</a>
        |-- Scenes
        |-- Scripts
            |-- <a href="#3.4">UADE</a>
            |-- <a name="#3.5">MyGameExample</a>       
                |-- UI        
                |-- Gameplay 
                    |-- Characters
</pre>

<a name="3.1"></a>
### 3.1 RawContent
Put here any raw asset (e.g. .max, .png, .mp3, etc.).


<a name="3.2"></a>
### 3.2 Graphics
Every game assets must be placed here (e.g. animations, models, textures, sounds, prefabs, etc.).


<a name="3.3"></a>
### 3.3 Libs
Any third party or external libraries should be placed here.

<a name="3.4"></a>
### 3.4 UADE
Game Development Framework (e.g. FSM, Screen Navigator, Path Finding scripts, etc.).

<a name="3.5"></a>
### 3.2 MyGameExample
Base game play, game flow, character controlers, AI and game modes related scripts must be placed here.


## 4. About commits
We suggest the following nomenclature for the descriptions in the commits:
<pre>
[US ##] [Task #] [Bug #] (optional)
+ Addition of one of more assets or new features
- Removal of one of more assets or features 
* Update of sources, refacto or bug fixing

Reviewer: XXXX (optional)
</pre>



Example description:
<pre>
[US 1] [Task 34]
+ Added Settings screen
+ Added windmill assets and textures
- Removed unused chicken assets 
* Updated monster damage values
* Fixed min character head rotation
* Updated game logo

Reviewer: Jorge Miranda
</pre>

## 5. Controls
W,A,S,D: Move

Z: Punch

X: Kick

## Credits
