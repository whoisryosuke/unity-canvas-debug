# Canvas Debug for Unity

Ultra simple in-game debug window for Unity.

> Need a more fully featured debug plugin? Check out [In-Game Debug Console for Unity 3D](https://github.com/yasirkula/UnityIngameDebugConsole) by @yasirkula.

## Getting Started

1. Download this plugin (.zip) or clone it to computer.
2. Copy the "Plugins" folder to your project.
3. Add the **Debug UI prefab** to your scene.
4. In your script where you need logging, add the following line:

```
CanvasDebug.Log("Test");
```

# How does it work?

The Debug UI prefab is a full-screen canvas with a scroll view inside. When you run the static/global `CanvasDebug.Log()` method, it finds that prefab in your scene and puts a new Text item at the top (using LogItem prefab).

## Customize text

You can change the font size, color, etc using the **LogItem prefab.**

# References

- [In-Game Debug Console for Unity 3D](https://assetstore.unity.com/packages/tools/gui/in-game-debug-console-68068)
