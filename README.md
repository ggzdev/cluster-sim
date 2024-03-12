# cluster-sim

## Overview
cluster-sim is an open-source graphical simulator that simulates the instrument clusters of vehicles. The instrument cluster is rendered using sfml and controlled using an imgui debugging menu. This software has no useful purpose other than to look cool. If you are as fascinated by instrument clusters as I am, then this software is for you. cluster sim can also be used to animate instrument clusters in movies or give you some inspiration for your next project.

## Customization options
cluster-sim also allows you to heavily modify the default cluster or even create a completly new one from scratch so you can build your dream instrument cluster setup. In cluster-sim, you can create (nearly) every type of cluster using the pre-made assets. You can position them, rotate them, resize them, change colors and much more.

### How do i customize?
In order to customize cluster-sim, you'll first need to understand, how it works. The pre-compiled release version only comes with one cluster that cannot be changed. If you want to modify and customize cluster-sim, you can do so by making simple changes to the source code. And don't worry, it's easier than you think. After that you will need to compile the entire project though, but this process is also easier than expected and basically everyone can do it. You can read more about customization in the cluster-sim documentation or later in the readme file.


## Installation
You have a couple of options to choose from. You can either go with the easier to install but uncustomizable option: The pre-compiled software and install it using an installer or just using the portable version or you can go for the customizable, not pre-built version by downloading (and modifying) the source code.

### Pre-Built Option
On the release tab, you will find installer and portable (.zip folders) versions for both `win-x64` and `win-x86`. When using the portable version, you can just download the needed zip-folder and extract it into any directory. then search for `cluster-sim.exe` and run it. When using an installer, you can just download the installer and then install it to your system by following the installer instructions. A desktop shortcut will be created in order to simply launch the application.

### Compiling from source
First, install the `.NET SDK 8.0` or later. Also make sure `git` is installed on your machine, so you have access the the `git clone` command.
1. Open your terminal in any directory and clone the directory.
```
git clone https://github.com/ggzdev/cluster-sim.git
```
2. Build the project for the first time using the internal make system.
```
make
```

3. You can run the software by opening the `cluster-sim.exe` file in the `.\out\win-x64` or `.\out\win-x86` folder.

**NOTE:** If you want to modify the source code or customize the instrument cluster, you will have to rebuild the entire project using `make` in order for the changes to apply.