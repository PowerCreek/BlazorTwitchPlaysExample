using System;

namespace TBRPG_1.Game.Lib
{
    public interface IIdentity
    {
        public string UUID { get; set; }

        public static string CreateUUID => Guid.NewGuid().ToString();

    }
}