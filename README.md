# Drew's Unity Convention Guide
Anyone interacting with Unity please follow the below conventions
## Coding Style
1. Write succinct, helpful comments
    - Comment blocks of code where it may not be immediately apparent what is happening
    - Use annotations such as `//TODO: remove placeholder text` if you're going to commit something that is incomplete
    - Preferably write code that is understandable without comments
2. Use C# style guidelines
3. Use OOP guidelines 
    - Don't put all of your code in one method
    - Attach code to the right GameObjects
    - Split code up into different scripts based on functionality when applicable
## Git Guidelines
1. Fork the repo. Repo found at https://github.com/DrewCCannedy/wranglers
2. Work on feature branches
    - Create a new branch for each feature you work on
    - Create a pull request when you are ready to merge your changes with the master branch
3. If you need assistance, I will run through each step with you. You'll get a major headache if you don't know what you're doing
## Unity Guidelines 
1. Use Version 2019.3.x
2. Do not change the scene unless you explicitly ask me if you can
3. Use prefabs for everything
    - Put your object in the scene exactly how you want it
    - Save it as a prefab
    - Remove it from the scene
    - You can make parent objects prefabs too
    - Tell me you added the prefab and I will place it into the scene
4. Folders are based around objects if possible
    - As an example, a Sheriff Object folder named sheriff
    - In the sheriff folder is everything related to the sheriff object
    - His prefab, texture, scripts, sounds, etc...
    - If there is a space in the name of something, use a dash ie: sheriff-butt-texture
