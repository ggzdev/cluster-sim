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


namespace cluster_sim.graphics {
    public static class Graphics {
        public static void draw_line(Vector2f point1, Vector2f point2, Color col, RenderWindow display) {
            VertexArray line = new VertexArray(PrimitiveType.Lines, 2);
            line[0] = new Vertex(point1, col);
            line[1] = new Vertex(point2, col);
            display.Draw(line);
        }
    }
}