﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreature
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; set; }
        public int RewardGold { get; set; }
        public List<LootItem> LootItems { get; set; }

        public Monster(int iD, string name, int currentHitPoints, int maximumHitPoints, int maximumDamage, int rewardExperiencePoints, int rewardGold) : base(currentHitPoints, maximumHitPoints)
        {
            ID = iD;
            Name = name;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            RewardGold = rewardGold;
            LootItems = new List<LootItem>();
        }
    }
}
