using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Exiled.Events;
using Exiled.Events.Features;
using MEC;
using Exiled.CustomItems.API.Features;
using Exiled.CustomItems.API;

namespace CustomItem_Fentanyl
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "sky3z";

        public override string Name => "CustomItem_Fentanyl";

        public override string Prefix => "CustomItem_Fentanyl";

        public override Version Version => base.Version;

        public static Plugin Instance;

        private Fentanyl_1 fentanyl_1;
        private Fentanyl_2 fentanyl_2;
        private Fentanyl_3 fentanyl_3;

        public override void OnEnabled()
        {
            base.OnEnabled();
            Instance = this;

            fentanyl_1 = new Fentanyl_1();
            fentanyl_1.Register();

            fentanyl_2 = new Fentanyl_2();
            fentanyl_2.Register();

            fentanyl_3 = new Fentanyl_3();
            fentanyl_3.Register();
        }


        public override void OnDisabled()
        {
            base.OnDisabled();
            Instance = null;

            fentanyl_1.Unregister();

            fentanyl_2.Unregister();

            fentanyl_3.Unregister();
        }

    }
}
