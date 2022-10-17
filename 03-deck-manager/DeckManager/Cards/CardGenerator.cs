public class CardGenerator
{
  public List<Card> GenerateDeck(int size)
  {
    var newDeck = new Card[size];
    var numberOfCreatureCards = DateTime.Now.Ticks % size;
    var numberOfMoneyCards = size - numberOfCreatureCards;
    for (var i = 0; i < numberOfCreatureCards; i++)
    {
      newDeck[i] = new CreatureCard();
      var random = DateTime.Now.Ticks % numberOfCreatureCards;


    }
  }

  public T GenerateCard<T>() where T : Card, new()
  {
    return new T();
  }
  public static readonly string[] MoneyTitles = new string[] {
    "Ocean",
    "Mountain",
    "Field",
  };

  public static readonly string[] SpellTitles = new string[] {
    "Bandage",
    "Afflict",
    "Condemn",
    "Wrath of God",
    "Upwelling",
    "Unsummon",
    "Twincast",
    "Threaten",
    "Telepathy",
    "Terror",
    "True Believer",
    "Telling Time",
    "Shunt",
    "Shock",
    "Spirit Link",
    "Righteousness",
    "Remove Soul",
    "Time Stop",
    "Stun",
    "Uncontrollable Anger",
    "Sudden Impact",
    "Story Circle",
    "Sunken Hope",
    "Traumatize",
    "Twitch",
    "Consume Spirit",
    "Warrior's Honor",
    "Warp World",
    "Cancel",
    "Clone",
    "Assassinate",
    "Blaze",
    "Abundance",
  };
  
  public static readonly string[] CreatureTitles = new string[] {
    "Youthful Knight",
    "Yavimaya Enchantress",
    "Yavimaya Coast",
    "Wurm's Tooth",
    "Windborn Muse",
    "Wild Griffin",
    "Whispersilk Cloak",
    "Voice of All",
    "Viridian Shaman",
    "Viashino Sandscout",
    "Viashino Runner",
    "Verdant Force",
    "Venerable Monk",
    "Vedalken Mastermind",
    "Vampire Bats",
    "Unholy Strength",
    "Underworld Dreams",
    "Underground River",
    "Tundra Wolves",
    "Troll Ascetic",
    "Treetop Village",
    "Treetop Bracers",
    "Treasure Hunter",
    "Thundering Giant",
    "Thrull Surgeon",
    "Thieving Magpie",
    "The Hive",
    "Tangle Spider",
    "Sylvan Scrying",
    "Sylvan Basilisk",
    "Suntail Hawk",
    "Sulfurous Springs",
    "Steel Golem",
    "Steadfast Guard",
    "Starlight Invoker",
    "Stampeding Wildebeests",
    "Stalking Tiger",
    "Spirit Weaver",
    "Spineless Thug",
    "Spined Wurm",
    "Spiketail Hatchling",
    "Spawning Pool",
    "Spark Elemental",
    "Soulblast",
    "Soul Warden",
    "Soul Feast",
    "Snapping Drake",
    "Sleeper Agent",
    "Skyshroud Ranger",
    "Skyhunter Skirmisher",
    "Skyhunter Prowler",
    "Skyhunter Patrol",
    "Sky Weaver",
    "Siege-Gang Commander",
    "Shivan Dragon",
    "Severed Legion",
    "Serra Angel",
    "Sengir Vampire",
    "Seedborn Muse",
    "Sea Monster",
    "Scoria Wurm",
    "Scion of the Wild",
    "Scathe Zombies",
    "Samite Healer",
    "Sage Owl",
    "Rushwood Dryad",
    "Royal Assassin",
    "Rootwater Matriarch",
    "Rootwater Commando",
    "Rod of Ruin",
    "Rock Badger",
    "Robe of Mirrors",
    "Reya Dawnbringer",
    "Relentless Rats",
  };

  public static readonly string[] Descriptions = new string[] {
    "Your opponents play with their hands revealed.",
    "You may tap or untap target artifact, creature, or land.\nDraw a card.",
    "You may play land cards from your graveyard.",
    "You may have Sculpting Steel enter the battlefield as a copy of any artifact on the battlefield.",
    "You may have Rhox assign its combat damage as though it weren't blocked.\n{2}{G}: Regenerate Rhox. (The next time this creature would be destroyed this turn, it isn't. Instead tap it, remove all damage from it, and remove it from combat.)",
    "You may have Clone enter the battlefield as a copy of any creature on the battlefield.",
    "You have shroud. (You can't be the target of spells or abilities.)",
    "You have no maximum hand size.",
    "You gain 3 life.\nDraw a card.",
    "You can't cast creature spells.",
    "Yavimaya Enchantress gets +1/+1 for each enchantment on the battlefield.",
    "Whenever you cast a white, blue, black, or red spell, put a +1/+1 counter on Quirion Dryad.",
    "Whenever Sylvan Basilisk becomes blocked by a creature, destroy that creature.",
    "Whenever Goblin Elite Infantry blocks or becomes blocked, it gets -1/-1 until end of turn.",
    "Whenever Elvish Berserker becomes blocked, it gets +1/+1 until end of turn for each creature blocking it.",
    "Whenever Cephalid Constable deals combat damage to a player, return up to that many target permanents that player controls to their owners' hands.",
    "Whenever another creature enters the battlefield, you gain 1 life.",
    "Whenever an opponent draws a card, Underworld Dreams deals 1 damage to him or her.",
    "Whenever an opponent discards a card, Megrim deals 2 damage to that player.",
    "Whenever a player taps a land for mana, Manabarbs deals 1 damage to that player.",
    "Whenever a player casts a white spell, you may gain 1 life.",
    "Whenever a player casts a red spell, you may gain 1 life.",
    "Whenever a player casts a green spell, you may gain 1 life.",
    "Whenever a player casts a blue spell, you may gain 1 life.",
    "Whenever a player casts a black spell, you may gain 1 life.",
    "Whenever a creature you control dies, each other player sacrifices a creature.",
    "Whenever a creature enters the battlefield under your control, you gain life equal to its toughness.",
    "When Viridian Shaman enters the battlefield, destroy target artifact.",
    "When Venerable Monk enters the battlefield, you gain 2 life.",
    "When Treasure Hunter enters the battlefield, you may return target artifact card from your graveyard to your hand.",
    "When Sleeper Agent enters the battlefield, target opponent gains control of it.\nAt the beginning of your upkeep, Sleeper Agent deals 2 damage to you.",
    "When Siege-Gang Commander enters the battlefield, put three 1/1 red Goblin creature tokens onto the battlefield.\n{1}{R}, Sacrifice a Goblin: Siege-Gang Commander deals 2 damage to target creature or player.",
    "When Ravenous Rats enters the battlefield, target opponent discards a card.",
    "When Phyrexian Rager enters the battlefield, you draw a card and you lose 1 life.",
    "When Phage the Untouchable enters the battlefield, if you didn't cast it from your hand, you lose the game.\nWhenever Phage deals combat damage to a creature, destroy that creature. It can't be regenerated.\nWhenever Phage deals combat damage to a player, that player loses the game.",
    "When Loyal Sentry blocks a creature, destroy that creature and Loyal Sentry.",
    "When Llanowar Sentinel enters the battlefield, you may pay {1}{G}. If you do, search your library for a card named Llanowar Sentinel and put that card onto the battlefield. Then shuffle your library.",
    "When Kavu Climber enters the battlefield, draw a card.",
    "When Hunted Wumpus enters the battlefield, each other player may put a creature card from his or her hand onto the battlefield.",
    "When Highway Robber enters the battlefield, target opponent loses 2 life and you gain 2 life.",
    "When Hidden Horror enters the battlefield, sacrifice it unless you discard a creature card.",
    "When Gravedigger enters the battlefield, you may return target creature card from your graveyard to your hand.",
    "When Festering Goblin dies, target creature gets -1/-1 until end of turn.",
    "When Denizen of the Deep enters the battlefield, return each other creature you control to its owner's hand.",
    "When Civic Wayfinder enters the battlefield, you may search your library for a basic land card, reveal it, and put it into your hand. If you do, shuffle your library.",
    "When Bogardan Firefiend dies, it deals 2 damage to target creature.",
    "When Academy Researchers enters the battlefield, you may put an Aura card from your hand onto the battlefield attached to Academy Researchers.",
    "Vigilance (Attacking doesn't cause this creature to tap.)",
    "Until end of turn, if target player would draw a card, instead that player skips that draw and you draw a card.",
    "Untap target creature and gain control of it until end of turn. That creature gains haste until end of turn. (It can attack and {T} this turn.)",
    "Untap all permanents you control during each other player's untap step.",
    "Untap all creatures that attacked this turn. After this main phase, there is an additional combat phase followed by an additional main phase.",
    "Treetop Village enters the battlefield tapped.\n{T}: Add {G} to your mana pool.\n{1}{G}: Treetop Village becomes a 3/3 green Ape creature with trample until end of turn. It's still a land. (If it would assign enough damage to its blockers to destroy them, you may have it assign the rest of its damage to defending player or planeswalker.)",
    "Trample, haste (If this creature would assign enough damage to its blockers to destroy them, you may have it assign the rest of its damage to defending player or planeswalker. This creature can attack and {T} as soon as it comes under your control.)\nAt the beginning of the end step, sacrifice Spark Elemental.",
    "Trample (This creature can deal excess combat damage to defending player or planeswalker while attacking.)\nMolimo, Maro-Sorcerer's power and toughness are each equal to the number of lands you control.",
    "Trample (This creature can deal excess combat damage to defending player or planeswalker while attacking.)\nColossus of Sardia doesn't untap during your untap step.\n{9}: Untap Colossus of Sardia. Activate this ability only during your upkeep.",
    "Trample (This creature can deal excess combat damage to defending player or planeswalker while attacking.)\nAt the beginning of your upkeep, return a green creature you control to its owner's hand.",
    "Target player takes two extra turns after this one.",
    "Target player shuffles his or her graveyard into his or her library.",
    "Target player reveals his or her hand. You choose a nonland card from it. That player discards that card.",
    "Target player puts the top half of his or her library, rounded down, into his or her graveyard.",
    "Target player loses 4 life and you gain 4 life.",
    "Target player gains 8 life.",
    "Target player discards two cards.",
    "Target opponent sacrifices a creature.",
    "Target opponent puts the cards from his or her hand on top of his or her library. Search that player's library for that many cards. The player puts those cards into his or her hand, then shuffles his or her library.",
    "Target creature gets +7/+7 until end of turn.",
    "Target creature gets +4/+0 until end of turn.",
    "Target creature gets +3/+3 until end of turn.",
    "Target creature gets +3/+3 and gains flying until end of turn. (It can't be blocked except by creatures with flying or reach.)",
    "Target creature gets +1/+1 until end of turn.\nDraw a card.",
    "Target creature gets -1/-1 until end of turn.\nDraw a card.",
    "Target creature can't block this turn.\nDraw a card.",
    "Target blocking creature gets +7/+7 until end of turn.",
    "Tap all creatures without flying.",
    "Swampwalk (This creature can't be blocked as long as defending player controls a Swamp.)",
    "Swampwalk (This creature can't be blocked as long as defending player controls a Swamp.)",
    "Sudden Impact deals damage to target player equal to the number of cards in that player's hand.",
    "Stalking Tiger can't be blocked by more than one creature.",
    "Spitting Earth deals damage to target creature equal to the number of Mountains you control.",
    "Spineless Thug can't block.",
    "Spend only black mana on X.\nConsume Spirit deals X damage to target creature or player and you gain X life.",
    "Soldier creatures have vigilance.\n{2}{W}: Put a 1/1 white Soldier creature token onto the battlefield.",
    "Shroud (This creature can't be the target of spells or abilities.)",
    "Shock deals 2 damage to target creature or player.",
    "Search your library for a land card, reveal it, and put it into your hand. Then shuffle your library.",
    "Search your library for a card and put that card into your hand. Then shuffle your library.",
    "Search your library for a basic land card and put that card onto the battlefield tapped. Then shuffle your library.",
    "Sea Monster can't attack unless defending player controls an Island.",
    "Scion of the Wild's power and toughness are each equal to the number of creatures you control.",
    "Sacrifice No Rest for the Wicked: Return to your hand all creature cards in your graveyard that were put there from the battlefield this turn.",
    "Sacrifice Mogg Fanatic: Mogg Fanatic deals 1 damage to target creature or player.",
    "Sacrifice Composite Golem: Add {W}{U}{B}{R}{G} to your mana pool.",
    "Sacrifice Bottle Gnomes: You gain 3 life.",
    "Sacrifice a creature: Nantuko Husk gets +2/+2 until end of turn.",
    "Return target permanent to its owner's hand.",
    "Return target creature to its owner's hand.",
    "Return target creature card from your graveyard to your hand.\nDraw a card.",
    "Return target card from your graveyard to your hand.",
    "Return all creatures to their owners' hands.",
    "Return all artifacts target player owns to his or her hand.",
    "Relentless Rats gets +1/+1 for each other creature on the battlefield named Relentless Rats.\nA deck can have any number of cards named Relentless Rats.",
    "Reach (This creature can block creatures with flying.)",
    "Reach (This creature can block creatures with flying.)",
    "Pyroclasm deals 2 damage to each creature.",
    "Put target attacking creature on the bottom of its owner's library. Its controller gains life equal to its toughness.",
    "Put target artifact or creature card from a graveyard onto the battlefield under your control. Shuffle Beacon of Unrest into its owner's library.",
    "Prevent the next 1 damage that would be dealt to target creature or player this turn.\nDraw a card.",
    "Prevent all damage that would be dealt to Cho-Manno, Revolutionary.",
    "Prevent all damage that black sources and red sources would deal this turn.",
    "Prevent all combat damage that would be dealt this turn.",
    "Phantom Warrior can't be blocked.",
    "Other Zombie creatures get +1/+1.\n{1}{B}, {T}: Return target Zombie card from your graveyard to your hand.",
    "Other Soldier creatures get +1/+1 and have first strike. (They deal combat damage before creatures without first strike.)",
    "Other Goblin creatures get +1/+1 and have mountainwalk. (They can't be blocked as long as defending player controls a Mountain.)",
    "Other Elf creatures get +1/+1 and have forestwalk. (They can't be blocked as long as defending player controls a Forest.)",
    "Mountainwalk (This creature can't be blocked as long as defending player controls a Mountain.)",
    "Mortivore's power and toughness are each equal to the number of creature cards in all graveyards.\n{B}: Regenerate Mortivore.",
    "Menace (This creature can't be blocked except by two or more creatures.)",
    "Mana pools don't empty as steps and phases end.",
    "Look at the top three cards of your library. Put one of those cards into your hand, one on top of your library, and one on the bottom of your library.",
    "Look at the top five cards of your library. You may reveal a creature card from among them and put it into your hand. Put the rest on the bottom of your library in any order.",
    "Look at target player's hand.\nDraw a card.",
    "Look at target player's hand and choose two cards from it. Put them on top of that player's library in any order.",
    "Lava Axe deals 5 damage to target player.",
    "Karplusan Strider can't be the target of blue or black spells.",
    "Juggernaut attacks each turn if able.\nJuggernaut can't be blocked by Walls.",
    "Islandwalk (This creature can't be blocked as long as defending player controls an Island.)",
    "Incinerate deals 3 damage to target creature or player. A creature dealt damage this way can't be regenerated this turn.",
    "If you would draw a card, you may instead choose land or nonland and reveal cards from the top of your library until you reveal a card of the chosen kind. Put that card into your hand and put all other cards revealed this way on the bottom of your library in any order.",
    "If an opponent controls at least four more creatures than you, Avatar of Might costs {6} less to cast.\nTrample (This creature can deal excess combat damage to defending player or planeswalker while attacking.)",
    "If a source would deal damage to a creature or player, it deals double that damage to that creature or player instead.",
    "Hurricane deals X damage to each creature with flying and each player.",
    "Hexproof (This creature can't be the target of spells or abilities your opponents control.)\n{1}{G}: Regenerate Troll Ascetic.",
    "Haste (This creature can attack and {T} as soon as it comes under your control.)\nAt the beginning of the end step, return Viashino Sandscout to its owner's hand. (Return it only if it's on the battlefield.)",
    "Haste (This creature can attack and {T} as soon as it comes under your control.)\n{T}: Kamahl, Pit Fighter deals 3 damage to target creature or player.",
    "Haste (This creature can attack and {T} as soon as it comes under your control.)",
    "Haste (This creature can attack and {T} as soon as it comes under your control.)",
    "Haste (This creature can attack and {T} as soon as it comes under your control.)",
    "Hail of Arrows deals X damage divided as you choose among any number of target attacking creatures.",
    "Guerrilla Tactics deals 2 damage to target creature or player.\nWhen a spell or ability an opponent controls causes you to discard Guerrilla Tactics, Guerrilla Tactics deals 4 damage to target creature or player.",
    "Ghitu Encampment enters the battlefield tapped.\n{T}: Add {R} to your mana pool.\n{1}{R}: Ghitu Encampment becomes a 2/1 red Warrior creature with first strike until end of turn. It's still a land. (It deals combat damage before creatures without first strike.)",
    "Gain control of target Aura that's attached to a permanent. Attach it to another permanent it can enchant.",
    "Forestwalk (This creature can't be blocked as long as defending player controls a Forest.)",
    "Forbidding Watchtower enters the battlefield tapped.\n{T}: Add {W} to your mana pool.\n{1}{W}: Forbidding Watchtower becomes a 1/5 white Soldier creature until end of turn. It's still a land.",
    "Flying\nYou can't lose the game and your opponents can't win the game.",
    "Flying\nWhenever Hypnotic Specter deals damage to an opponent, that player discards a card at random.",
    "Flying\nWhen Sage Owl enters the battlefield, look at the top four cards of your library, then put them back in any order.",
    "Flying\nWhen Angel of Mercy enters the battlefield, you gain 3 life.",
    "Flying\nCreatures can't attack you unless their controller pays {2} for each creature he or she controls that's attacking you.",
    "Flying\nCloud Elemental can block only creatures with flying.",
    "Flying\nAt the beginning of your upkeep, you may return target creature card from your graveyard to the battlefield.",
    "Flying\nAs Voice of All enters the battlefield, choose a color.\nVoice of All has protection from the chosen color.",
    "Flying\n{T}: Add one mana of any color to your mana pool.",
    "Flying, vigilance (This creature can't be blocked except by creatures with flying or reach, and attacking doesn't cause this creature to tap.)",
    "Flying, trample\nAt the beginning of your upkeep, sacrifice a creature other than Lord of the Pit. If you can't, Lord of the Pit deals 7 damage to you.",
    "Flying, first strike (This creature can't be blocked except by creatures with flying or reach, and it deals combat damage before creatures without first strike.)",
    "Flying, double strike",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\nWhenever Thieving Magpie deals damage to an opponent, draw a card.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\nWhenever Scalpelexis deals combat damage to a player, that player exiles the top four cards of his or her library. If two or more of those cards have the same name, repeat this process.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\nWhenever a creature dealt damage by Sengir Vampire this turn dies, put a +1/+1 counter on Sengir Vampire.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\nWhen Fog Elemental attacks or blocks, sacrifice it at end of combat.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\nWhen Aven Fisher dies, you may draw a card.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\nWhen Aven Cloudchaser enters the battlefield, destroy target enchantment.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\nVigilance (Attacking doesn't cause this creature to tap.)",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\nSacrifice Spiketail Hatchling: Counter target spell unless its controller pays {1}.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\nOther black creatures get +1/+1.\nNonblack creatures get -1/-1.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\nNightmare's power and toughness are each equal to the number of Swamps you control.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\nCloud Sprite can block only creatures with flying.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\n{R}: Shivan Dragon gets +1/+0 until end of turn.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\n{R}: Furnace Whelp gets +1/+0 until end of turn.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\n{B}: Vampire Bats gets +1/+0 until end of turn. Activate this ability no more than twice each turn.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\n{1}{U}: Target player reveals the top card of his or her library.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)\n{1}{R}: Shivan Hellkite deals 1 damage to target creature or player.",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)",
    "Flying (This creature can't be blocked except by creatures with flying or reach.)",
    "Flying",
    "Flash (You may cast this spell any time you could cast an instant.)\nEnchant creature\nEnchanted creature gets +2/+2 and attacks each turn if able.",
    "First strike\nWhen Nekrataal enters the battlefield, destroy target nonartifact, nonblack creature. That creature can't be regenerated.",
    "First strike, protection from black and from red (This creature deals combat damage before creatures without first strike. It can't be blocked, targeted, dealt damage, or enchanted by anything black or red.)",
    "First strike, forestwalk, vigilance (This creature deals combat damage before creatures without first strike, it can't be blocked as long as defending player controls a Forest, and attacking doesn't cause this creature to tap.)",
    "First strike (This creature deals combat damage before creatures without first strike.)\nWhen Ancestor's Chosen enters the battlefield, you gain 1 life for each card in your graveyard.",
    "First strike (This creature deals combat damage before creatures without first strike.)",
    "Fear (This creature can't be blocked except by artifact creatures and/or black creatures.)",
    "Faerie Conclave enters the battlefield tapped.\n{T}: Add {U} to your mana pool.\n{1}{U}: Faerie Conclave becomes a 2/1 blue Faerie creature with flying until end of turn. It's still a land.",
    "Exile X target creature cards from your graveyard. For each creature card exiled this way, put a 2/2 black Zombie creature token onto the battlefield.",
    "Essence Drain deals 3 damage to target creature or player and you gain 3 life.",
    "Equipped creature gets +3/+0 and has trample and lifelink.\nEquip {3}",
    "Equipped creature gets +1/+1.\nEquip {1} ({1}: Attach to target creature you control. Equip only as a sorcery.)",
    "Equipped creature can't be blocked and has shroud. (It can't be the target of spells or abilities.)\nEquip {2}",
    "Enchant land (Target a land as you cast this. This card enters the battlefield attached to that land.)\nWhenever enchanted land is tapped for mana, its controller adds {G}{G} to his or her mana pool (in addition to the mana the land produces).",
    "Enchant creature\nEnchanted creature gets +2/+2 and has flying and vigilance.",
    "Enchant creature\nEnchanted creature gets +2/+1.",
    "Enchant creature\nEnchanted creature gets +1/+2.",
    "Enchant creature\nEnchanted creature can't attack or block.",
    "Enchant creature\nAll creatures able to block enchanted creature do so.",
    "Enchant creature\n{R}: Enchanted creature gets +1/+0 until end of turn.",
    "Enchant creature (Target a creature as you cast this. This card enters the battlefield attached to that creature.)\nYou control enchanted creature.",
    "Elven Riders can't be blocked except by Walls and/or creatures with flying.",
    "Each player shuffles all permanents he or she owns into his or her library, then reveals that many cards from the top of his or her library. Each player puts all artifact, creature, and land cards revealed this way onto the battlefield, then does the same for enchantment cards, then puts all cards revealed this way that weren't put onto the battlefield on the bottom of his or her library.",
    "Each player loses 1 life for each creature he or she controls.",
    "Each player can't cast more than one spell each turn.",
    "Each noncreature artifact is an artifact creature with power and toughness each equal to its converted mana cost. (Equipment that's a creature can't equip a creature.)",
    "Each creature you control can block an additional creature each combat.",
    "Each creature gets +1/+1 for each other creature on the battlefield that shares at least one creature type with it. (For example, if two Goblin Warriors and a Goblin Shaman are on the battlefield, each gets +2/+2.)",
    "Draw two cards.",
    "Draw three cards, then discard a card.",
    "Draw four cards.",
    "Draw four cards, then discard three cards at random.",
    "Double target player's life total. Shuffle Beacon of Immortality into its owner's library.",
    "Discard a land card: Seismic Assault deals 2 damage to target creature or player.",
    "Destroy target tapped creature.",
    "Destroy target Plains or Island. Cryoclasm deals 3 damage to that land's controller.",
    "Destroy target nonartifact, nonblack creature. It can't be regenerated.",
    "Destroy target land.",
    "Destroy target green or white creature.",
    "Destroy target enchantment.",
    "Destroy target artifact.\nDraw a card.",
    "Destroy target artifact, enchantment, or land.",
    "Destroy target artifact or land.",
    "Destroy target artifact or enchantment.",
    "Destroy all enchantments.",
    "Destroy all creatures. They can't be regenerated.",
    "Destroy all creatures you don't control. They can't be regenerated.",
    "Destroy all artifacts. They can't be regenerated.",
    "Defender, flying (This creature can't attack, and it can block creatures with flying.)",
    "Defender (This creature can't attack.)\nFlying",
    "Defender (This creature can't attack.)\nFlying",
    "Defender (This creature can't attack.)\n{R}: Wall of Fire gets +1/+0 until end of turn.",
    "Defender (This creature can't attack.)",
    "Creatures you control have trample. (If a creature you control would assign enough damage to its blockers to destroy them, you may have it assign the rest of its damage to defending player or planeswalker.)",
    "Creatures you control get +3/+3 and gain trample until end of turn.",
    "Creatures you control get +1/+1.",
    "Creatures you control get +1/+1 until end of turn.",
    "Creature spells can't be countered.",
    "Counter target spell. Look at the top four cards of your library, then put them back in any order.",
    "Counter target spell.",
    "Counter target red or green spell.",
    "Counter target creature spell.",
    "Copy target instant or sorcery spell. You may choose new targets for the copy.",
    "Cone of Flame deals 1 damage to target creature or player, 2 damage to another target creature or player, and 3 damage to a third target creature or player.",
    "Change the target of target spell with a single target.",
    "Bloodrock Cyclops attacks each turn if able.",
    "Blaze deals X damage to target creature or player.",
    "Beacon of Destruction deals 5 damage to target creature or player. Shuffle Beacon of Destruction into its owner's library.",
    "At the beginning of your upkeep, you may return Squee, Goblin Nabob from your graveyard to your hand.",
    "At the beginning of your upkeep, you draw X cards and you lose X life, where X is the number of Zombies you control.",
    "At the beginning of your upkeep, if twenty or more creature cards are in your graveyard, you win the game.",
    "At the beginning of your upkeep, flip a coin. If you lose the flip, return Scoria Wurm to its owner's hand.",
    "At the beginning of each upkeep, put a 1/1 green Saproling creature token onto the battlefield.",
    "At the beginning of each player's upkeep, that player returns a creature he or she controls to its owner's hand.",
    "At the beginning of each player's upkeep, that player puts the top X cards of his or her library into his or her graveyard, where X is the number of cards in his or her hand.",
    "At the beginning of each player's draw step, if Howling Mine is untapped, that player draws an additional card.",
    "At the beginning of each opponent's upkeep, if that player has two or fewer cards in hand, Lavaborn Muse deals 3 damage to him or her.",
    "As Story Circle enters the battlefield, choose a color.\n{W}: The next time a source of your choice of the chosen color would deal damage to you this turn, prevent that damage.",
    "As Pithing Needle enters the battlefield, name a card.\nActivated abilities of sources with the chosen name can't be activated unless they're mana abilities.",
    "As an additional cost to cast Soulblast, sacrifice all creatures you control.\nSoulblast deals damage to target creature or player equal to the total power of the sacrificed creatures.",
    "Artifacts and lands enter the battlefield tapped.",
    "Artifact and enchantment spells your opponents cast cost {2} more to cast.\nSacrifice Aura of Silence: Destroy target artifact or enchantment.",
    "All creatures get +X/-X until end of turn.",
  };
}