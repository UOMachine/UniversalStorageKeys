using System;
using System.Collections;
using System.Collections.Generic;
using Server;
using Solaris.ItemStore;							//for connection to resource store data objects

namespace Server.Items
{
	//item derived from BaseResourceKey
	public class ImbueKey : BaseStoreKey
	{


		public override List<StoreEntry> EntryStructure
		{
			get
			{
				List<StoreEntry> entry = base.EntryStructure;

                entry.Add(new ResourceEntry(typeof(MagicalResidue), "Magical Residue"));
                entry.Add(new ResourceEntry(typeof(EnchantedEssence), "Enchanted Essence"));
                entry.Add(new ResourceEntry(typeof(RelicFragment), "Relic Fragment"));
                entry.Add(new ResourceEntry(typeof(AbyssalCloth), "Abyssal Cloth"));
                entry.Add(new ResourceEntry(typeof(ArcanicRuneStone), "Arcane Rune Stone"));
                entry.Add(new ResourceEntry(typeof(BottleIchor), "Bottle of Ichor"));
                entry.Add(new ResourceEntry(typeof(BouraPelt), "Boura Pelt"));
                entry.Add(new ResourceEntry(typeof(ChagaMushroom), "Chaga Mushroom"));
                entry.Add(new ResourceEntry(typeof(CrushedGlass), "Crushed Glass"));
                entry.Add(new ResourceEntry(typeof(CrystalShards), "Crystal Shards"));
                entry.Add(new ResourceEntry(typeof(CrystallineBlackrock), "Crystalline Blackrock"));
                entry.Add(new ResourceEntry(typeof(DaemonClaw), "Daemon Claw"));
                entry.Add(new ResourceEntry(typeof(DelicateScales), "Delicate Scales"));
                //entry.Add(new ResourceEntry(typeof(ElvenFletchings), "Elven Fletchings"));
                entry.Add(new ResourceEntry(typeof(EssenceAchievement), "Essence Achievement"));
                entry.Add(new ResourceEntry(typeof(EssenceBalance), "Essence Balance"));
                entry.Add(new ResourceEntry(typeof(EssenceControl), "Essence Control"));
                entry.Add(new ResourceEntry(typeof(EssenceDiligence), "Essence Diligence"));
                entry.Add(new ResourceEntry(typeof(EssenceDirection), "Essence Direction"));
                entry.Add(new ResourceEntry(typeof(EssenceFeeling), "Essence Feeling"));
                entry.Add(new ResourceEntry(typeof(EssenceOrder), "Essence Order"));
                entry.Add(new ResourceEntry(typeof(EssencePassion), "Essence Passion"));
                entry.Add(new ResourceEntry(typeof(EssencePersistence), "Essence Persistence"));
                entry.Add(new ResourceEntry(typeof(EssencePrecision), "Essence Precision"));
                entry.Add(new ResourceEntry(typeof(EssenceSingularity), "Essence Singularity"));
                entry.Add(new ResourceEntry(typeof(FaeryDust), "Faery Dust"));
                entry.Add(new ResourceEntry(typeof(GoblinBlood), "Goblin Blood"));
                entry.Add(new ResourceEntry(typeof(LavaSerpentCrust), "Lava Serp. Crust"));
                entry.Add(new ResourceEntry(typeof(LuminescentFungi), "Luminescent Fungi"));
                entry.Add(new ResourceEntry(typeof(ParasiticPlant), "Parasitic Plant"));
                entry.Add(new ResourceEntry(typeof(PowderedIron), "Powdered Iron"));
                entry.Add(new ResourceEntry(typeof(RaptorTeeth), "Raptor Teeth"));
                entry.Add(new ResourceEntry(typeof(ReflectiveWolfEye), "Reflect. Wolf Eye"));
                //entry.Add(new ResourceEntry(typeof(SeedofRenewal), "Seed of Renewal"));
                entry.Add(new ResourceEntry(typeof(SilverSnakeSkin), "Silver Snake Skin"));
                entry.Add(new ResourceEntry(typeof(SlithTongue), "Slith Tongue"));
                entry.Add(new ResourceEntry(typeof(SpiderCarapace), "Spider Carapace"));
                entry.Add(new ResourceEntry(typeof(UndyingFlesh), "Undying Flesh"));
                entry.Add(new ResourceEntry(typeof(VialOfVitriol), "Vial of Vitriol"));
                entry.Add(new ResourceEntry(typeof(VoidOrb), "Void Orb"));                
                entry.Add(new ResourceEntry(typeof(BlueDiamond), "Blue Diamond"));
                entry.Add(new ResourceEntry(typeof(BrilliantAmber), "Brilliant Amber"));
                entry.Add(new ResourceEntry(typeof(FireRuby), "Fire Ruby"));
                entry.Add(new ResourceEntry(typeof(Turquoise), "Turquoise"));
                entry.Add(new ResourceEntry(typeof(WhitePearl), "White Pearl"));
                entry.Add(new ResourceEntry(typeof(Amber), "Amber"));
                entry.Add(new ResourceEntry(typeof(Amethyst), "Amethyst"));
                entry.Add(new ResourceEntry(typeof(Citrine), "Citrine"));
                entry.Add(new ResourceEntry(typeof(Diamond), "Diamond"));
                entry.Add(new ResourceEntry(typeof(Emerald), "Emerald"));
                entry.Add(new ResourceEntry(typeof(Ruby), "Ruby"));
                entry.Add(new ResourceEntry(typeof(Sapphire), "Sapphire"));
                entry.Add(new ResourceEntry(typeof(Tourmaline), "Tourmaline"));
				return entry;
			}
		}
		
		
		
		[Constructable]
		public ImbueKey() : base( 0 )
		{
            ItemID = 0x4025;			//Gargoyle Wooden Chest
            Name = "Artificer's Chest";
		}
		
		
		
		//this loads properties specific to the store, like the gump label, and whether it's a dynamic storage device
		protected override ItemStore GenerateItemStore()
		{
			//load the basic store info
			ItemStore store = base.GenerateItemStore();

			//properties of this storage device
            store.Label = "Artificer's Chest";
			
			store.Dynamic = false;
			store.OfferDeeds = true;
			return store;
		}
		
		//serial constructor
        public ImbueKey(Serial serial)
            : base(serial)
		{
		}
		
		//events
		
		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			
			writer.Write( 0 );
		}
		
		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );
			
			int version = reader.ReadInt();
		}
	}



}