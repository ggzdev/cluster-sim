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

using cluster_sim.data;


namespace cluster_sim.launcher {
    public static class StartupMessageHandler {
        public static void show_message() {
            Console.WriteLine($"cluster-sim {cluster_sim_data.application_version} <sfml>");
            Console.WriteLine(cluster_sim_data.application_copyright);
        }
    }
}