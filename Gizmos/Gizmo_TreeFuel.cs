// Decompiled with JetBrains decompiler
// Type: HediffsAbilities.Gizmos.Gizmo_TreeFuel
// Assembly: HediffsAbilities, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A24FD7BF-E4B7-40C4-8848-97E48E1CC6B6
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\RimWorld\Mods\SovereignNarutoMod\Assemblies\HediffsAbilities.dll

using HediffsAbilities.Things;
using System;
using UnityEngine;
using Verse;

namespace HediffsAbilities.Gizmos
{
  [StaticConstructorOnStartup]
  public class Gizmo_TreeFuel : Gizmo
  {
    private static readonly Texture2D FullShieldBarTex = SolidColorMaterials.NewSolidColorTexture(new Color(0.2f, 0.2f, 0.24f));
    private static readonly Texture2D EmptyShieldBarTex = SolidColorMaterials.NewSolidColorTexture(Color.clear);
    public Building_FruitTree tree;

    public Gizmo_TreeFuel() => this.order = -90f;

    public virtual float GetWidth(float maxWidth) => 140f;

    public virtual GizmoResult GizmoOnGUI(
      Vector2 topLeft,
      float maxWidth,
      GizmoRenderParms parms)
    {
      Rect rect1;
      // ISSUE: explicit constructor call
      ((Rect) ref rect1).\u002Ector(topLeft.x, topLeft.y, base.GetWidth(maxWidth), 75f);
      Rect rect2 = GenUI.ContractedBy(rect1, 6f);
      Widgets.DrawWindowBackground(rect1);
      Rect rect3 = rect2;
      ((Rect) ref rect3).height = ((Rect) ref rect1).height / 2f;
      Text.Font = (GameFont) 0;
      Text.Anchor = (TextAnchor) 4;
      Widgets.Label(rect3, Translator.Translate("HediffsAbilities.GUI.TreeFuel"));
      Rect rect4 = rect2;
      ((Rect) ref rect4).yMin = ((Rect) ref rect2).y + ((Rect) ref rect2).height / 2f;
      float num1 = this.tree.Fuel / this.tree.FuelMax;
      Widgets.FillableBar(rect4, num1, Gizmo_TreeFuel.FullShieldBarTex, Gizmo_TreeFuel.EmptyShieldBarTex, false);
      Text.Font = (GameFont) 1;
      Rect rect5 = rect4;
      float num2 = this.tree.Fuel;
      string str1 = num2.ToString("F0");
      num2 = this.tree.FuelMax;
      string str2 = num2.ToString("F0");
      string str3 = str1 + " / " + str2;
      Widgets.Label(rect5, str3);
      Text.Anchor = (TextAnchor) 0;
      if (Mouse.IsOver(rect4))
      {
        string str4 = TaggedString.op_Implicit(TranslatorFormattedStringExtensions.Translate("HediffsAbilities.GUI.TreeFuelPerDay", NamedArgument.op_Implicit(Math.Round((double) this.tree.FuelPerDay, 2))));
        TooltipHandler.TipRegion(rect4, TipSignal.op_Implicit(str4));
      }
      return new GizmoResult((GizmoState) 0);
    }
  }
}
