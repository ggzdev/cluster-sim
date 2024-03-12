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


namespace cluster_sim.data {
    public static class cluster_sim_data {

        public static string application_title = "cluster-sim";
        
        public static int version_major = 0;
        public static int version_minor = 0;
        public static int version_micro = 1;
        public static string version_flag = "-pre-alpha";
        public static string application_version = $"v{version_major}.{version_minor}.{version_micro}{version_flag}";
        
        public static string application_copyright = "Copyright (c) 2024 Kian Schmalzl. All rights reserved.";
    }
}