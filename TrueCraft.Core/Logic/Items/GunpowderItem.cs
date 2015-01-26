using System;
using TrueCraft.API.Logic;

namespace TrueCraft.Core.Logic.Items
{
    public class GunpowderItem : ItemProvider
    {
        public static readonly short ItemID = 0x121;

        public override short ID { get { return 0x121; } }

        public override string DisplayName { get { return "Gunpowder"; } }
    }
}