# Vaporbook.UnityTools

A public location to store my Unity tools, assets, and script libraries

I currently import this into Unity via the github package url. In your `<project-dir>/Packages/manifest.json` file you can add the line `"vaporbook.unity-tools": "git@github.com:Vaporbook/public-unity-dev-library.git"` to your dependencies.

Example of using the library to spawn a centered terrain:

```C#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vaporbook.UnityTools;

public class Game : MonoBehaviour
{

    void Start() => CenteredTerrain.spawn();

    void Update()
    {
        
    }
}
```