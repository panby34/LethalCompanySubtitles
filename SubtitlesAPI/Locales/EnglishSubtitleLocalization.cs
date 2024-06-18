﻿using System;
using System.Collections.Generic;

namespace SubtitlesAPI.Locales;

public class EnglishSubtitleLocalization : ISubtitleLocalization
{
    public string Locale => "en";

    public Dictionary<string, string> Translations => new(StringComparer.OrdinalIgnoreCase)
    {
        { "AirHorn1", "Air horn plays" },
        { "AirHornFar", "Distant air horn plays" },
        { "AlertHUD", "Warning alarm" },
        { "Angered", "Rustling" },
        { "AngryScreech", "Bug screeches" },
        { "AngryScreech2", "Bug screeches" },
        { "BaboonEnterFight", "Hawk screeches" },
        { "BaboonStab", "Hawk attacks" },
        { "BaboonTakeDamage", "Hawk hurt" },
        { "BareFootstep1", "Coilhead footstep" },
        { "BareFootstep2", "Coilhead footstep" },
        { "BareFootstep3", "Coilhead footstep" },
        { "BareFootstep4", "Coilhead footstep" },
        { "BeeHiveDrop", "Dropped beehive" },
        { "BeeHiveGrab", "Grabbed beehive" },
        { "BeeHiveIdle", "Bees buzz" },
        { "BeesAngry", "Bees buzz angrily" },
        { "BeeZap1", "Bees attack" },
        { "BeeZap2", "Bees attack" },
        { "BeeZap3", "Bees attack" },
        { "BeeZap4", "Bees attack" },
        { "BeeZap5", "Bees attack" },
        { "BeeZap6", "Bees attack" },
        { "BeeZapConstant", "Bees attack" },
        { "BellChimeAmbience", "Bell chimes distantly" },
        { "BellDinger", "Bell dings" },
        { "BigDoorClose", "Secure door closes" },
        { "BigDoorOpen", "Secure door opens" },
        { "Bird1", "Bird chirps" },
        { "Bird2", "Bird coos" },
        { "Bird3", "Bird chitters" },
        { "BirdScreech1", "Bird screeches" },
        { "BirdScreech2", "Bird screeches" },
        { "BitePlayer", "Player bitten" },
        { "Blast1", "Distant blast" },
        { "Blast2", "Distant blast" },
        { "Blizzard", "Wind howls" },
        { "BloodGore", "Blood splatters" },
        { "BodyCollision1", "Body hits" },
        { "BodyCollision2", "Body hits" },
        { "BodyCollision3", "Body hits" },
        { "BoomboxMusic1", "Boombox plays" },
        { "BoomboxMusic2", "Boombox plays" },
        { "BoomboxMusic2TVVersion", "TV plays music" },
        { "BoomboxMusic3", "Boombox plays" },
        { "BoomboxMusic4", "Boombox plays" },
        { "BoomboxMusic5Zedfox", "Boombox plays" },
        { "BoomboxStop", "Boombox stops" },
        { "BootStomp1", "Nutcracker stomps" },
        { "BootStomp2", "Nutcracker stomps" },
        { "BootStomp3", "Nutcracker stomps" },
        { "BranchSnap1", "Branch snaps" },
        { "BranchSnap2", "Branch snaps" },
        { "BreakerBoxClose", "Breaker opens" },
        { "BreakerBoxHum", "Breaker hums" },
        { "BreakerBoxOpen", "Breaker closes" },
        { "BreakerLever1", "Lever flips" },
        { "BreakerLevel2", "Lever flips" },
        { "BreakerLever3", "Lever flips" },
        { "BreakWeb", "Web breaks" },
        { "Breath1", "Sharp breath" },
        { "Breath2", "Panting" },
        { "Breath3", "Huff" },
        { "Breathe1", "Dog breathing" },
        { "Breathing", "Breathing" },
        { "BridgeCollapse3", "Bridge collapses" },
        { "BridgeCollapseV2", "Bridge collapses" },
        { "BridgeCreak1", "Bridge creaks" },
        { "BridgeCreak2", "Bridge creaks" },
        { "BridgeCreak3", "Bridge creaks" },
        { "BridgeCreakHeavy2", "Bridge creaks" },
        { "BroomSweep1", "Broom sweeps" },
        { "BroomSweep2", "Broom sweeps" },
        { "BroomSweep3", "Broom sweeps" },
        { "BroomSweep4", "Broom sweeps" },
        { "BugDie", "Bug dies" },
        { "BugWalk1", "Bug walks" },
        { "BugWalk2", "Bug walks" },
        { "BugWalk3", "Bug walks" },
        { "BugWalk4", "Bug walks" },
        { "BumpOutsideShip1", "Distant bump" },
        { "BumpOutsideShip2", "Distant bump" },
        { "BumpOutsideShip3", "Distant bump" },
        { "BumpOutsideShip4", "Distant bump" },
        { "BumpOutsideShip5", "Distant bump" },
        { "BunnyHop", "Bunny hops" },
        { "BurrowingRumbleLoud1", "Ground shakes" },
        { "BurrowingRumble1", "Ground rumbles" },
        { "BurrowingRumble2", "Ground rumbles" },
        { "BurrowingRumble3", "Ground rumbles" },
        { "BushRustle1", "Bush rustles" },
        { "BushRustle2", "Bush rustles" },
        { "ButlerBeeSwarm", "Bees buzz" },
        { "ButlerBlowUp", "Butler dies" },
        { "ButlerBuzzingAmbience", "Muffled buzzing" },
        { "ButlerMurderTheme", "Dramatic sting" },
        { "ButlerStab", "Butler stabs" },
        { "ButlerStep1", "Butler walks" },
        { "ButlerStep2", "Butler walks" },
        { "ButlerStep3", "Butler walks" },
        { "ButlerStep4", "Butler walks" },
        { "ButlerStep5", "Butler walks" },
        { "ButlerSuitRustle", "Butler rustles" },
        { "ButlerUntuckKnifeSFX", "Butler pulls out knife" },
        { "CashRegisterDing", "Cash register dings" },
        { "CawScream1", "Hawk screeches" },
        { "CawScream2", "Hawk screeches" },
        { "CawScream3", "Hawk screeches" },
        { "CawScream4", "Hawk screeches" },
        { "CawScream5", "Hawk screeches" },
        { "ClingToPlayer", "Snare Flea clings" },
        { "ClingToPlayerLocal", "Snare Flea clings" },
        { "ClownHorn1", "Clown horn plays" },
        { "ClownHornFar", "Distant clown horn plays" },
        { "CrackNeck", "Neck snap" },
        { "DistantRumble1", "Distant rumbles" },
        { "DistantRumble2", "Distant rumbles" },
        { "DistantRumble3", "Distant rumbles" },
        { "DocileLocustBeesEvade", "Locusts disperse" },
        { "DoorClose1", "Door opens" },
        { "DoorClose2", "Door opens" },
        { "DoorOpen1", "Door closes" },
        { "DoorOpen2", "Door closes" },
        { "DoorShut", "Door shuts" },
        { "DoorSlam1", "Door slams" },
        { "DoorSlam2", "Door slams" },
        { "DoorUnlock", "Door unlocks" },
        { "DoorUnlock2", "Door unlocks" },
        { "DoublewingFlap1", "Flapping" },
        { "DoublewingFlap2", "Flapping" },
        { "DoublewingFlap3", "Flapping" },
        { "DuckQuack", "Rubber duck quacks" },
        { "EmergeFromGround1", "Earth Leviathan attacks" },
        { "ExplodeHead", "Head explodes" },
        { "ExplodeHeadSecondarySFX", "Head explodes" },
        { "ExtensionLadderAlarm", "Extension Ladder expiring alarm" },
        { "ExtensionLadderExtend", "Extension Ladder extending" },
        { "ExtensionLadderShrink", "Extension Ladder shrinking" },
        { "Fart1", "Farting sounds" },
        { "Fart2", "Farting sounds" },
        { "Fart3", "Farting sounds" },
        { "Fart5", "Farting sounds" },
        { "FGiantEatPlayerSFX", "Player is eaten" },
        { "Fireplace", "Crackling" },
        { "FlashbangExplode", "Flashbang explodes" },
        { "FlashlightClick", "Flashlight clicks" },
        { "FlashlightClickMini", "Light switch turns on" },
        { "FlashlightClickMini2", "Light switch turns off" },
        { "Footstep1", "Footsteps" },
        { "Footstep2", "Footsteps" },
        { "Footstep3", "Footsteps" },
        { "Footstep4", "Footsteps" },
        { "Footstep5", "Footsteps" },
        { "Found1", "Rustling" },
        { "Frighten1", "Creature frightened" },
        { "Frighten3", "Creature frightened" },
        { "GiantStomp1", "Giant stomps" },
        { "GiantStomp2", "Giant stomps" },
        { "GiantStomp3", "Giant stomps" },
        { "GiantStomp4", "Giant stomps" },
        { "GiantStomp5", "Giant stomps" },
        { "growl", "Dog growls" },
        { "HangarDoorOpen1", "Ship door opens" },
        { "HangarDoorOpening", "Ship door opening" },
        { "HangarDoorShut", "Ship door closes" },
        { "HoarderBugCry", "Hoarder bug cries" },
        { "ItemDropshipLand", "Item dropship lands" },
        { "ItemDropshipOpenDoors", "Item doorship door opens" },
        { "JackInTheBoxTheme", "Jack in the Box theme plays" },
        { "JackOLanternHit", "Jack-O-Lantern laughs" },
        { "JesterStomp1", "Intense stomps" },
        { "JesterStomp2", "Intense stomps" },
        { "JesterStomp3", "Intense stomps" },
        { "KillPlayer", "Player is mauled" },
        { "KillPlayer_0", "Player is mauled" },
        { "LightningStrike1", "Lightning strikes" },
        { "LightningStrike2", "Lightning strikes" },
        { "LightningStrike3", "Lightning strikes" },
        { "LightningStrike4", "Lightning strikes" },
        { "LongRoar1", "Creature roars" },
        { "LongRoar2", "Creature roars" },
        { "LongRoar3", "Creature roars" },
        { "LoudCreak1", "Loud creaks" },
        { "LoudCreak2", "Loud creaks" },
        { "LoudCreak3", "Loud creaks" },
        { "Lunge1", "Dog lunges" },
        { "LungMachineDisconnect", "Apparatus disconnects" },
        { "MaskCry1", "Masked cries" },
        { "MaskCry2", "Masked cries" },
        { "MaskCry3", "Masked cries" },
        { "MaskCry4", "Masked cries" },
        { "MaskLaugh1", "Masked laughs" },
        { "MaskLaugh2", "Masked laughs" },
        { "MaskLaugh3", "Masked laughs" },
        { "MaskPuke", "Masked pukes" },
        { "MetalDoorShut1 1", "Metal door shuts" },
        { "MetalDoorShut1", "Metal door shuts" },
        { "MetalDoorShut2", "Metal door shuts" },
        { "MineBeep", "Landmine beeps" },
        { "MineTrigger", "Landmine triggers" },
        { "MineDetonate", "Landmine detonates" },
        { "MineDetonateDistance", "Landmine detonates distantly" },
        { "monsterNoise", "Monster noises" },
        { "monsterNoise2", "Monster noises" },
        { "monsterNoiseB", "Monster noises" },
        { "Nervous", "Creature nervous" },
        { "NutcrackerAngry", "Nutcracker angers" },
        { "PlushieSqueeze", "Plushie squeezes" },
        { "Pop1", "Jack in the Box pops" },
        { "PullCord", "Cord pulled" },
        { "RattleTail", "Rattling tail" },
        { "Roar", "Giant Rumbles" },
        { "Roar_0", "Dog roars" },
        { "RobotToyCheer", "Robot toy cheers" },
        { "SandWormRoar", "Earth Leviathan roars" },
        { "SandWormRoar2", "Earth Leviathan roars" },
        { "Scan", "Scan activates" },
        { "Scream1", "Low screaming" },
        { "ShipTeleporterSpin", "Teleporter activates" },
        { "ShipTeleporterSpinInverse", "Inverse Teleporter activates" },
        { "ShipThrusterClose", "Ship thruster" },
        { "ShortRoar1", "Short roars" },
        { "ShotgunBlast", "Shotgun shoots" },
        { "ShotgunBlast2", "Shotgun shoots" },
        { "ShotgunReload", "Shotgun reloads" },
        { "ShotgunReloadNutcracker", "Nutcracker reloads" },
        { "Shriek1", "Shriek" },
        { "Shriek2", "Shriek" },
        { "ShipAlarmHornConstant", "Ship horn blares" },
        { "ShipAlarmHornConstantDistant", "Ship horn blares distantly" },
        { "SkipWalk", "Skipping" },
        { "SkipWalk1", "Skipping" },
        { "SkipWalk2", "Skipping" },
        { "SkipWalk3", "Skipping" },
        { "SkipWalk4", "Skipping" },
        { "SkipWalk5", "Skipping" },
        { "SkipWalk6", "Skipping" },
        { "SlimeAngry", "Slime angers" },
        { "SlimeDance", "Slime dances" },
        { "SlimeIdle", "Slime idles" },
        { "SlimeKillPlayer", "Player is absorbed" },
        { "SpiderAttack", "Spider attacks" },
        { "Spring1", "Spring" },
        { "Spring2", "Spring" },
        { "Spring3", "Spring" },
        { "SpringWobble1", "Spring wobbles" },
        { "SpringWobble2", "Spring wobbles" },
        { "Squeak1", "Squeaks" },
        { "Squeak2", "Squeaks" },
        { "StickyNote", "Paper rustling" },
        { "Stomp", "Stomps" },
        { "Stomp1", "Stomps" },
        { "Stomp1double", "Stomps" },
        { "Stomp2", "Stomps" },
        { "Stomp2double", "Stomps" },
        { "Stomp3", "Stomps" },
        { "Stomp3double", "Double stomps" },
        { "StormStaticElectricity", "Static electricity buzzing" },
        { "StuckInWeb", "Web rustling" },
        { "StunCrawler", "Thumper stunned" },
        { "StunDog", "Dog stunned" },
        { "StunDoublewing", "Bird stunned" },
        { "StunFlowerman", "Bracken stunned" },
        { "StunGiant", "Giant stunned" },
        { "StunSpider", "Spider stunned" },
        { "Thunder1", "Thunder" },
        { "Thunder2", "Thunder" },
        { "Thunder3", "Thunder" },
        { "ToiletFlush", "Toilet flushes" },
        { "TunnelIntoGround1", "Earth Leviathan lands" },
        { "TurnTVOff", "TV turns off" },
        { "TurnTVOn", "TV turns on" },
        { "TurretActivate", "Turret activates" },
        { "TurretBerserkMode", "Turret berserks" },
        { "TurretDeactivate", "Turret deactivates" },
        { "TurretFire", "Turret fires" },
        { "TurretFireDistance", "Turret fires distantly" },
        { "TurretSeePlayer", "Turret locks aim" },
        { "TVKittenTheme", "Muffled trombone music" },
        { "VentCrawl1", "Vent noises" },
        { "VentOpen1", "Vent opens" },
        { "WarningHUD", "Warning beep" },
        { "WarningHUD2", "Warning beep" },
        { "WarningHUD3", "Warning beep" },
    };

    public Dictionary<string, List<(float, string)>> DialogueTranslations => new(StringComparer.OrdinalIgnoreCase)
    {
        {
            "0DaysLeftAlert",
            new()
            {
                (0, "[Company Jingle plays]"),
                (4.969f, "Report to the company building immediately"),
                (7.189f, "to sell your scrap metal and other goods."),
                (9.758f, "You have zero days left to meet the profit quota."),
                (13.085f, "You can use the terminal to route"),
                (14.874f, "the autopilot to the company building."),
            }
        },
        {
            "IntroCompanySpeech",
            new()
            {
                (0, "[Company Jingle plays]"),
                (7.310f, "Welcome to your first day on the job!"),
                (10.140f, "This is your very own autopilot ship"),
                (12.440f, "where you will eat and sleep"),
                (13.800f, "for the duration of your contract."),
                (15.280f, "[Unintelligible fast speech]"),
                (19.940f, "Make yourself at home."),
                (21.690f, "To complete the onboarding process,"),
                (23.770f, "you will want to check the instruction manual"),
                (25.650f, "and sign into your ship's computer terminal."),
                (28.290f, "We trust you will be a great asset to the company."),
                (31.035f, "Great-great asset to the company-"),
                (32.830f, "asset great-great-great asset to the company-"),
                (35.235f, "asset to great-great asset to the-"),
            }
        },
        {
            "LightningAudio",
            new()
            {
                (0.0f, "[Upbeat music plays]"),
                (3.020f, "[Lightning strikes]"),
                (4.300f, "[Laugh track]"),
            }
        },
        {
            "SnareFleaTipChannel",
            new()
            {
                (0.330f, "If an entity has come in contact with a crew member,"),
                (2.830f, "please refrain from immediate self-defense."),
                (5.300f, "Instead, ask the crew member the following:"),
                (7.495f, "\"Is the entity being aggressive?\""),
                (9.410f, "\"Are you injured?\""),
                (10.635f, "\"Do you need assistance?\""),
                (11.730f, "If the answer to all of these questions is yes,"),
                (13.920f, "you begin your self-defense measures."),
                (15.900f, "If the crew member is stressed,"),
                (17.190f, "strike a question like \"How was your day?\""),
                (19.620f, "Thank you for your cooperation, and happy travels!"),
            }
        },
        {
            "VoiceHey",
            new()
            {
                (0.0f, "Hey."),
            }
        },
    };
}