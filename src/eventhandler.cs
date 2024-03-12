// cluster-sim -- an open-source, highly customizable instrument cluster simulator
// Copyright (c) 2024 Kian Schmalzl. All rights reserved. Licensed under MIT-License
// https://www.github.com/ggzdev/cluster-sim

using System;
using System.Collections;
using System.Collections.Generic;

using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Numerics;

using ImGuiNET;
using ClickableTransparentOverlay;

using SFML.Audio;
using SFML.Graphics;
using SFML.System;
using SFML.Window;

using cluster_sim.misc;
using cluster_sim.data;


namespace cluster_sim.graphics {
    public static class EventHandler {
        public static void recieve(RenderWindow display) {
            display.DispatchEvents();

            if(InputHandler.recieveKey(0x1B)) {
                Cache.sfml_windowOpen = false;
                Environment.Exit(0);
            }
        }
    }
}