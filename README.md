# /vg/station 13.5

<p align="center"><img src="https://raw.githubusercontent.com/vgstation-coders/vgstation13.5/master/Resources/Textures/Logo/splashlogo.png" width="512px" /></p>

---

/vg/station13.5 is a fork of [Einstein Engines]([https://github.com/space-wizards/space-station-14](https://github.com/Simple-Station/Einstein-Engines)) with a large number of modifications made for parity with our BYOND codebase.

Space Station 14 is inspired heavily by Space Station 13 and runs on [Robust Toolbox](https://github.com/space-wizards/RobustToolbox), a homegrown engine written in C#.

## Links

[Website](https://ss13.moe) | [Steam(SSMV Launcher)](https://store.steampowered.com/app/2585480/Space_Station_Multiverse/) | [Steam(WizDen Launcher)](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Standalone](https://spacestationmultiverse.com/downloads/)

Discord: https://discord.com/invite/RYnQZvxrm + H (Add the H to the end, this is to deter github spambots)

## Contributing

We are happy to accept contributions. We recommend joining the discord: people in the #ss14-coder-chat will be more than happy to help you get started.

## Building

Refer to [the Space Wizards' guide](https://docs.spacestation14.com/en/general-development/setup/setting-up-a-development-environment.html) on setting up a development environment for general information, but keep in mind that Einstein Engine-based servers are not the exact same and many things may not apply.
We provide some scripts shown below to make the job easier.

### Build dependencies

> - Git
> - .NET SDK 9.0.101

### Windows

> 1. Clone this repository
> 2. Run `git submodule update --init --recursive` in a terminal to download the engine
> 3. Run `Scripts/bat/buildAllDebug.bat` after making any changes to the source
> 4. Run `Scripts/bat/runQuickAll.bat` to launch the client and the server
> 5. Connect to localhost in the client and play

### Linux

> 1. Clone this repository
> 2. Run `git submodule update --init --recursive` in a terminal to download the engine
> 3. Run `Scripts/sh/buildAllDebug.sh` after making any changes to the source
> 4. Run `Scripts/sh/runQuickAll.sh` to launch the client and the server
> 5. Connect to localhost in the client and play

### MacOS

> I don't know anybody using MacOS to test this, but it's probably roughly the same steps as Linux

## License

Please read the [LEGAL.md](./LEGAL.md) file for information on the licenses of the code and assets in this repository.
