// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.GUI.Window_MapTeleport
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Verse;

namespace HediffsAbilities.GUI
{
<<<<<<< HEAD
    public class Window_MapTeleport : Window
    {
        private Vector2 scrollPosition = Vector2.zero;
        private Pawn pawn;

        public virtual Vector2 InitialSize => new Vector2(600f, 400f);

        private List<Map> maps => ((IEnumerable<Map>)Find.Maps).Where(x => x != pawn.Map).ToList();

        public Window_MapTeleport(Pawn pawn)
        {
            draggable = false;
            resizeable = false;
            forcePause = true;
            doCloseX = true;
            this.pawn = pawn;
        }

        public virtual void DoWindowContents(Rect inRect)
        {
            Rect rect1;
            // ISSUE: explicit constructor call
            rect1 = new Rect(10f, 10f, base.InitialSize.x - 60f, 30f);
            Text.Anchor = (TextAnchor)4;
            Text.Font = (GameFont)2;
            Widgets.Label(rect1, Translator.Translate("HediffsAbilities.GUI.MapsList"));
            Text.Font = (GameFont)1;
            if (GenList.NullOrEmpty(maps))
                Widgets.Label(new Rect(rect1.x, rect1.y + rect1.height, rect1.width, 60f), Translator.Translate("HediffsAbilities.GUI.NullMapsList"));
            Text.Anchor = 0;
            Rect rect2;
            // ISSUE: explicit constructor call
            rect2 = new Rect(30f, 70f, base.InitialSize.x - 70f, 240f);
            Rect rect3;
            // ISSUE: explicit constructor call
            rect3 = new Rect(0.0f, 0.0f, rect2.x, maps.Count * 30);
            Widgets.BeginScrollView(rect2, ref scrollPosition, rect3, true);
            int num1 = 0;
            float num2 = rect2.width - 20f;
            foreach (Map map in maps)
            {
                if (Widgets.ButtonText(new Rect(0.0f, (float)(num1 * 30), num2, 30f), TaggedString.op_Implicit(TaggedString.op_Addition(((Def)map.TileInfo.biome).LabelCap, string.Format(", {0}: ", (object)Translator.Translate("HediffsAbilities.GUI.TileId")))) + map.Tile.ToString(), true, true, true))
                {
                    IntVec3 pos;
                    if (TryFindShipChunkDropCell(map.Center, map, map.Size.x / 2, out pos))
                    {
                        pawn.DeSpawn(0);
                        GenSpawn.Spawn(pawn, pos, map, 0);
                        pawn.Notify_Teleported(true, true);
                        Close(true);
                    }
                    else
                        Messages.Message(TaggedString.op_Implicit(Translator.Translate("HediffsAbilities.Messages.TryFindCellFalse")), MessageTypeDefOf.NegativeEvent, true);
                }
                ++num1;
            }
            Widgets.EndScrollView();
        }

        private bool TryFindShipChunkDropCell(IntVec3 nearLoc, Map map, int maxDist, out IntVec3 pos) => CellFinderLoose.TryFindSkyfallerCell(ThingDefOf.ShipChunkIncoming, map, ref pos, 10, nearLoc, maxDist, true, false, false, false, true, false, (Predicate<IntVec3>)null);
    }
=======
  public class Window_MapTeleport : Window
  {
    private Vector2 scrollPosition = Vector2.zero;
    private Pawn pawn;

    public virtual Vector2 InitialSize => new Vector2(600f, 400f);

    private List<Map> maps => ((IEnumerable<Map>) Find.Maps).Where<Map>((Func<Map, bool>) (x => x != ((Thing) this.pawn).Map)).ToList<Map>();

    public Window_MapTeleport(Pawn pawn)
    {
      this.draggable = false;
      this.resizeable = false;
      this.forcePause = true;
      this.doCloseX = true;
      this.pawn = pawn;
    }

    public virtual void DoWindowContents(Rect inRect)
    {
      Rect rect1;
      // ISSUE: explicit constructor call
      ((Rect) ref rect1).\u002Ector(10f, 10f, base.InitialSize.x - 60f, 30f);
      Text.Anchor = (TextAnchor) 4;
      Text.Font = (GameFont) 2;
      Widgets.Label(rect1, Translator.Translate("HediffsAbilities.GUI.MapsList"));
      Text.Font = (GameFont) 1;
      if (GenList.NullOrEmpty<Map>((IList<Map>) this.maps))
        Widgets.Label(new Rect(((Rect) ref rect1).x, ((Rect) ref rect1).y + ((Rect) ref rect1).height, ((Rect) ref rect1).width, 60f), Translator.Translate("HediffsAbilities.GUI.NullMapsList"));
      Text.Anchor = (TextAnchor) 0;
      Rect rect2;
      // ISSUE: explicit constructor call
      ((Rect) ref rect2).\u002Ector(30f, 70f, base.InitialSize.x - 70f, 240f);
      Rect rect3;
      // ISSUE: explicit constructor call
      ((Rect) ref rect3).\u002Ector(0.0f, 0.0f, ((Rect) ref rect2).x, (float) (this.maps.Count * 30));
      Widgets.BeginScrollView(rect2, ref this.scrollPosition, rect3, true);
      int num1 = 0;
      float num2 = ((Rect) ref rect2).width - 20f;
      foreach (Map map in this.maps)
      {
        if (Widgets.ButtonText(new Rect(0.0f, (float) (num1 * 30), num2, 30f), TaggedString.op_Implicit(TaggedString.op_Addition(((Def) map.TileInfo.biome).LabelCap, string.Format(", {0}: ", (object) Translator.Translate("HediffsAbilities.GUI.TileId")))) + map.Tile.ToString(), true, true, true))
        {
          IntVec3 pos;
          if (this.TryFindShipChunkDropCell(map.Center, map, map.Size.x / 2, out pos))
          {
            ((Entity) this.pawn).DeSpawn((DestroyMode) 0);
            GenSpawn.Spawn((Thing) this.pawn, pos, map, (WipeMode) 0);
            this.pawn.Notify_Teleported(true, true);
            this.Close(true);
          }
          else
            Messages.Message(TaggedString.op_Implicit(Translator.Translate("HediffsAbilities.Messages.TryFindCellFalse")), MessageTypeDefOf.NegativeEvent, true);
        }
        ++num1;
      }
      Widgets.EndScrollView();
    }

    private bool TryFindShipChunkDropCell(IntVec3 nearLoc, Map map, int maxDist, out IntVec3 pos) => CellFinderLoose.TryFindSkyfallerCell(ThingDefOf.ShipChunkIncoming, map, ref pos, 10, nearLoc, maxDist, true, false, false, false, true, false, (Predicate<IntVec3>) null);
  }
>>>>>>> e92050d7e21e101c22fa4209e396d0084c1c39e2
}
