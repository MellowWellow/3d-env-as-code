## Proof of Concept:  3D Environment-as-Code

The goal of this project was to create simple YAML files that declaratively described a desired 3D Environment.  The idea is that non-programmers would be able to generate a 3D environment simply by writing a simple YAML file.  Cloud Infrastructure-as-Code has transformed Cloud-based Infrastructure with countless benefits.  I wanted to explore the idea of transferring these benefits to 3D Scenes.  

The screenshot below shows the completed PoC.  The Program takes simple YAML files as input and outputs a 3D environment.  More specifically, the YAML files outline individual objects.  These YAML-Objects are converted to C#-Objects and those C#-Objects are then used to create Unity Objects within a static Unity scene.  

After completing this PoC, my conclusion is that a complete implementation of this project is not valuable.  Unity's built in features already have the benefits I would hope to obtain from a "3D Environment-as-Code" project.  (One Example: Terraform allows for exporting modules for repeated use within the same project or for use in other projects.  These Terraform Modules can allow for many copies of similar resources with declared differences with minimal lines of code.  In Unity, I can CTRL+C CTRL+V an object and make quick updates easily.) 

![YAML File to Unity Scene](https://github.com/MellowWellow/3d-env-as-code/blob/main/screenshot/example.png?raw=true)
