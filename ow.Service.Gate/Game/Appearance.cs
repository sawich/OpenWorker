﻿using ow.Framework.Database.Characters;
using ow.Framework.Game;

namespace ow.Service.Gate.Game
{
    public sealed class Appearance : ICharacterAppearance
    {
        ICharacterHair ICharacterAppearance.Hair => Hair;
        ICharacterHair ICharacterAppearance.EquippedHair => Hair;

        public Hair Hair { get; init; }
        public ushort EyeColor { get; init; }
        public ushort SkinColor { get; init; }
        public Hair EquippedHair { get; init; }
        public ushort EquippedEyeColor { get; init; }
        public ushort EquippedSkinColor { get; init; }

        public Appearance(ApperanceModel model)
        {
            Hair = new Hair(model.Hair);
            EyeColor = model.EyeColor;
            SkinColor = model.SkinColor;
            EquippedHair = new Hair(model.EquippedHair);
            EquippedEyeColor = model.EquippedEyeColor;
            EquippedSkinColor = model.EquippedSkinColor;
        }
    }
}