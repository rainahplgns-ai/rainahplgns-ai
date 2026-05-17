using System;

namespace final_project
{
    public static class profileData
    {
        // Tinanggal ang '= "Player 1"' at '= ""' dito para hindi mag-error ang lumang compiler
        public static string PlayerName { get; set; }
        public static string AvatarPath { get; set; }

        // GUMAGAWA NG STATIC CONSTRUCTOR:
        // Dito natin ligtas na itatalaga ang mga default values na babasahin ng compiler
        static profileData()
        {
            PlayerName = "Player 1";
            AvatarPath = "";
        }
    }
}
