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

using cluster_sim.graphics;


namespace cluster_sim.launcher {
    public static class ThreadManager {
        public static void init_threads() {
            Thread imgui = new Thread(() => imgui_proc_handler.init());
            Thread sfml = new Thread(() => sfml_proc_handler.init());

            imgui.Start();
            sfml.Start();
        }
    }
}