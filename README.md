# UniversalStorageKeys
 Universal Storage Keys
 Will only work with the Latest Servuo Repo and Latest VS.
 
 How to Install Wiki
 https://github.com/WPDevMalroth/UniversalStorageKeys/wiki
 
 ![](https://www.uomoons.com/UniversalStorageKeys.png)
 
Some of the main storage types include:

    Resource Storage: Items like resources, where the amount is pooled into the keys.
    Tool Storage: Items like tools where the uses remaining or charges are pooled into the keys.
    Custom Storage: Make custom keys to store other custom items that you may have.
    "List" Storage: Distinguishable items like magic instruments, or treasure maps, where more than one property is needed to describe the item. These are displayed as a list of items, rather than a pooled quantity
    "Stash" Storage: Complex distinguishable items like weapons, armor, jewelry, or clothing.
    Key Storage: Store all your key types within a single Master Key!


For players
These items make item storage and management a lot easier and more organized. Multi-use tools can be developed. Thousands upon thousands of stones worth of resources can be easily carried. When you craft, the resources can be directly withdrawn from the keys. When you cast, the reagents can come from the keys. You can use potions and water directly from the keys too!

For developers
These items can significantly cut down the amount of world data on your shard. When items are "stored" within the keys, the physical item itself ceases to exist, while only relevant data (eg. uses remaining for tools, or amount for resources) is preserved. This could significantly reduce item count, and world load/save times, depending on how much stuff your players have stashed away in their houses/banks. Plus, it's easy to follow the example items to make your own type of keys that suit your shard's custom needs. Finally, this system is intended to be as easy to drop in and run as possible, so it should be little hassle to get it working for you.
