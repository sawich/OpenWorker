﻿using ow.Framework.Game.Datas.Bin.Table.Entities;
using ow.Framework.IO.Network;
using ow.Framework.IO.Network.Opcodes;
using ow.Service.Gate.Game;
using ow.Service.Gate.Game.Enums;
using System;
using System.Linq;

namespace ow.Service.Gate.Network.Extensions
{
    public static class GameSessionExtension
    {
        internal static GameSession SendGateEnterResult(this GameSession session)
        {
            using PacketWriter writer = new(ClientOpcode.GateEnter);

            writer.Write(GateEnterResult.Success);

            Account account = session.Entity.Get<Account>();
            writer.Write(account.Id);

            return session.SendAsync(writer);
        }

        internal static GameSession SendFavoriteCharacter(this GameSession session)
        {
            using PacketWriter writer = new(ClientOpcode.CharacterMakrAsFavorite);

            Account account = session.Entity.Get<Account>();
            writer.Write(account.Id);

            Characters characters = session.Entity.Get<Characters>();
            writer.Write(characters.Favorite.Entity.Id);
            writer.Write(ushort.MinValue);
            writer.WriteByteLengthUnicodeString(characters.Favorite.Entity.Name);
            writer.Write(characters.Favorite.Entity.Photo.Id);
            writer.Write(uint.MinValue);
            writer.Write(uint.MinValue);
            writer.Write(uint.MinValue);

            return session.SendAsync(writer);
        }

        internal static GameSession SendCharactersList(this GameSession session)
        {
            using PacketWriter writer = new(ClientOpcode.CharactersList);

            Characters characters = session.Entity.Get<Characters>();
            Character[] existsCharacters = characters.Where(c => c is not null).ToArray();

            writer.Write((byte)existsCharacters.Length);

            foreach (Character character in existsCharacters)
                writer.Write(character.Entity, character.Storage);

            writer.Write(characters.LastSelected is null ? (existsCharacters.FirstOrDefault()?.Entity.Id ?? -1) : (characters.LastSelected?.Entity.Id ?? -1));
            writer.Write(byte.MinValue);
            writer.Write((byte)1);
            writer.Write((ulong)characters.InitializeTime.TotalSeconds);
            writer.Write(uint.MinValue);
            writer.Write((ulong)1262271600); // dec/31/2009
            writer.Write((byte)17);
            writer.Write(byte.MinValue);
            writer.Write(byte.MinValue);
            writer.Write(byte.MinValue);

            return session.SendAsync(writer);
        }

        internal static GameSession SendCharacterBackground(this GameSession session, CharacterBackgroundTableEntity entity)
        {
            using PacketWriter writer = new(ClientOpcode.CharacterChangeBackground);

            Account account = session.Entity.Get<Account>();
            writer.Write(account.Id);

            writer.Write(entity.Id);
            writer.Write(uint.MinValue);

            return session.SendAsync(writer);
        }

        internal static GameSession SendCharacterSelect(this GameSession session, Character character, DistrictInstance district)
        {
            using PacketWriter writer = new(ClientOpcode.CharacterSelect);

            writer.Write(character.Entity.Id);

            Account account = session.Entity.Get<Account>();
            writer.Write(account.Id);

            writer.Write(new byte[28]);
            writer.WriteNumberLengthUtf8String(district.Ip);
            writer.Write(district.Port);

            Place place = session.Entity.Get<Place>();
            writer.Write(place);

            writer.Write(new byte[12]);

            return session.SendAsync(writer);
        }

        internal static GameSession SendCurrentDate(this GameSession session)
        {
            using PacketWriter writer = new(ClientOpcode.CurrentDate);

            DateTimeOffset dateTime = DateTimeOffset.Now;

            writer.Write(dateTime.ToUnixTimeSeconds());
            writer.Write((ushort)dateTime.Year);
            writer.Write((ushort)dateTime.Month);
            writer.Write((ushort)dateTime.Day);
            writer.Write((ushort)dateTime.Hour);
            writer.Write((ushort)dateTime.Minute);
            writer.Write((ushort)dateTime.Second);
            writer.Write(Convert.ToUInt16(TimeZoneInfo.Local.IsDaylightSavingTime(dateTime)));

            return session.SendAsync(writer);
        }
    }
}