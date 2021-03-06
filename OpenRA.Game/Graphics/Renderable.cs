#region Copyright & License Information
/*
 * Copyright 2007-2015 The OpenRA Developers (see AUTHORS)
 * This file is part of OpenRA, which is free software. It is made
 * available to you under the terms of the GNU General Public License
 * as published by the Free Software Foundation. For more information,
 * see COPYING.
 */
#endregion

using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace OpenRA.Graphics
{
	public interface IRenderable
	{
		WPos Pos { get; }
		PaletteReference Palette { get; }
		int ZOffset { get; }
		bool IsDecoration { get; }

		IRenderable WithPalette(PaletteReference newPalette);
		IRenderable WithZOffset(int newOffset);
		IRenderable OffsetBy(WVec offset);
		IRenderable AsDecoration();

		IFinalizedRenderable PrepareRender(WorldRenderer wr);
	}

	public interface IFinalizedRenderable
	{
		void Render(WorldRenderer wr);
		void RenderDebugGeometry(WorldRenderer wr);
		Rectangle ScreenBounds(WorldRenderer wr);
	}
}
