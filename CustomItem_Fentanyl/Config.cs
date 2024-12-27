using Exiled.API.Interfaces;



namespace CustomItem_Fentanyl
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;

        public int ZombieChance_1 { get; set; } = 55;
        public int ZombieChance_2 { get; set; } = 35;
        public int ZombieChance_3 { get; set; } = 10;

        public float EffectDuration_1 { get; set; } = 300f;
        public float EffectDuration_2 { get; set; } = 300f;
        public float EffectDuration_3 { get; set; } = 300f;

        public byte EffectDensity_1 { get; set; } = 10;
        public byte EffectDensity_2 { get; set; } = 20;
        public byte EffectDensity_3 { get; set; } = 30;
    }
}