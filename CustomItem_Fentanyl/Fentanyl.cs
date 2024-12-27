using System;
using Exiled.API.Features.Spawn;
using Exiled.CustomItems.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Enums;
using PlayerRoles;

namespace CustomItem_Fentanyl
{
    public class Fentanyl_1 : CustomItem
    {
        public override string Name { get; set; } = "Фентанил 1-го класса";

        public override string Description { get; set; } = "Эксперементальный препарат, дающий прирост в скорости.";

        public override float Weight { get; set; } = 0f;

        public override uint Id { get; set; } = 1;

        public override ItemType Type { get; set; } = ItemType.Adrenaline;

        public override SpawnProperties SpawnProperties { get; set; }

        private readonly Random random = new Random();

        public Config Config = Plugin.Instance.Config;

        protected override void SubscribeEvents()
        {
            base.SubscribeEvents();
            Exiled.Events.Handlers.Player.UsedItem += ItemUsed;
        }

        protected override void UnsubscribeEvents()
        {
            base.UnsubscribeEvents();
            Exiled.Events.Handlers.Player.UsedItem -= ItemUsed;
        }

        public void ItemUsed(UsedItemEventArgs ev)
        {
            if (!Check(ev.Item)) return;
           
            if (random.Next(0, 100) > Config.ZombieChance_1)
            {
                ev.Player.EnableEffect(EffectType.MovementBoost);
                ev.Player.ChangeEffectIntensity(EffectType.MovementBoost, Config.EffectDensity_1, Config.EffectDuration_1);
                ev.Player.Broadcast(5, "Вы получили небольшой прирост скорости");
                return;
            }

            ev.Player.Role.Set(RoleTypeId.Scp0492);
            ev.Player.Broadcast(5, "Препарат превратил вас в 049-2");
        }
    }

    public class Fentanyl_2 : CustomItem
    {
        public override string Name { get; set; } = "Фентанил 2-го класса";

        public override string Description { get; set; } = "Эксперементальный препарат, дающий прирост в скорости.";

        public override float Weight { get; set; } = 0f;

        public override uint Id { get; set; } = 2;

        public override ItemType Type { get; set; } = ItemType.Adrenaline;

        public override SpawnProperties SpawnProperties { get; set; }

        private readonly Random random = new Random();

        public Config Config = Plugin.Instance.Config;

        protected override void SubscribeEvents()
        {
            base.SubscribeEvents();
            Exiled.Events.Handlers.Player.UsedItem += ItemUsed;
        }

        protected override void UnsubscribeEvents()
        {
            base.UnsubscribeEvents();
            Exiled.Events.Handlers.Player.UsedItem -= ItemUsed;
        }

        public void ItemUsed(UsedItemEventArgs ev)
        {
            if (!Check(ev.Item)) return;

            if (random.Next(0, 100) > Config.ZombieChance_2)
            {
                ev.Player.EnableEffect(EffectType.MovementBoost);
                ev.Player.ChangeEffectIntensity(EffectType.MovementBoost, Config.EffectDensity_2, Config.EffectDuration_2);
                ev.Player.Broadcast(5, "Вы получили средний прирост скорости");
                return;
            }

            ev.Player.Role.Set(RoleTypeId.Scp0492);
            ev.Player.Broadcast(5, "Препарат превратил вас в 049-2");
        }
    }

    public class Fentanyl_3 : CustomItem
    {
        public override string Name { get; set; } = "Фентанил 3-го класса";

        public override string Description { get; set; } = "Эксперементальный препарат, дающий прирост в скорости.";

        public override float Weight { get; set; } = 0f;

        public override uint Id { get; set; } = 3;

        public override ItemType Type { get; set; } = ItemType.Adrenaline;

        public override SpawnProperties SpawnProperties { get; set; }

        private readonly Random random = new Random();

        public Config Config = Plugin.Instance.Config;

        protected override void SubscribeEvents()
        {
            base.SubscribeEvents();
            Exiled.Events.Handlers.Player.UsedItem += ItemUsed;
        }

        protected override void UnsubscribeEvents()
        {
            base.UnsubscribeEvents();
            Exiled.Events.Handlers.Player.UsedItem -= ItemUsed;
        }

        public void ItemUsed(UsedItemEventArgs ev)
        {
            if (!Check(ev.Item)) return;

            if (random.Next(0, 100) > Config.ZombieChance_3)
            {
                ev.Player.EnableEffect(EffectType.MovementBoost);
                ev.Player.ChangeEffectIntensity(EffectType.MovementBoost, Config.EffectDensity_3, Config.EffectDuration_3);
                ev.Player.Broadcast(5, "Вы получили большой прирост скорости!");
                return;
            }

            ev.Player.Role.Set(RoleTypeId.Scp0492);
            ev.Player.Broadcast(5, "Препарат превратил вас в 049-2");
        }
    }
}
