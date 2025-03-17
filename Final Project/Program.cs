using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = "";
            string input = "";
            int hLife = 100;
            int[] accuracy = { 1, 2, 3 };
            int[] hDamage = { 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            int[] criticalHit = { 1, 2, 3, 4, 5 };
            Random chance = new Random();
            int heroDamage = 0;
            int enemyDamage = 0;
            int criticalChance = 0;
            int hCritical = hDamage[hDamage.Length - 1] * 2;
            int accuracyCheck = 0;
            int[] eDamage = new int[6];

            int roomNum = 0;
            int SouthWestLeverPulled = 0;
            int SouthEastLeverPulled = 0;
            int NorthWestLeverPulled = 0;
            int NorthEastLeverPulled = 0;
            int LockedDoorOpen = 0;
            int KeyCollect = 0;
            int JournalGet = 0;
            int CatwalkKeyGet = 0;
            int CatwalkLockedDoorOpen = 0;
            int WellKeyGet = 0;
            int WellDoorUnlocked = 0;
            int TomeGet = 0;
            int TotemPuzzle = 0;
            int VaultEmpty = 0;
            int DeathbellPoison = 0;
            int PinkFlowerPotion = 0;
            int RedBerriesPotion = 0;
            int FireResist = 0;
            int GemGet = 0;
            int flood = 0;
            string NorthwestT = "snake";
            string NortheastT = "mouse";
            string SouthwestT = "mongoose";
            string SoutheastT = "fox";
            Rooms[] roomArray = new Rooms[41];
            Combat[] enemyArray = new Combat[5];
            int CorpseGroupDefeated = 0;
            int CorpseGroup2Defeated = 0;

            roomArray[0] = new Rooms(-1, -1, -1, 1);
            roomArray[1] = new Rooms(0, -1, -1, 2);
            roomArray[2] = new Rooms(1, 22, 23, 3);
            roomArray[3] = new Rooms(2, 22, 23, -1);
            roomArray[4] = new Rooms(3, -1, -1, 5);
            roomArray[5] = new Rooms(4, 24, 25, 27);
            roomArray[6] = new Rooms(-1, -1, -1, 7);
            roomArray[7] = new Rooms(6, -1, 8, 32);
            roomArray[8] = new Rooms(7, 9, -1, -1);
            roomArray[9] = new Rooms(-1, 33, 34, 10);
            roomArray[10] = new Rooms(9, -1, -1, 35);
            roomArray[11] = new Rooms(37, -1, -1, -1);
            roomArray[12] = new Rooms(37, -1, -1, -1);
            roomArray[13] = new Rooms(-1, -1, -1, 14);
            roomArray[14] = new Rooms(13, -1, 39, 15);
            roomArray[15] = new Rooms(14, -1, 39, 16);
            roomArray[16] = new Rooms(15, -1, -1, 17);
            roomArray[17] = new Rooms(16, -1, -1, 18);
            roomArray[18] = new Rooms(-1, 40, -1, -1);
            roomArray[19] = new Rooms(-1, 20, -1, -1);
            roomArray[20] = new Rooms(-1, -1, -1, -1);
            roomArray[21] = new Rooms(-1, -1, -1, -1);
            roomArray[22] = new Rooms(-1, -1, 2, -1);
            roomArray[23] = new Rooms(-1, 2, -1, -1);
            roomArray[24] = new Rooms(-1, -1, 5, 26);
            roomArray[25] = new Rooms(-1, 5, -1, 28);
            roomArray[26] = new Rooms(24, -1, 27, 29);
            roomArray[27] = new Rooms(5, 26, 28, 30);
            roomArray[28] = new Rooms(25, 27, -1, 31);
            roomArray[29] = new Rooms(26, -1, 30, -1);
            roomArray[30] = new Rooms(27, 29, 31, -1);
            roomArray[31] = new Rooms(28, 30, -1, -1);
            roomArray[32] = new Rooms(7, -1, -1, -1);
            roomArray[33] = new Rooms(-1, -1, 9, -1);
            roomArray[34] = new Rooms(-1, 9, -1, -1);
            roomArray[35] = new Rooms(10, 37, 36, -1);
            roomArray[36] = new Rooms(-1, -1, 35, -1);
            roomArray[37] = new Rooms(35, 38, 38, 11);
            roomArray[38] = new Rooms(10, -1, -1, 10);
            roomArray[39] = new Rooms(-1, 15, -1, -1);
            roomArray[40] = new Rooms(-1, -1, -1, -1);

            roomArray[0].name = "Ruins Entrance";
            roomArray[0].desc = "Now you're stuck. Hopefully, the thousand-year-old dead don't mind you traveling through the place....\n"
                + "There are stairs up ahead.";

            roomArray[1].name = "Entrance Stairs";
            roomArray[1].desc = "You quietly walk through the dark passageway to the stairs.\n"
                + "For all the admirable work that was put into the passageway, you wish they at least put railings on the stairs.\n"
                + "You cough. You worry about what could be in the musty air.";

            roomArray[2].name = "Dining Hall";
            

            roomArray[3].name = "Locked Door";
            

            roomArray[4].name = "Burial Hallway";
            if(CorpseGroupDefeated == 0 && roomNum == 4)
            {
                roomArray[4].desc = "This room has bodies lining every single wall within alcoves. There is a caved in stairwell about halfway through.\n"
                + "Some of the bodies are only skeletons, while others are partially decomposed.\n"
                + "Some of them are armored...in fact, there is something stirring in here.\n"
                + "Suddenly, you realize. You turn around to find that some of the bodies have awoken! They draw their swords and axes!";
            }
            else
            {
                roomArray[4].desc = "The bodies you fought were not the only armored corpses in the room. Go somewhere else before more wake up!";
            }
            eDamage[0] = 5;
            eDamage[1] = 6;
            eDamage[2] = 7;
            eDamage[3] = 8;
            eDamage[4] = 9;
            eDamage[5] = 10;
            Combat CorpseGroup = new Combat(50, eDamage, 20, 3);
            enemyArray[1] = CorpseGroup;
            enemyArray[1].enemyName = "Corpse Group";

            roomArray[5].name = "Bathtub Room - North";
            roomArray[5].desc = "You walk into a large room with four pillars and a circuler bathtub in the middle. In each corner there is a lever.\n"
                + "Several portions of the roof have collapsed, and other pillars in the room have had half of their tops taken off from collapsation.\n"
                + "There are levers in every corner of the room. You can go in any direction to reach tham, or you could go south to reach the center of the room.";

            roomArray[6].name = "Natural Cave";
            roomArray[6].desc = "You follow the cave, hearing a sound every now and then. Eventually, you see a turn. There is no going any other way from here.";

            roomArray[7].name = "Turn";
            roomArray[7].desc = "You come to the turn. Up ahead is skylight. It may be wise to check it out. Or, you can continue following the cave.";

            roomArray[8].name = "Underground Waterfall";
            roomArray[8].desc = "You continue to follow the cave for a long time. Just when you think it will never end,"
                + "the cave opens up into a larger cave with a waterfall and glowing mushrooms all over the walls."
                + "The waterfall seems to be pouring more water in by the second"
                + "You see an entryway back into the ruins from here. It would be best not to come back in here when you return to the ruins. Go west to do so.";

            roomArray[9].name = "Crescent Room";
            roomArray[9].desc = "You come into a crescent-shaped room. Inside the crescent (to your east) is a room that appears to have a journal on a table.\n"
                + "To the immediate west is a room with a well, but there is a skeleton in the doorway. Up ahead appears to be a room full of catwalks.";

            roomArray[10].name = "Catwalk Room - Lower Catwalk";
            roomArray[10].desc = "You come to the lower catwalk. Above you are two other catwalks. The highest one appears to have an entrance, while water is overflowing from the middle catwalk.\n" +
                "There is a stairwell up ahead.";

            roomArray[11].name = "Catwalk Room - Door";
            if (CatwalkLockedDoorOpen == 0 && CatwalkKeyGet == 0 && roomNum == 11)
            {
                roomArray[11].desc = "Again, at the door, not in it. Also, once again, you need a key to open this door. It should be around here somewhere...";
            }
            else if (CatwalkLockedDoorOpen == 0 && CatwalkKeyGet == 1 && roomNum == 11)
            {
                roomArray[11].desc = "You come to the door and put the key in it. It unlocks. You can now proceed.";
                CatwalkLockedDoorOpen = 1;
                roomArray[11].south = 12;
            }
            else
            {
                roomArray[11].desc = "The door is already open. You can head on through.";
                roomArray[11].south = 12;
            }

            roomArray[12].name = "Coffin Room";
            if(WellKeyGet == 0 && roomNum == 12)
            {
                roomArray[12].desc = "As you walk into the circular room, you are taken aback by the number of coffins in the room. They are laying down with 4 or 5 coffins on each row above and below you.\n"
                + "They are attached to the wall. There is also a key on a pedestal in the middle of the room. It looks like the key to the well, so you take it.\n"
                + "You failed to notice that coffins also surround you except inside the two doorways of the room, one of which is blocked off. Not until you hear some of the coffins open do you\n"
                + "realize how familiar of a situation this is about to become...";
                WellKeyGet = 1;
            }
            else
            {
                roomArray[12].desc = "You have already collected the key from this room. Leave before any of the coffins above or below you open up!";
            }
            eDamage[0] = 5;
            eDamage[1] = 6;
            eDamage[2] = 7;
            eDamage[3] = 8;
            eDamage[4] = 9;
            eDamage[5] = 10;
            Combat CorpseHorde = new Combat(50, eDamage, 20, 6);
            enemyArray[4] = CorpseHorde;
            enemyArray[4].enemyName = "Corpse Horde";

            roomArray[13].name = "Burial Room";
            if(CorpseGroup2Defeated == 0 && roomNum == 13)
            {
                roomArray[13].desc = "As you finally reach the exit of the long underwater tunnel and climb up the stairs to the land, you can't help but notice that the room you are walking through is\n" +
                "almost identical to the first burial chamber, the only difference being that there is a cave-in on the opposite side from the previous chamber.\n" +
                "Because of this, you find yourself unsurprised when you hear the same sound of bodies rising from the alcoves and drawing their weapons.";
            }
            else
            {
                roomArray[4].desc = "Again, the bodies you fought were not the only armored corpses in the room. You can't do anything about the blocked-off passage," +
                    "so go somewhere else before more wake up!";
            }
            eDamage[0] = 5;
            eDamage[1] = 6;
            eDamage[2] = 7;
            eDamage[3] = 8;
            eDamage[4] = 9;
            eDamage[5] = 10;
            Combat CorpseGroup2 = new Combat(50, eDamage, 20, 3);
            enemyArray[2] = CorpseGroup2;
            enemyArray[2].enemyName = "Corpse Group 2";

            roomArray[14].name = "4 Totems Room";
            if (TotemPuzzle == 0 && roomNum == 14)
            {
                roomArray[14].desc = "You come into a room with four totems, each with three sides, and a large monument in the center. A gate closes in the doorframe behind you. Two more closed gates\n" +
                "are to the north and west. On a pedestal is a tome, and you make absolute sure the pedestal is not trapped. After you are sure there is no trap and no coffins in the room, you\n" +
                "take the tome. Type 'Tome' to read it.\n" +
                "\n" +
                "Furthermore, you cannot move now. You can only turn each of the four totems. The northern totems have a snake, a mouse, and a hawk. The southern totems have a snake, a mongoose, and\n" +
                "a fox. The northwestern totem is marked with a 1, the northeastern totem is marked with a 2, the southwestern totem is marked with a 3, and the southeastern totem is marked with a 4.\n" +
                "Turn a totem by stating its location and the animal you want to turn to. For example, Northeast Hawk.";
                TomeGet = 1;
            }
            else
            {
                roomArray[14].desc = "All the gates are open now. Go where you like.";
            }

            roomArray[15].name = "Flooded Stairwell";
            roomArray[15].desc = "As you climb down the parially collapsed stairwell, you notice that water is pouring into the stairwell from the ceiling next to one of the collapsed sections\n" +
                "and causing water to flow down the entire stairwell. You hear the sound of waterfalls up ahead.";

            roomArray[16].name = "Flooded Bathtub Room";
            roomArray[16].desc = "Water flows down from the ceiling in waterfalls. Part of the ceiling collapses as you walk in, flooding the room with even more water. This must be where you heard\n" +
                "the cave-in. It's becoming painfully obvious that the blockage from earlier is causing the lower levels of the ruins to collapse. There is an opening on the other side of the room.\n" +
                "It would be best to endure the rain coming from the ceiling and get over there!";

            roomArray[17].name = "Alchemy Room";
            roomArray[17].desc = "As you run through the flooded bethtub, you can see light up ahead. You enter the room ahead to find that although there is indeed skylight coming from this room,\n" +
                "it is only skylight coming from a hole in the ceiling that would be too small to climb through if you could even reach it. There are a lot of different types of flowers in this\n" +
                "room. There are also a few alchemy labs in the far end of the room. This must be where all the poison were made, so if you want to make any potions you will have to be careful\n" +
                "what you use.\n" +
                "\n" +
                "There are an abundant amount of large cone-shaped flowers with bright purple and black colors, some pink flowers, and 1 or 2 bushes of red berries.\n" +
                "You must remember that there is only one effect per ingredient, and the ingredients effects are not limited only hurting or harming you. You can also just move on without\n" +
                "making a potion.\n" +
                "\n" +
                "Type 'Purple flowers', 'Pink flowers', or 'Red berries', to make a potion with one of these ingredients. This will only work in this room and if you do not already have a potion.";

            roomArray[18].name = "Flooded Coffin Room";
            roomArray[18].desc = "As you walk into the room, you notice that this room is starting to flood. To your west is an enormous statue. In place of its eyes are two white, oval-shaped\n" +
                "gemstones as wide as a grown man's torso is tall. In front of you is a single coffin, lying down, that bursts open as you approach it. With a cry, out comes a hovering humaniod\n" +
                "figure wearing ragged robes and a mask. It is holding a staff and seems furious that the stronghold is flooding. No doubt the rest of the stronghold is flooding as well and you\n" +
                "cannot go back the way you came. The water level in the room is rising fast, so it would be best to finish this quickly, even if it looks like you cannot!";
            eDamage[0] = 10;
            eDamage[1] = 11;
            eDamage[2] = 12;
            eDamage[3] = 13;
            eDamage[4] = 14;
            eDamage[5] = 15;
            Combat Preist = new Combat(150, eDamage, 30, 1);
            enemyArray[3] = Preist;
            enemyArray[3].enemyName = "Preist";

            roomArray[19].name = "Final Tunnel";
            if(GemGet == 1 && roomNum == 10)
            {
                roomArray[19].desc = "As you leave the flooded chamber, both gems in your hand, you notice a drop up ahead. You jump down to find yourself sourrounded by ceremonial urns similar\n" +
                    "to the ones you found in the ruins. Up ahead is an exit to the cave.";
            }
            else
            {
                roomArray[19].desc = "The water is too deep to get the gems now. As you leave the flooded room you notice a drop up ahead. You jump down to find yourself sourrounded by ceremonial\n" +
                    "urns similar to the ones you found in the ruins. Up ahead is an exit to the cave.";
            }

            roomArray[20].name = "Cave Exit";
            roomArray[20].desc = "As you exit the cave, you are greeted by skylight. You have successfully escaped from the ruins!";

            roomArray[21].name = "Debug Room";
            roomArray[21].desc = "";

            roomArray[22].name = "Right Room";
            roomArray[22].desc = "In the room there are a few ceremonial pots and a table with benches. There is nothing else here.";

            roomArray[23].name = "Left Room";
            if(KeyCollect == 0 && roomNum == 23)
            {
                roomArray[23].desc = "The left room has a coffin standing next to a table with benches. On the table you find a key, a sword, and armour. You pick it all up.\n" +
                "As you pick up the key, the coffin bursts open to reveal an animate, partially decomposed corpse! It draws its weapon. Time to fight!";
                KeyCollect = 1;
            }
            else
            {
                roomArray[23].desc = "You already collected the key from this room. You should try the door in the Dining Hall.";
            }

            eDamage[0] = 5;
            eDamage[1] = 6;
            eDamage[2] = 7;
            eDamage[3] = 8;
            eDamage[4] = 9;
            eDamage[5] = 10;
            Combat Corpse = new Combat(50, eDamage, 20, 1);
            enemyArray[0] = Corpse;
            enemyArray[0].enemyName = "Corpse";

            roomArray[24].name = "Bathtub Room - Northhwest";
            if(NorthWestLeverPulled == 0 && roomNum == 24)
            {
                roomArray[24].desc = "There is a lever here. You pull it. Water pours into the bathtub from the northwest pillar.";
                NorthWestLeverPulled = 1;
                if (SouthWestLeverPulled == 1 && SouthEastLeverPulled == 1 && NorthWestLeverPulled == 1 && NorthEastLeverPulled == 1)
                {
                    Console.WriteLine("As water comes out the last pillar, one of the pillars collapses into the bathtub and the bottom of the bathtub caves in.\n"
                        + "There is now a way forward.");
                }
            }
            else
            {
                roomArray[24].desc = "You have already pulled the lever here.";
            }

            roomArray[25].name = "Bathtub room - Northeast";
            if (NorthEastLeverPulled == 0 && roomNum == 25)
            {
                roomArray[25].desc = "There is a lever here. You pull it. Water pours into the bathtub from the northeast pillar.";
                NorthEastLeverPulled = 1;
                if (SouthWestLeverPulled == 1 && SouthEastLeverPulled == 1 && NorthWestLeverPulled == 1 && NorthEastLeverPulled == 1)
                {
                    Console.WriteLine("As water comes out the last pillar, one of the pillars collapses into the bathtub and the bottom of the bathtub caves in.\n"
                        + "There is now a way forward.");
                }
            }
            else
            {
                roomArray[25].desc = "You have already pulled the lever here.";
            }

            roomArray[26].name = "Bathtub room - West";
            roomArray[26].desc = "Further west there appears to be a blocked off passage.";

            roomArray[27].name = "Bathtub room - Center";
            if (SouthWestLeverPulled == 1 && SouthEastLeverPulled == 1 && NorthWestLeverPulled == 1 && NorthEastLeverPulled == 1 && roomNum == 27)
            {
                roomArray[27].desc = "The cave-in reveals a small underground cave, presumably the ruins' own water disposal.\n"
                    + "The cave-in completely covers one direction the cave went. The side you can go down is clearly the side the water goes down.\n"
                    + "You don't like this. Could you have just caused a back-up in the ruins water supply?\n"
                    + "If you go down into the cave, there will be no turning back. Go south to enter the cave.";
                roomArray[27].south = 6;
            }
            else
            {
                roomArray[27].desc = "This is the bathtub. The bottom of it seems like it has been worn over time.\n"
                + "Each pillar appears to be able to fill the bathtub. One of the pillars seems delicate as well.";
            }

            roomArray[28].name = "Bathtub room - East";
            roomArray[28].desc = "Right next to you now, there is a blocked off passage.";

            roomArray[29].name = "Bathtub room - SouthWest";
            if(SouthWestLeverPulled == 0 && roomNum == 29)
            {
                roomArray[29].desc = "There is a lever here. You pull it. Water pours into the bathtub from the southwest pillar.";
                SouthWestLeverPulled = 1;
                if (SouthWestLeverPulled == 1 && SouthEastLeverPulled == 1 && NorthWestLeverPulled == 1 && NorthEastLeverPulled == 1)
                {
                    Console.WriteLine("As water comes out the last pillar, one of the pillars collapses into the bathtub and the bottom of the bathtub caves in.\n"
                        + "There is now a way forward.");
                }
            }
            else
            {
                roomArray[29].desc = "You have already pulled the lever here.";
            }

            roomArray[30].name = "Bathtub room - South";
            roomArray[30].desc = "There is a large door here that rises up halfway to the ceiling. There seems to be no way of opening it, however.";

            roomArray[31].name = "Bathtub room - SouthEast";
            if(SouthEastLeverPulled == 0 && roomNum == 31)
            {
                roomArray[31].desc = "There is a lever here. You pull it. Water pours into the bathtub from the southeast pillar.";
                SouthEastLeverPulled = 1;
                if (SouthWestLeverPulled == 1 && SouthEastLeverPulled == 1 && NorthWestLeverPulled == 1 && NorthEastLeverPulled == 1)
                {
                    Console.WriteLine("As water comes out the last pillar, one of the pillars collapses into the bathtub and the bottom of the bathtub caves in.\n"
                        + "There is now a way forward.");
                }
            }
            else
            {
                roomArray[31].desc = "You have already pulled the lever here.";
            }

            roomArray[32].name = "Exit Drain";
            roomArray[32].desc = "Although the cave opens to the outside here, the water empties out into a steep cliff. You could not survive the fall.\n"
                + "There is a small alcove next to this exit. You lay there and ponder whether you will ever get out of here...";

            roomArray[33].name = "Well Room";
            if(WellKeyGet == 0 && WellDoorUnlocked == 0 && roomNum == 33)
            {
                roomArray[33].desc = "You step over the skeleton to find a large well surrounded by a gate. The entrance into the gate is locked.\n"
                    + "Around the gate of the well there are plenty of buckets. The amount of buckets is only exceeded by the sheer amount of skeletons. None of them look like they will reanimate.\n"
                    + "You are eager for drink that does not risk sickness or frostbite on the tongue, yet cautious due to all the skeletons around.\n"
                    + "You give in and take a sip but feel no ill effects, even after you drink increasing amounts.";
            }
            else if(WellKeyGet == 1 && WellDoorUnlocked == 0 && roomNum == 33)
            {
                roomArray[33].desc = "You have finally returned to the well. The water level is lower than you remember. Regardless, you unlock the gate and stand before the spiral staircase\n" 
                    + "leading into the well and into the water. Go south to enter the well, but know that this will be a one-way trip.";
                WellDoorUnlocked = 1;
                roomArray[33].south = 13;
            }
            else
            {
                roomArray[33].desc = "The door into the well is open. You enter the door and find out the water must be getting lower by the minute.\n"
                    + "Go south to enter the well, but know that this will be a one-way trip.";
                roomArray[33].south = 13;
            }
            

            roomArray[34].name = "Journal Room";
            if(JournalGet == 0 && roomNum == 34)
            {
                roomArray[34].desc = "There is a journal on the table here. You take it and remove the thick layers of dust from it. To read it, type 'Journal' when prompted for a direction to go.";
                JournalGet = 1;
            }
            else
            {
                roomArray[34].desc = "You alredy took the journal from here. To read it, type 'Journal' when prompted for a direction to go.";
            }

            roomArray[35].name = "Catwalk Room - Stairwell";
            roomArray[35].desc = "You come to the stairwell. You can go upstairs, downstairs, or go back the way you came from here.\n"
                + "West goes upstairs, east goes downstairs.";

            roomArray[36].name = "Catwalk Room - Ground Floor";
            roomArray[36].desc = "The bottom of this room is flooded up to your heels due to the waer from the middle catwalk. There are a few things in the water that turn out to be nothing.\n" +
                "You can go east to go back up the stairs.";

            roomArray[37].name = "Catwalk Room - Upper Catwalk";
            if(CatwalkKeyGet == 0 && roomNum == 37)
            {
                roomArray[37].desc = "You come to the upper catwalk. Ahead is a door. You can see the entire middle catwallk from here\n" +
                    "On one end of the middle catwalk, there is something in the water. You can jump down to the middle catwalk by going west or east.";
            }
            else
            {
                roomArray[37].desc = "You return to the upper catwalk. The key you found should be for the door ahead. There is nohing else on the middle catwalk.";
            }

            roomArray[38].name = "Catwalk Room - Middle Catwalk";
            if(CatwalkKeyGet == 0 && roomNum == 38)
            {
                roomArray[38].desc = "You drop down to the middle catwalk with a splash. You head over to where you saw that thing in the water. It urns out o be a key, but it does not\n" +
                    "look like it will fit in the well door. It must be for the door at the end of the upper catwalk. You can now jump to the lower catwalk by going north or south.\n" +
                    "You also realize that the overflowing was probably caused by the obstruction you created earlier.";
                CatwalkKeyGet = 1;
            }
            else
            {
                roomArray[38].desc = "You drop down to the middle catwalk with a splash. There is nothing else on this catwalk. North or south will take you to the lower catwalk.";
            }

            roomArray[39].name = "Vault Room";
            if(VaultEmpty == 0 && roomNum == 39)
            {
                roomArray[39].desc = "You seem to have found the treasures of the ruins. You quickly fill your pockets with all the riches in the room. You also change into some fancy-looking clothes\n" +
                    "in place of your soaking wet clothes. The clothes are definetely old, but are comfortable nontheless. These are riches like you never thought you would find in these ruins. You\n" +
                    "can't stop thinking about what you could buy with all this.";
            }
            else
            {
                roomArray[39].desc = "You have already looted this room. You might as well turn back.";
            }

            roomArray[40].name = "Statue";
            roomArray[40].desc = "As the battle continues you are forced to seek higher ground next to the statue. The gems in the statue shine with the colors of the rainbow. They seem to be loosening.";

            Console.WriteLine("You are more than a little lost.\n"
                + "You are traveling up a mountain in hopes that you can spot civilization when you come across what appears to be an ancient ruin.\n"
                + "You come closer and closer to its entrance, curious of what it is doing in the middle of nowhere.\n"
                + "Before you know it, you have wandred into the entrance of the ruin.\n"
                + "Before you can go back, the entrance caves in behind you.\n"
                + "Looks like the only way out is through...\n");

            while(input != "exit") //This is where the while loop starts
            {
                if(playerName == "")
                {
                    Console.WriteLine("What will you name your character?");
                    input = Console.ReadLine();
                    playerName = input;
                    Console.Clear();
                    if (input == "exit")
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine(roomArray[roomNum].name);
                    Console.WriteLine(roomArray[roomNum].desc);

                    if (LockedDoorOpen == 0 && roomNum == 2)
                    {
                        roomArray[2].desc = "The room ahead glows with the light of several chandeliers of some unknown making.\n"
                            + "You have come across a room with a long table lined with benches. There are three passageways, including the one you came from.\n"
                            + "To the South is a door.";
                    }
                    else
                    {
                        roomArray[2].desc = "The light sources inside the room show no sign of flickering out.\n"
                            + "There are now four passageways in each direction, but you doubt the way you entered is open. It would be best to continue South.";
                    }

                    if (LockedDoorOpen == 0 && KeyCollect == 0 && roomNum == 3)
                    {
                        roomArray[3].desc = "Obviously not in the door, but at the door. The door is locked, you should go find the key in another room.";
                    }
                    else if (LockedDoorOpen == 0 && KeyCollect == 1 && roomNum == 3)
                    {
                        roomArray[3].desc = "You unlock the door. You should head on through.";
                        roomArray[3].south = 4;
                        LockedDoorOpen = 1;
                    }
                    else
                    {
                        roomArray[3].desc = "The door is open. You should head through.";
                        roomArray[3].south = 4;
                    }

                    if (roomNum == 14 && TotemPuzzle == 0)
                    {
                        Console.WriteLine("\nWhich totem will you turn? To pull the chain and see if the door opens, type 'Chain'");
                    }
                    else if (roomNum == 17)
                    {
                        Console.WriteLine("\nWhich direction do you want to go? North, West, East, or South? Or would you like to make a potion instead?");
                    }
                    else if ((roomNum == 18 || roomNum == 40) && enemyArray[3].enemyAmount != 0)
                    {
                        Console.WriteLine("\nTime to fight! You can only attack or use a potion if you made one!");
                    }
                    else if (roomNum == 20)
                    {
                        Console.WriteLine("\nYou have completed the game! Type exit to quit.");
                    }
                    else if (roomNum == 23 && enemyArray[0].enemyAmount != 0)
                    {
                        Console.WriteLine("Time to fight! You can only attack!");
                    }
                    else
                    {
                        Console.WriteLine("\nWhich direction do you want to go, " + playerName + "? North, West, East, or South?");
                    }

                    input = Console.ReadLine();
                    Console.Clear();

                    if (input == "exit")
                    {
                        break;
                    }
                    if (roomNum == 14 && TotemPuzzle == 0)
                    {
                        Console.WriteLine("");
                        if (input == "Northwest Mouse")
                        {
                            Console.WriteLine("The northwest totem now shows a mouse");
                            NorthwestT = "mouse";
                        }
                        else if (input == "Northwest Snake")
                        {
                            Console.WriteLine("The northwest totem now shows a snake");
                            NorthwestT = "snake";
                        }
                        else if (input == "Northwest Hawk")
                        {
                            Console.WriteLine("The northwest totem now shows a hawk");
                            NorthwestT = "hawk";
                        }
                        else if (input == "Northeast Mouse")
                        {
                            Console.WriteLine("The northeast totem now shows a mouse");
                            NortheastT = "mouse";
                        }
                        else if (input == "Northeast Snake")
                        {
                            Console.WriteLine("The northeast totem now shows a snake");
                            NortheastT = "snake";
                        }
                        else if (input == "Northeast Hawk")
                        {
                            Console.WriteLine("The northeast totem now shows a hawk");
                            NortheastT = "hawk";
                        }
                        else if (input == "Southwest Snake")
                        {
                            Console.WriteLine("The southwest totem now shows a snake");
                            SouthwestT = "snake";
                        }
                        else if (input == "Southwest Mongoose")
                        {
                            Console.WriteLine("The southwest totem now shows a mongoose");
                            SouthwestT = "mongoose";
                        }
                        else if (input == "Southwest Fox")
                        {
                            Console.WriteLine("The southwest totem now shows a fox");
                            SouthwestT = "fox";
                        }
                        else if (input == "Southeast Snake")
                        {
                            Console.WriteLine("The southeast totem now shows a snake");
                            SoutheastT = "snake";
                        }
                        else if (input == "Southeast Mongoose")
                        {
                            Console.WriteLine("The southeast totem now shows a mongoose");
                            SoutheastT = "mongoose";
                        }
                        else if (input == "Southeast Fox")
                        {
                            Console.WriteLine("The southeast totem now shows a fox");
                            SoutheastT = "fox";
                        }
                        else if (input == "Chain")
                        {
                            if (NorthwestT == "mouse" && NortheastT == "hawk" && SouthwestT == "fox" && SoutheastT == "snake" && roomNum == 14)
                            {
                                Console.WriteLine("All the gates open. You can now proceed.");
                                TotemPuzzle = 1;
                            }
                            else
                            {
                                Console.WriteLine("That was not the correct solution. Try again.");
                            }
                        }
                        else if (input == "Journal" && JournalGet == 1)
                        {
                            Console.WriteLine("You skip a few entries in the book until you come to entries regarding this place.\n" +
                                "\n" +
                                "27th of November\n" +
                                "\n" +
                                "It seems impossible, but we appeared to have stumbled upon a stronghold of some demonic cult, who were believed to have been wiped out decades ago. The enemy army must wait,\n" +
                                "as this is a threat we cannot ignore. If we are quick, we may be able to catch the defenders off gaurd and avoid a legnthy siege.\n" +
                                "\n" +
                                "21st of December\n" +
                                "\n" +
                                "Third week of the seige. The men grow tired of the cold and all miss their families. Had it not been for tha blasted storm that sloweed our ascent we may have taken the\n" +
                                "courtyard sooner, but at this rate we will be pounding on their walls for several weeks or more.\n" +
                                "\n" +
                                "4th of January\n" +
                                "\n" +
                                "We finally brought down the main gate. The cultists have fallen back to the interior of the stronghold but we will soon breach those defenses. It cannot be soon enough, it's\n" +
                                "too bloody cold on this mountain.\n" +
                                "\n" +
                                "5th of January\n" +
                                "\n" +
                                "We entered the stronghold today only to find all inside dead. It seems they have purposely caved in the path to the other side of the burial chambers and then took their own\n" +
                                "lives. Some appear to have slit their wrists, while others were found with empty vials. Most appeared to have poisoned themselves, but oddly there are not as mny empty vials\n" +
                                "as one would have expected by the number of dead. We shall hold up here overnight rather than face the cold and explore the catacombs in the morning to see if we can find a\n" +
                                "passageway into the deeper parts of the stronghold.\n" +
                                "\n" +
                                "6th of January\n" +
                                "\n" +
                                "May the gods protect us from demons and madmen! We lost half our remaining men today! We discovered a well in the catacombs, unlocked and with several buckets already filled.\n" +
                                "In their excitement for a drink that did not risk frostbite on their tongues, four score drank before we could stop them. Gods only knows how these cultists couled use poison\n" +
                                "in their own water supply. We lost more men to this catastrophe than we did taking the courtyard.\n" +
                                "\n" +
                                "The door was locked from this side and the key must be somewhere in the catacombs, but with the bodies of these cultists coming back to life and the men becoming more and\n" +
                                "more demoralized, it just isn't worth the search. Let these gods-forsaken cultists drink their way to hell and be done with it. There was a cave at the base of the mountain\n" +
                                "that might be connected to this stronghold, but we cannot find any evidence of this other than a few ceremonial urns of similar making to those we found here.\n" +
                                "\n" +
                                "We leave this accursed place tommorow to regroup and push up north, but I will leave this journal. So, in an age or so when the poison has faded, someone can find a way in to\n" +
                                "be sure these cultists met their due fate.\n" +
                                "\n" +
                                "The rest of the pages are blank\n");
                        }
                        else if (input == "Tome" && TomeGet == 1)
                        {
                            Console.WriteLine("The first fears all\n" +
                                "The second fears none\n" +
                                "The third eats many things, preferably number one\n" +
                                "The fourth fears all, except number one\n" +
                                "\n" +
                                "All must be activated at once\n" +
                                "If you wish to go home");
                        }
                        else
                        {
                            Console.WriteLine("You either need to check your spelling, or you need to capitalize letters.");
                        }
                    }
                    else if (roomNum == 4 && enemyArray[1].enemyAmount != 0)
                    {
                        if (input == "Attack" || input == "attack")
                        {
                            accuracyCheck = accuracy[chance.Next(0, accuracy.Length)];
                            if (accuracyCheck == 1 || accuracyCheck == 2)
                            {
                                criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                if (criticalChance == 5)
                                {
                                    heroDamage = hCritical;
                                    Console.Clear();
                                    enemyArray[1].enemyHealth = enemyArray[1].enemyHealth - heroDamage;

                                    Console.WriteLine("Your attack was a critical hit!");
                                    if (enemyArray[1].enemyHealth < 0)
                                    {
                                        enemyArray[1].enemyHealth = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[1].enemyName + " now has " + enemyArray[1].enemyHealth + " health left.");
                                    }
                                }
                                else
                                {
                                    heroDamage = hDamage[chance.Next(0, hDamage.Length)];
                                    Console.Clear();
                                    enemyArray[1].enemyHealth = enemyArray[1].enemyHealth - heroDamage;

                                    if (enemyArray[1].enemyHealth < 0)
                                    {
                                        enemyArray[1].enemyHealth = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[1].enemyName + " now has " + enemyArray[1].enemyHealth + " health left.");
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Your attack missed!");
                            }

                            if (enemyArray[1].enemyHealth != 0)
                            {
                                if (accuracyCheck == 1 || accuracyCheck == 2)
                                {
                                    criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                    if (criticalChance == 5)
                                    {
                                        enemyDamage = enemyArray[1].enemyCritical;
                                        hLife = hLife - enemyDamage;

                                        Console.WriteLine("The " + enemyArray[1].enemyName + " landed a critical hit!");
                                        if (hLife < 0)
                                        {
                                            hLife = 0;
                                        }

                                        if (hLife != 0)
                                        {
                                            Console.WriteLine("You now have " + hLife + " health.");
                                        }
                                    }
                                    else
                                    {
                                        enemyDamage = enemyArray[1].enemyDamage[chance.Next(0, enemyArray[1].enemyDamage.Length)];
                                        if (FireResist == 1)
                                        {
                                            enemyDamage = enemyDamage / 2;
                                        }
                                        hLife = hLife - enemyDamage;

                                        Console.WriteLine("The " + enemyArray[1].enemyName + " attacks!");
                                        if (hLife < 0)
                                        {
                                            hLife = 0;
                                        }

                                        if (hLife != 0)
                                        {
                                            Console.WriteLine("You now have " + hLife + " health.");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The " + enemyArray[1].enemyName + "'s attack missed");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You cannot " + input + "!");
                        }

                        if (hLife == 0)
                        {
                            Console.WriteLine("The battle was lost...");
                            roomNum = 3;
                            hLife = 100;
                            Console.WriteLine("You have reverted back to the Main Hall, after you unlocked the door.");
                        }
                        else if (enemyArray[1].enemyHealth == 0)
                        {
                            enemyArray[1].enemyAmount = enemyArray[1].enemyAmount - 1;
                            if (enemyArray[1].enemyAmount != 0)
                            {
                                enemyArray[1].enemyHealth = 50;
                            }
                        }

                        if (enemyArray[1].enemyAmount == 0)
                        {
                            Console.WriteLine("The final corpse collapses to the ground. Thank goodness that's over...");
                            CorpseGroupDefeated = 1;
                            hLife = 100;
                        }
                    }
                    else if (roomNum == 12 && enemyArray[4].enemyAmount != 0)
                    {
                        if (input == "Attack" || input == "attack")
                        {
                            accuracyCheck = accuracy[chance.Next(0, accuracy.Length)];
                            if (accuracyCheck == 1 || accuracyCheck == 2)
                            {
                                criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                if (criticalChance == 5)
                                {
                                    heroDamage = hCritical;
                                    Console.Clear();
                                    enemyArray[4].enemyHealth = enemyArray[4].enemyHealth - heroDamage;

                                    Console.WriteLine("Your attack was a critical hit!");
                                    if (enemyArray[4].enemyHealth < 0)
                                    {
                                        enemyArray[4].enemyHealth = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[4].enemyName + " now has " + enemyArray[4].enemyHealth + " health left.");
                                    }
                                }
                                else
                                {
                                    heroDamage = hDamage[chance.Next(0, hDamage.Length)];
                                    Console.Clear();
                                    enemyArray[4].enemyHealth = enemyArray[4].enemyHealth - heroDamage;

                                    if (enemyArray[4].enemyHealth < 0)
                                    {
                                        enemyArray[4].enemyHealth = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[4].enemyName + " now has " + enemyArray[4].enemyHealth + " health left.");
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Your attack missed!");
                            }

                            if (enemyArray[4].enemyHealth != 0)
                            {
                                if (accuracyCheck == 1 || accuracyCheck == 2)
                                {
                                    criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                    if (criticalChance == 5)
                                    {
                                        enemyDamage = enemyArray[4].enemyCritical;
                                        hLife = hLife - enemyDamage;

                                        Console.WriteLine("The " + enemyArray[4].enemyName + " landed a critical hit!");
                                        if (hLife < 0)
                                        {
                                            hLife = 0;
                                        }

                                        if (hLife != 0)
                                        {
                                            Console.WriteLine("You now have " + hLife + " health.");
                                        }
                                    }
                                    else
                                    {
                                        enemyDamage = enemyArray[4].enemyDamage[chance.Next(0, enemyArray[4].enemyDamage.Length)];
                                        if (FireResist == 1)
                                        {
                                            enemyDamage = enemyDamage / 2;
                                        }
                                        hLife = hLife - enemyDamage;

                                        Console.WriteLine("The " + enemyArray[4].enemyName + " attacks!");
                                        if (hLife < 0)
                                        {
                                            hLife = 0;
                                        }

                                        if (hLife != 0)
                                        {
                                            Console.WriteLine("You now have " + hLife + " health.");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The " + enemyArray[4].enemyName + "'s attack missed");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You cannot " + input + "!");
                        }

                        if (hLife == 0)
                        {
                            Console.WriteLine("The battle was lost...");
                            roomNum = 37;
                            hLife = 100;
                            Console.WriteLine("You have reverted back to the Upper Catwalk, after you unlocked the door.");
                            WellKeyGet = 0;
                        }
                        else if (enemyArray[4].enemyHealth == 0)
                        {
                            enemyArray[4].enemyAmount = enemyArray[4].enemyAmount - 1;
                            if (enemyArray[4].enemyAmount != 0)
                            {
                                enemyArray[4].enemyHealth = 50;
                            }
                        }

                        if (enemyArray[4].enemyAmount == 0)
                        {
                            Console.WriteLine("The last walking corpse falls to the ground. You need a break after that one!");
                            WellKeyGet = 1;
                            hLife = 100;
                        }
                    }
                    else if (roomNum == 13 && enemyArray[2].enemyAmount != 0)
                    {
                        if (input == "Attack" || input == "attack")
                        {
                            accuracyCheck = accuracy[chance.Next(0, accuracy.Length)];
                            if (accuracyCheck == 1 || accuracyCheck == 2)
                            {
                                criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                if (criticalChance == 5)
                                {
                                    heroDamage = hCritical;
                                    Console.Clear();
                                    enemyArray[2].enemyHealth = enemyArray[2].enemyHealth - heroDamage;

                                    Console.WriteLine("Your attack was a critical hit!");
                                    if (enemyArray[2].enemyHealth < 0)
                                    {
                                        enemyArray[2].enemyHealth = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[2].enemyName + " now has " + enemyArray[2].enemyHealth + " health left.");
                                    }
                                }
                                else
                                {
                                    heroDamage = hDamage[chance.Next(0, hDamage.Length)];
                                    Console.Clear();
                                    enemyArray[2].enemyHealth = enemyArray[2].enemyHealth - heroDamage;

                                    if (enemyArray[2].enemyHealth < 0)
                                    {
                                        enemyArray[2].enemyHealth = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[2].enemyName + " now has " + enemyArray[2].enemyHealth + " health left.");
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Your attack missed!");
                            }

                            if (enemyArray[2].enemyHealth != 0)
                            {
                                if (accuracyCheck == 1 || accuracyCheck == 2)
                                {
                                    criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                    if (criticalChance == 5)
                                    {
                                        enemyDamage = enemyArray[2].enemyCritical;
                                        hLife = hLife - enemyDamage;

                                        Console.WriteLine("The " + enemyArray[2].enemyName + " landed a critical hit!");
                                        if (hLife < 0)
                                        {
                                            hLife = 0;
                                        }

                                        if (hLife != 0)
                                        {
                                            Console.WriteLine("You now have " + hLife + " health.");
                                        }
                                    }
                                    else
                                    {
                                        enemyDamage = enemyArray[2].enemyDamage[chance.Next(0, enemyArray[2].enemyDamage.Length)];
                                        if (FireResist == 1)
                                        {
                                            enemyDamage = enemyDamage / 2;
                                        }
                                        hLife = hLife - enemyDamage;

                                        Console.WriteLine("The " + enemyArray[2].enemyName + " attacks!");
                                        if (hLife < 0)
                                        {
                                            hLife = 0;
                                        }

                                        if (hLife != 0)
                                        {
                                            Console.WriteLine("You now have " + hLife + " health.");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The " + enemyArray[2].enemyName + "'s attack missed");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You cannot " + input + "!");
                        }

                        if (hLife == 0)
                        {
                            Console.WriteLine("The battle was lost...");
                            roomNum = 33;
                            hLife = 100;
                            Console.WriteLine("You have reverted back to the Well, after you collected the well key.");
                        }
                        else if (enemyArray[2].enemyHealth == 0)
                        {
                            enemyArray[2].enemyAmount = enemyArray[2].enemyAmount - 1;
                            if (enemyArray[2].enemyAmount != 0)
                            {
                                enemyArray[2].enemyHealth = 50;
                            }
                        }

                        if (enemyArray[2].enemyAmount == 0)
                        {
                            Console.WriteLine("The final corpse collapses to the ground. Now maybe you can catch a break!");
                            CorpseGroup2Defeated = 1;
                            hLife = 100;
                        }
                    }
                    else if (roomNum == 17 && DeathbellPoison == 0 && PinkFlowerPotion == 0 && RedBerriesPotion == 0)
                    {
                        if (input == "Purple flowers")
                        {
                            Console.WriteLine("You make a potion from the purple and black flowers. You can now use this potion during combat by typing 'Purple potion'.");
                            DeathbellPoison = 1;
                        }
                        else if (input == "Pink flowers")
                        {
                            Console.WriteLine("You make a potion from the pink flowers. You can now use this potion during combat by typing 'Pink potion'.");
                            PinkFlowerPotion = 1;
                        }
                        else if (input == "Red berries")
                        {
                            Console.WriteLine("You make a potion from the red berries. You can now use this potion during combat by typing 'Red potion'.");
                            RedBerriesPotion = 1;
                        }
                        else if ((input == "north" || input == "North" || input == "n" || input == "N") && roomArray[roomNum].north > -1)
                        {
                            roomNum = roomArray[roomNum].north;
                        }
                        else if ((input == "west" || input == "West" || input == "w" || input == "W") && roomArray[roomNum].west > -1)
                        {
                            roomNum = roomArray[roomNum].west;
                        }
                        else if ((input == "east" || input == "East" || input == "e" || input == "E") && roomArray[roomNum].east > -1)
                        {
                            roomNum = roomArray[roomNum].east;
                        }
                        else if ((input == "south" || input == "South" || input == "s" || input == "S") && roomArray[roomNum].south > -1)
                        {
                            roomNum = roomArray[roomNum].south;
                        }
                        else if (input == "Journal" && JournalGet == 1)
                        {
                            Console.WriteLine("You skip a few entries in the book until you come to entries regarding this place.\n" +
                                "\n" +
                                "27th of November\n" +
                                "\n" +
                                "It seems impossible, but we appeared to have stumbled upon a stronghold of some demonic cult, who were believed to have been wiped out decades ago. The enemy army must wait,\n" +
                                "as this is a threat we cannot ignore. If we are quick, we may be able to catch the defenders off gaurd and avoid a legnthy siege.\n" +
                                "\n" +
                                "21st of December\n" +
                                "\n" +
                                "Third week of the seige. The men grow tired of the cold and all miss their families. Had it not been for tha blasted storm that sloweed our ascent we may have taken the\n" +
                                "courtyard sooner, but at this rate we will be pounding on their walls for several weeks or more.\n" +
                                "\n" +
                                "4th of January\n" +
                                "\n" +
                                "We finally brought down the main gate. The cultists have fallen back to the interior of the stronghold but we will soon breach those defenses. It cannot be soon enough, it's\n" +
                                "too bloody cold on this mountain.\n" +
                                "\n" +
                                "5th of January\n" +
                                "\n" +
                                "We entered the stronghold today only to find all inside dead. It seems they have purposely caved in the path to the other side of the burial chambers and then took their own\n" +
                                "lives. Some appear to have slit their wrists, while others were found with empty vials. Most appeared to have poisoned themselves, but oddly there are not as mny empty vials\n" +
                                "as one would have expected by the number of dead. We shall hold up here overnight rather than face the cold and explore the catacombs in the morning to see if we can find a\n" +
                                "passageway into the deeper parts of the stronghold.\n" +
                                "\n" +
                                "6th of January\n" +
                                "\n" +
                                "May the gods protect us from demons and madmen! We lost half our remaining men today! We discovered a well in the catacombs, unlocked and with several buckets already filled.\n" +
                                "In their excitement for a drink that did not risk frostbite on their tongues, four score drank before we could stop them. Gods only knows how these cultists couled use poison\n" +
                                "in their own water supply. We lost more men to this catastrophe than we did taking the courtyard.\n" +
                                "\n" +
                                "The door was locked from this side and the key must be somewhere in the catacombs, but with the bodies of these cultists coming back to life and the men becoming more and\n" +
                                "more demoralized, it just isn't worth the search. Let these gods-forsaken cultists drink their way to hell and be done with it. There was a cave at the base of the mountain\n" +
                                "that might be connected to this stronghold, but we cannot find any evidence of this other than a few ceremonial urns of similar making to those we found here.\n" +
                                "\n" +
                                "We leave this accursed place tommorow to regroup and push up north, but I will leave this journal. So, in an age or so when the poison has faded, someone can find a way in to\n" +
                                "be sure these cultists met their due fate.\n" +
                                "\n" +
                                "The rest of the pages are blank\n");
                        }
                        else if (input == "Tome" && TomeGet == 1)
                        {
                            Console.WriteLine("The first fears all\n" +
                                "The second fears none\n" +
                                "The third eats many things, preferably number one\n" +
                                "The fourth fears all, except number one\n" +
                                "\n" +
                                "All must be activated at once\n" +
                                "If you wish to go home");
                        }
                        else
                        {
                            Console.WriteLine("You either need to check your spelling, or you need to capitalize letters.");
                        }
                    }
                    else if (roomNum == 18 && enemyArray[3].enemyAmount != 0)
                    {
                        Console.WriteLine("If you made a potion in the previous room, you can use it here.");
                        if (flood <= 10)
                        {
                            if (input == "Attack" || input == "attack")
                            {
                                accuracyCheck = accuracy[chance.Next(0, accuracy.Length)];
                                if (accuracyCheck == 1 || accuracyCheck == 2)
                                {
                                    criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                    if (criticalChance == 5)
                                    {
                                        heroDamage = hCritical;
                                        Console.Clear();
                                        enemyArray[3].enemyHealth = enemyArray[3].enemyHealth - heroDamage;

                                        Console.WriteLine("Your attack was a critical hit!");
                                        if (enemyArray[3].enemyHealth < 0)
                                        {
                                            enemyArray[3].enemyHealth = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine("The " + enemyArray[3].enemyName + " now has " + enemyArray[3].enemyHealth + " health left.");
                                        }
                                    }
                                    else
                                    {
                                        heroDamage = hDamage[chance.Next(0, hDamage.Length)];
                                        Console.Clear();
                                        enemyArray[3].enemyHealth = enemyArray[3].enemyHealth - heroDamage;

                                        if (enemyArray[3].enemyHealth < 0)
                                        {
                                            enemyArray[3].enemyHealth = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine("The " + enemyArray[3].enemyName + " now has " + enemyArray[3].enemyHealth + " health left.");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Your attack missed!");
                                }

                                if (enemyArray[3].enemyHealth != 0)
                                {
                                    if (accuracyCheck == 1 || accuracyCheck == 2)
                                    {
                                        criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                        if (criticalChance == 5)
                                        {
                                            enemyDamage = enemyArray[3].enemyCritical;
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " landed a critical hit!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                        else
                                        {
                                            enemyDamage = enemyArray[3].enemyDamage[chance.Next(0, enemyArray[3].enemyDamage.Length)];
                                            if (FireResist == 1)
                                            {
                                                enemyDamage = enemyDamage / 2;
                                            }
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " attacks with a fire spell from its staff!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[3].enemyName + "'s attack missed");
                                    }
                                }
                            }
                            else if (input == "Purple potion" && DeathbellPoison == 1)
                            {
                                hLife = hLife - 60;
                                Console.WriteLine("You made a big mistake. The purple and black flowers were poisonous.");
                                DeathbellPoison = 0;
                                if (hLife < 0)
                                {
                                    hLife = 0;
                                }

                                if (hLife != 0)
                                {
                                    Console.WriteLine("The poison does not kill you, but it drains 60 health");
                                }

                                if (enemyArray[3].enemyHealth != 0)
                                {
                                    if (accuracyCheck == 1 || accuracyCheck == 2)
                                    {
                                        criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                        if (criticalChance == 5)
                                        {
                                            enemyDamage = enemyArray[3].enemyCritical;
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " landed a critical hit!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                        else
                                        {
                                            enemyDamage = enemyArray[3].enemyDamage[chance.Next(0, enemyArray[3].enemyDamage.Length)];
                                            if (FireResist == 1)
                                            {
                                                enemyDamage = enemyDamage / 2;
                                            }
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " attacks with a fire spell from its staff!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[3].enemyName + "'s attack missed");
                                    }
                                }
                            }
                            else if (input == "Pink potion" && PinkFlowerPotion == 1)
                            {
                                hLife = hLife + 60;
                                Console.WriteLine("You have made a good choice in brewing ingredients. The potion heals you for 60 points. You now have " + hLife + " health.");
                                PinkFlowerPotion = 0;

                                if (enemyArray[3].enemyHealth != 0)
                                {
                                    if (accuracyCheck == 1 || accuracyCheck == 2)
                                    {
                                        criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                        if (criticalChance == 5)
                                        {
                                            enemyDamage = enemyArray[3].enemyCritical;
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " landed a critical hit!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                        else
                                        {
                                            enemyDamage = enemyArray[3].enemyDamage[chance.Next(0, enemyArray[3].enemyDamage.Length)];
                                            if (FireResist == 1)
                                            {
                                                enemyDamage = enemyDamage / 2;
                                            }
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " attacks with a fire spell from its staff!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[3].enemyName + "'s attack missed");
                                    }
                                }
                            }
                            else if (input == "Red potion" && RedBerriesPotion == 1)
                            {
                                FireResist = 1;
                                Console.WriteLine("The potion gives you resistance to magic. Good thing that's what you enemy is using!");
                                RedBerriesPotion = 0;

                                if (enemyArray[3].enemyHealth != 0)
                                {
                                    if (accuracyCheck == 1 || accuracyCheck == 2)
                                    {
                                        criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                        if (criticalChance == 5)
                                        {
                                            enemyDamage = enemyArray[3].enemyCritical;
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " landed a critical hit!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                        else
                                        {
                                            enemyDamage = enemyArray[3].enemyDamage[chance.Next(0, enemyArray[3].enemyDamage.Length)];
                                            if (FireResist == 1)
                                            {
                                                enemyDamage = enemyDamage / 2;
                                            }
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " attacks with a fire spell from its staff!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[3].enemyName + "'s attack missed");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("You cannot " + input + "!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You no longer have a solid surface to stand on. You flail your sword where the Preist is hovering but he easily avoids your attacks. With nowhere to run and the\n" +
                                "Preist showing no mercy, the battle was soon lost...");
                            hLife = 0;
                        }

                        if (hLife == 0)
                        {
                            Console.WriteLine("The battle was lost...");
                            roomNum = 17;
                            hLife = 100;
                            Console.WriteLine("You have reverted back to the Alchemy room, before you made any potions.");
                            DeathbellPoison = 0;
                            PinkFlowerPotion = 0;
                            RedBerriesPotion = 0;
                        }
                        else if (enemyArray[3].enemyHealth == 0)
                        {
                            enemyArray[3].enemyAmount = enemyArray[3].enemyAmount - 1;
                        }

                        if (enemyArray[3].enemyAmount == 0)
                        {
                            Console.WriteLine("With one last cry, the Preist's body dissolves to ashes. Now you just need to find a way out of here!");
                            hLife = 100;
                        }

                        if (hLife > 0)
                        {
                            flood = flood + 1;
                        }
                        if (flood == 4)
                        {
                            Console.WriteLine("The rising water has forced you up to the statue");
                            roomNum = 40;
                        }
                    }
                    else if (roomNum == 23 && enemyArray[0].enemyAmount != 0)
                    {
                        if (input == "Attack" || input == "attack")
                        {
                            accuracyCheck = accuracy[chance.Next(0, accuracy.Length)];
                            if (accuracyCheck == 1 || accuracyCheck == 2)
                            {
                                criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                if (criticalChance == 5)
                                {
                                    heroDamage = hCritical;
                                    Console.Clear();
                                    enemyArray[0].enemyHealth = enemyArray[0].enemyHealth - heroDamage;

                                    Console.WriteLine("Your attack was a critical hit!");
                                    if (enemyArray[0].enemyHealth < 0)
                                    {
                                        enemyArray[0].enemyHealth = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[0].enemyName + " now has " + enemyArray[0].enemyHealth + " health left.");
                                    }
                                }
                                else
                                {
                                    heroDamage = hDamage[chance.Next(0, hDamage.Length)];
                                    Console.Clear();
                                    enemyArray[0].enemyHealth = enemyArray[0].enemyHealth - heroDamage;

                                    if (enemyArray[0].enemyHealth < 0)
                                    {
                                        enemyArray[0].enemyHealth = 0;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[0].enemyName + " now has " + enemyArray[0].enemyHealth + " health left.");
                                    }
                                }
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Your attack missed!");
                            }

                            if (enemyArray[0].enemyHealth != 0)
                            {
                                if (accuracyCheck == 1 || accuracyCheck == 2)
                                {
                                    criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                    if (criticalChance == 5)
                                    {
                                        enemyDamage = enemyArray[0].enemyCritical;
                                        hLife = hLife - enemyDamage;

                                        Console.WriteLine("The " + enemyArray[0].enemyName + " landed a critical hit!");
                                        if (hLife < 0)
                                        {
                                            hLife = 0;
                                        }

                                        if (hLife != 0)
                                        {
                                            Console.WriteLine("You now have " + hLife + " health.");
                                        }
                                    }
                                    else
                                    {
                                        enemyDamage = enemyArray[0].enemyDamage[chance.Next(0, enemyArray[0].enemyDamage.Length)];
                                        if (FireResist == 1)
                                        {
                                            enemyDamage = enemyDamage / 2;
                                        }
                                        hLife = hLife - enemyDamage;

                                        Console.WriteLine("The " + enemyArray[0].enemyName + " attacks!");
                                        if (hLife < 0)
                                        {
                                            hLife = 0;
                                        }

                                        if (hLife != 0)
                                        {
                                            Console.WriteLine("You now have " + hLife + " health.");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("The " + enemyArray[0].enemyName + "'s attack missed");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("You cannot " + input + "!");
                        }

                        if (hLife == 0)
                        {
                            Console.WriteLine("The battle was lost...");
                            roomNum = 0;
                            hLife = 100;
                            Console.WriteLine("You have reverted back to the Entrance.");
                            KeyCollect = 0;
                        }
                        else if (enemyArray[0].enemyHealth == 0)
                        {
                            enemyArray[0].enemyAmount = enemyArray[0].enemyAmount - 1;
                        }

                        if (enemyArray[0].enemyAmount == 0)
                        {
                            Console.WriteLine("The corpse collapses to the ground. You hope you won't have to deal with one of those again, but somehow you think you will.");
                            KeyCollect = 1;
                            hLife = 100;
                        }
                    }
                    else if (roomNum == 40 && enemyArray[3].enemyAmount != 0)
                    {
                        if (flood <= 10)
                        {
                            if (input == "Attack" || input == "attack")
                            {
                                accuracyCheck = accuracy[chance.Next(0, accuracy.Length)];
                                if (accuracyCheck == 1 || accuracyCheck == 2)
                                {
                                    criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                    if (criticalChance == 5)
                                    {
                                        heroDamage = hCritical;
                                        Console.Clear();
                                        enemyArray[3].enemyHealth = enemyArray[3].enemyHealth - heroDamage;

                                        Console.WriteLine("Your attack was a critical hit!");
                                        if (enemyArray[3].enemyHealth < 0)
                                        {
                                            enemyArray[3].enemyHealth = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine("The " + enemyArray[3].enemyName + " now has " + enemyArray[3].enemyHealth + " health left.");
                                        }
                                    }
                                    else
                                    {
                                        heroDamage = hDamage[chance.Next(0, hDamage.Length)];
                                        Console.Clear();
                                        enemyArray[3].enemyHealth = enemyArray[3].enemyHealth - heroDamage;

                                        if (enemyArray[3].enemyHealth < 0)
                                        {
                                            enemyArray[3].enemyHealth = 0;
                                        }
                                        else
                                        {
                                            Console.WriteLine("The " + enemyArray[3].enemyName + " now has " + enemyArray[3].enemyHealth + " health left.");
                                        }
                                    }
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Your attack missed!");
                                }

                                if (enemyArray[3].enemyHealth != 0)
                                {
                                    if (accuracyCheck == 1 || accuracyCheck == 2)
                                    {
                                        criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                        if (criticalChance == 5)
                                        {
                                            enemyDamage = enemyArray[3].enemyCritical;
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " landed a critical hit!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                        else
                                        {
                                            enemyDamage = enemyArray[3].enemyDamage[chance.Next(0, enemyArray[3].enemyDamage.Length)];
                                            if (FireResist == 1)
                                            {
                                                enemyDamage = enemyDamage / 2;
                                            }
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " attacks with a fire spell from its staff!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[3].enemyName + "'s attack missed");
                                    }
                                }
                            }
                            else if (input == "Purple potion" && DeathbellPoison == 1)
                            {
                                hLife = hLife - 60;
                                Console.WriteLine("You made a big mistake. The purple and black flowers were poisonous.");
                                DeathbellPoison = 0;
                                if (hLife < 0)
                                {
                                    hLife = 0;
                                }

                                if (hLife != 0)
                                {
                                    Console.WriteLine("The poison does not kill you, but it drains 60 health");
                                }

                                if (enemyArray[3].enemyHealth != 0)
                                {
                                    if (accuracyCheck == 1 || accuracyCheck == 2)
                                    {
                                        criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                        if (criticalChance == 5)
                                        {
                                            enemyDamage = enemyArray[3].enemyCritical;
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " landed a critical hit!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                        else
                                        {
                                            enemyDamage = enemyArray[3].enemyDamage[chance.Next(0, enemyArray[3].enemyDamage.Length)];
                                            if (FireResist == 1)
                                            {
                                                enemyDamage = enemyDamage / 2;
                                            }
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " attacks with a fire spell from its staff!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[3].enemyName + "'s attack missed");
                                    }
                                }
                            }
                            else if (input == "Pink potion" && PinkFlowerPotion == 1)
                            {
                                hLife = hLife + 60;
                                Console.WriteLine("You have made a good choice in brewing ingredients. The potion heals you for 60 points. You now have " + hLife + " health.");
                                PinkFlowerPotion = 0;

                                if (enemyArray[3].enemyHealth != 0)
                                {
                                    if (accuracyCheck == 1 || accuracyCheck == 2)
                                    {
                                        criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                        if (criticalChance == 5)
                                        {
                                            enemyDamage = enemyArray[3].enemyCritical;
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " landed a critical hit!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                        else
                                        {
                                            enemyDamage = enemyArray[3].enemyDamage[chance.Next(0, enemyArray[3].enemyDamage.Length)];
                                            if (FireResist == 1)
                                            {
                                                enemyDamage = enemyDamage / 2;
                                            }
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " attacks with a fire spell from its staff!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[3].enemyName + "'s attack missed");
                                    }
                                }
                            }
                            else if (input == "Red potion" && RedBerriesPotion == 1)
                            {
                                FireResist = 1;
                                Console.WriteLine("The potion gives you resistance to magic. Good thing that's what you enemy is using!");
                                RedBerriesPotion = 0;

                                if (enemyArray[3].enemyHealth != 0)
                                {
                                    if (accuracyCheck == 1 || accuracyCheck == 2)
                                    {
                                        criticalChance = criticalHit[chance.Next(0, criticalHit.Length)];
                                        if (criticalChance == 5)
                                        {
                                            enemyDamage = enemyArray[3].enemyCritical;
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " landed a critical hit!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                        else
                                        {
                                            enemyDamage = enemyArray[3].enemyDamage[chance.Next(0, enemyArray[3].enemyDamage.Length)];
                                            if (FireResist == 1)
                                            {
                                                enemyDamage = enemyDamage / 2;
                                            }
                                            hLife = hLife - enemyDamage;

                                            Console.WriteLine("The " + enemyArray[3].enemyName + " attacks with a fire spell from its staff!");
                                            if (hLife < 0)
                                            {
                                                hLife = 0;
                                            }

                                            if (hLife != 0)
                                            {
                                                Console.WriteLine("You now have " + hLife + " health.");
                                            }
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("The " + enemyArray[3].enemyName + "'s attack missed");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("You cannot " + input + "!");
                            }
                        }
                        else
                        {
                            Console.WriteLine("You no longer have a solid surface to stand on. You flail your sword where the Preist is hovering but he easily avoids your attacks. With nowhere to run and the\n" +
                                "Preist showing no mercy, the battle was soon lost...");
                            hLife = 0;
                        }

                        if (hLife == 0)
                        {
                            Console.WriteLine("The battle was lost...");
                            roomNum = 17;
                            hLife = 100;
                            Console.WriteLine("You have reverted back to the Alchemy room, before you made any potions.");
                            DeathbellPoison = 0;
                            PinkFlowerPotion = 0;
                            RedBerriesPotion = 0;
                        }
                        else if (enemyArray[3].enemyHealth == 0)
                        {
                            enemyArray[3].enemyAmount = enemyArray[3].enemyAmount - 1;
                        }

                        if (enemyArray[3].enemyAmount == 0)
                        {
                            Console.WriteLine("With one last cry, the Preist's body dissolves to ashes. Now you just need to find a way out of here!");
                            hLife = 100;
                        }

                        if (hLife > 0)
                        {
                            flood = flood + 1;
                        }
                        else if (flood == 6)
                        {
                            Console.WriteLine("The roof collapses above the head of the statue and water comes pouring out. The debris and water causes the gems in the eyes to finally come out.\n" +
                                "They fall to the lower level. You should get them after this is over.");
                        }
                        else if (flood == 10)
                        {
                            Console.WriteLine("This is your last turn on a solid surface! If the water gets any higher you will be unable to attack!");
                        }
                    }
                    else if (roomNum == 40 && enemyArray[3].enemyAmount == 0)
                    {
                        Console.WriteLine("The water is still rising! The only place to look for an escape route now is the ceiling! You can now go North, Northwest, Northeast, West, East, Southwest\n" +
                            "Southeast, and South. You could also try getting the gems if you have not already by typing 'Gems', but the water won't be stopping in the meantime!");

                        if (input == "west" || input == "West" || input == "w" || input == "W")
                        {
                            if (flood < 12)
                            {
                                Console.WriteLine("You have found the exit! You will just need to wait until he water is high enough now!");
                            }
                            else
                            {
                                Console.WriteLine("You have found the exit!");
                                roomNum = 19;
                            }
                        }
                        else if (input == "north" || input == "North" || input == "n" || input == "N")
                        {
                            Console.WriteLine("The exit is not there!");
                        }
                        else if (input == "northwest" || input == "Northwest" || input == "nw" || input == "NW")
                        {
                            Console.WriteLine("The exit is not there!");
                        }
                        else if (input == "northeast" || input == "Northeast" || input == "ne" || input == "NE")
                        {
                            Console.WriteLine("The exit is not there!");
                        }
                        else if (input == "east" || input == "East" || input == "e" || input == "E")
                        {
                            Console.WriteLine("The exit is not there!");
                        }
                        else if (input == "south" || input == "South" || input == "s" || input == "S")
                        {
                            Console.WriteLine("The exit is not there!");
                        }
                        else if (input == "southwest" || input == "Southwest" || input == "sw" || input == "SW")
                        {
                            Console.WriteLine("The exit is not there!");
                        }
                        else if (input == "southeast" || input == "Southeast" || input == "se" || input == "SE")
                        {
                            Console.WriteLine("The exit is not there!");
                        }
                        else if (input == "Gems")
                        {
                            Console.WriteLine("You swim down to the bottom to get the gems. It takes some effort but you manage to carry them back to the surface.");
                            GemGet = 1;
                        }
                        else if (input == "Journal" && JournalGet == 1)
                        {
                            Console.WriteLine("Now isn't the best time to read anything!");
                        }
                        else if (input == "Tome" && TomeGet == 1)
                        {
                            Console.WriteLine("Now isn't the best time to read anything!");
                        }
                        else
                        {
                            Console.WriteLine("You cannot " + input + "! Don't fool around!");
                        }

                        flood = flood + 1;
                        if (flood == 6)
                        {
                            Console.WriteLine("The roof collapses above the head of the statue and water comes pouring out. The debris and water causes the gems in the eyes to finally come out.\n" +
                                "They fall to the lower level.");
                        }
                        else if (flood == 10)
                        {
                            Console.WriteLine("You are now standing on the last bit of solid ground that you can! No worries, since the battle is over, but you need to find the exit!");
                        }
                        else if (flood == 12)
                        {
                            Console.WriteLine("The water has now completely enveloped the room. You can now go to the exit if you have found it. If you have not, then you shoould still be able to\n" +
                                "breathe underwater for 2 more attempts at finding the exit.");
                        }
                        else if (flood == 14)
                        {
                            Console.WriteLine("You are running out of air! This is you last chance to find the exit!");
                        }

                        if (flood == 15 && (input != "west" || input != "West" || input != "w" || input != "W"))
                        {
                            Console.WriteLine("You have drowned...");
                            roomNum = 17;
                            hLife = 100;
                            Console.WriteLine("You have reverted back to the Alchemy room, before you made any potions.");
                            DeathbellPoison = 0;
                            PinkFlowerPotion = 0;
                            RedBerriesPotion = 0;
                        }
                    }
                    else if (roomNum == 20)
                    {
                        if (VaultEmpty == 1 && GemGet == 0)
                        {
                            Console.WriteLine("What you got in the vualt will buy you a lot! It's a shame you could not get those large gems in that flooding room, but you still have a lot!");
                        }
                        else if (VaultEmpty == 0 && GemGet == 1)
                        {
                            Console.WriteLine("You may have missed the vault room, but each gem you collected is worth more than everything in there!");
                        }
                        else if (VaultEmpty == 1 && GemGet == 1)
                        {
                            Console.WriteLine("You collected everything you could find in there! Each gem is, of course, more valuable than what you found in the vault room!");
                        }
                        else
                        {
                            Console.WriteLine("While you did escape safely, you did not collect any of the loot that was in there...");
                        }

                        if (input == "Journal" && JournalGet == 1)
                        {
                            Console.WriteLine("You skip a few entries in the book until you come to entries regarding this place.\n" +
                                "\n" +
                                "27th of November\n" +
                                "\n" +
                                "It seems impossible, but we appeared to have stumbled upon a stronghold of some demonic cult, who were believed to have been wiped out decades ago. The enemy army must wait,\n" +
                                "as this is a threat we cannot ignore. If we are quick, we may be able to catch the defenders off gaurd and avoid a legnthy siege.\n" +
                                "\n" +
                                "21st of December\n" +
                                "\n" +
                                "Third week of the seige. The men grow tired of the cold and all miss their families. Had it not been for tha blasted storm that sloweed our ascent we may have taken the\n" +
                                "courtyard sooner, but at this rate we will be pounding on their walls for several weeks or more.\n" +
                                "\n" +
                                "4th of January\n" +
                                "\n" +
                                "We finally brought down the main gate. The cultists have fallen back to the interior of the stronghold but we will soon breach those defenses. It cannot be soon enough, it's\n" +
                                "too bloody cold on this mountain.\n" +
                                "\n" +
                                "5th of January\n" +
                                "\n" +
                                "We entered the stronghold today only to find all inside dead. It seems they have purposely caved in the path to the other side of the burial chambers and then took their own\n" +
                                "lives. Some appear to have slit heir wrists, while others were found with empty vials. Most appeared to have poisoned themselves, but oddly there are not as mny empty vials\n" +
                                "as one would have expected by the number of dead. We shall hold up here overnight rather than face the cold and explore the catacombs in the morning to see if we can find a\n" +
                                "passageway into the deeper parts of the stronghold.\n" +
                                "\n" +
                                "6th of January\n" +
                                "\n" +
                                "May the gods protect us from demons and madmen! We lost half our remaining men today! We discovered a well in the catacombs, unlocked and with several buckets already filled.\n" +
                                "In their excitement for a drink that did not risk frostbite on their tongues, four score drank before we could stop them. Gods only knows how these cultists couled use poison\n" +
                                "in their own water supply. We lost more men to this catastrophe than we did taking the courtyard.\n" +
                                "\n" +
                                "The door was locked from this side and the key must be somewhere in the catacombs, but with the bodies of these cultists coming back to life and the men becoming more and\n" +
                                "more demoralized, it just isn't worth the search. Let these gods-forsaken cultists drink their way to hell and be done with it. There was a cave at the base of the mountain\n" +
                                "that might be connected to this stronghold, but we cannot find any evidence of this other than a few ceremonial urns of similar making to those we found here.\n" +
                                "\n" +
                                "We leave this accursed place tommorow to regroup and push up north, but I will leave this journal. So, in an age or so when the poison has faded, somene can find a way in to\n" +
                                "be sure these cultists met their due fate.\n" +
                                "\n" +
                                "The rest of the pages are blank\n");
                        }
                        else if (input == "Tome" && TomeGet == 1)
                        {
                            Console.WriteLine("The first fears all\n" +
                                "The second fears none\n" +
                                "The third eats many things, preferably number one\n" +
                                "The fourth fears all, except number one\n" +
                                "\n" +
                                "All must be activated at once\n" +
                                "If you wish to go home");
                        }
                        else
                        {
                            Console.WriteLine("Movement is unavailable now. You can either read what you found in the ruins or exit.");
                        }
                    }
                    else
                    {
                        if ((input == "north" || input == "North" || input == "n" || input == "N") && roomArray[roomNum].north > -1)
                        {
                            roomNum = roomArray[roomNum].north;
                        }
                        else if ((input == "west" || input == "West" || input == "w" || input == "W") && roomArray[roomNum].west > -1)
                        {
                            roomNum = roomArray[roomNum].west;
                        }
                        else if ((input == "east" || input == "East" || input == "e" || input == "E") && roomArray[roomNum].east > -1)
                        {
                            roomNum = roomArray[roomNum].east;
                        }
                        else if ((input == "south" || input == "South" || input == "s" || input == "S") && roomArray[roomNum].south > -1)
                        {
                            roomNum = roomArray[roomNum].south;
                        }
                        else if (input == "Journal" && JournalGet == 1)
                        {
                            Console.WriteLine("You skip a few entries in the book until you come to entries regarding this place.\n" +
                                "\n" +
                                "27th of November\n" +
                                "\n" +
                                "It seems impossible, but we appeared to have stumbled upon a stronghold of some demonic cult, who were believed to have been wiped out decades ago. The enemy army must wait,\n" +
                                "as this is a threat we cannot ignore. If we are quick, we may be able to catch the defenders off gaurd and avoid a legnthy siege.\n" +
                                "\n" +
                                "21st of December\n" +
                                "\n" +
                                "Third week of the seige. The men grow tired of the cold and all miss their families. Had it not been for tha blasted storm that sloweed our ascent we may have taken the\n" +
                                "courtyard sooner, but at this rate we will be pounding on their walls for several weeks or more.\n" +
                                "\n" +
                                "4th of January\n" +
                                "\n" +
                                "We finally brought down the main gate. The cultists have fallen back to the interior of the stronghold but we will soon breach those defenses. It cannot be soon enough, it's\n" +
                                "too bloody cold on this mountain.\n" +
                                "\n" +
                                "5th of January\n" +
                                "\n" +
                                "We entered the stronghold today only to find all inside dead. It seems they have purposely caved in the path to the other side of the burial chambers and then took their own\n" +
                                "lives. Some appear to have slit heir wrists, while others were found with empty vials. Most appeared to have poisoned themselves, but oddly there are not as mny empty vials\n" +
                                "as one would have expected by the number of dead. We shall hold up here overnight rather than face the cold and explore the catacombs in the morning to see if we can find a\n" +
                                "passageway into the deeper parts of the stronghold.\n" +
                                "\n" +
                                "6th of January\n" +
                                "\n" +
                                "May the gods protect us from demons and madmen! We lost half our remaining men today! We discovered a well in the catacombs, unlocked and with several buckets already filled.\n" +
                                "In their excitement for a drink that did not risk frostbite on their tongues, four score drank before we could stop them. Gods only knows how these cultists couled use poison\n" +
                                "in their own water supply. We lost more men to this catastrophe than we did taking the courtyard.\n" +
                                "\n" +
                                "The door was locked from this side and the key must be somewhere in the catacombs, but with the bodies of these cultists coming back to life and the men becoming more and\n" +
                                "more demoralized, it just isn't worth the search. Let these gods-forsaken cultists drink their way to hell and be done with it. There was a cave at the base of the mountain\n" +
                                "that might be connected to this stronghold, but we cannot find any evidence of this other than a few ceremonial urns of similar making to those we found here.\n" +
                                "\n" +
                                "We leave this accursed place tommorow to regroup and push up north, but I will leave this journal. So, in an age or so when the poison has faded, somene can find a way in to\n" +
                                "be sure these cultists met their due fate.\n" +
                                "\n" +
                                "The rest of the pages are blank\n");
                        }
                        else if (input == "Tome" && TomeGet == 1)
                        {
                            Console.WriteLine("The first fears all\n" +
                                "The second fears none\n" +
                                "The third eats many things, preferably number one\n" +
                                "The fourth fears all, except number one\n" +
                                "\n" +
                                "All must be activated at once\n" +
                                "If you wish to go home");
                        }
                        else
                        {
                            Console.WriteLine("You either need to check your spelling, or you cannot go in that direction. ()");
                        }
                    }
                }
            }
        }
    }
}
