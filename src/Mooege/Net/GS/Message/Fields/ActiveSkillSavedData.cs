﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mooege.Net.GS.Message.Fields
{
    public class ActiveSkillSavedData
    {
        public int snoSkill;
        public int snoRune;

        public void Parse(GameBitBuffer buffer)
        {
            snoSkill = buffer.ReadInt(32);
            snoRune = buffer.ReadInt(3) + (-1);
        }

        public void Encode(GameBitBuffer buffer)
        {
            buffer.WriteInt(32, snoSkill);
            buffer.WriteInt(3, snoRune - (-1));
        }

        public void AsText(StringBuilder b, int pad)
        {
        }
    }
}
