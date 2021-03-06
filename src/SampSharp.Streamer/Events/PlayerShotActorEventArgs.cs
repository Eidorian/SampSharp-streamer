﻿// SampSharp.Streamer
// Copyright 2018 Tim Potze
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using SampSharp.GameMode.Definitions;
using SampSharp.GameMode.Events;
using SampSharp.GameMode.World;

namespace SampSharp.Streamer.Events
{
    public class PlayerShotActorEventArgs : PlayerEventArgs
    {
        public PlayerShotActorEventArgs(BasePlayer player, Weapon weapon, float amount, BodyPart bodyPart)
            : base(player)
        {
            Weapon = weapon;
            Amount = amount;
            BodyPart = bodyPart;
        }

        public Weapon Weapon { get; }

        public float Amount { get; }

        public BodyPart BodyPart { get; }
    }
}