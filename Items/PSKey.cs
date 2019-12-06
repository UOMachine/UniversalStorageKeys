using Server.Engines.VeteranRewards;
using Solaris.ItemStore;							//for connection to resource store data objects
using System;
using System.Collections.Generic;

namespace Server.Items
{
    //item inherited from BaseResourceKey
    [Flipable(0x9A95, 0x9AA7)]
    public class PSKey : BaseStoreKey, IRewardItem
    {
        private bool m_IsRewardItem;

        [CommandProperty(AccessLevel.Seer)]
        public bool IsRewardItem
        {
            get => m_IsRewardItem;
            set { m_IsRewardItem = value; InvalidateProperties(); }
        }

        public override int DisplayColumns => 1;

        public override List<StoreEntry> EntryStructure
        {
            get
            {
                List<StoreEntry> entry = base.EntryStructure;

                string[] skillnames = Enum.GetNames(typeof(SkillName));

                entry.Add(new ListEntry(typeof(PowerScroll), typeof(PowerScrollListEntry), "Power Scrolls"));
                entry.Add(new ListEntry(typeof(StatCapScroll), typeof(StatCapScrollListEntry), "Stat Scrolls"));

                return entry;
            }
        }

        [Constructable]
        public PSKey() : base(0x0)      // hue 1153
        {
            ItemID = 0x9AA7;
            Name = "Ultimate Power Scroll Book";
        }

        //this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
        protected override ItemStore GenerateItemStore()
        {
            //load the basic store info
            ItemStore store = base.GenerateItemStore();

            //properties of this storage device
            store.Label = "PS Storage";

            store.Dynamic = false;
            store.OfferDeeds = false;
            return store;
        }

        //serial constructor
        public PSKey(Serial serial) : base(serial)
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
