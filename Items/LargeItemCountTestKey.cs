using Server.Engines.VeteranRewards;
using Solaris.ItemStore;							//for connection to resource store data objects
using System.Collections.Generic;

namespace Server.Items
{
    //item derived from BaseResourceKey
    public class LargeItemCountTestKey : BaseStoreKey, IRewardItem
    {
        private bool m_IsRewardItem;

        [CommandProperty(AccessLevel.Seer)]
        public bool IsRewardItem
        {
            get => m_IsRewardItem;
            set { m_IsRewardItem = value; InvalidateProperties(); }
        }

        //set the # of columns of entries to display on the gump.. default is 2
        public override int DisplayColumns => 3;

        public override List<StoreEntry> EntryStructure
        {
            get
            {
                List<StoreEntry> entry = base.EntryStructure;

                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst", 0, 25, -11, 9));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine", 0, 25, -13, 9));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond", 0, 25, -5, 9));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby", 0, 25, 7, 9));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire", 0, 25, 6, 9));
                entry.Add(new ResourceEntry(typeof(StarSapphire), "Star Sapphire", 0, 25, -7, 9));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline", 0, 25, 11, 8));

                return entry;
            }
        }

        [Constructable]
        public LargeItemCountTestKey() : base(0x0)      //hue 1154
        {
            Name = "Large Item Count Test Keys";
        }

        //this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
        protected override ItemStore GenerateItemStore()
        {
            //load the basic store info
            ItemStore store = base.GenerateItemStore();

            //properties of this storage device
            store.Label = "Large Item Count Storage";

            store.Dynamic = false;
            store.OfferDeeds = false;

            return store;
        }

        //serial constructor
        public LargeItemCountTestKey(Serial serial) : base(serial)
        {
        }

        public override void GetProperties(ObjectPropertyList list)
        {
            base.GetProperties(list);

            if (m_IsRewardItem)
            {
                list.Add(1076217); // 1st Year Veteran Reward
            }
        }

        //events

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write(0);

            writer.Write(m_IsRewardItem);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            _ = reader.ReadInt();

            m_IsRewardItem = reader.ReadBool();
        }
    }
}
