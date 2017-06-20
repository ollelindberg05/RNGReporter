﻿using System.Collections.Generic;

namespace RNGReporter.Objects
{
    public class NatureLock
    {
        private uint[] lockInfo;
        private static int forwardCounter, count, count2, lastIndex, lastIndex2;
        private static uint pid, genderval;
        public List<uint> rand;
        public int index;
        private XdRngR reverse;
        private XdRng forward;

        public NatureLock(int lockNum)
        {
            lockInfo = natureLockList(lockNum);
            rand = new List<uint>();
            count = ((lockInfo.Length - 2) / 3) - 1;
            count2 = count + 1;
            lastIndex = lockInfo.Length - 4;
            lastIndex2 = lastIndex + 3;
            reverse = new XdRngR(0);
            forward = new XdRng(0);
        }

        private uint[] natureLockList(int natureLockIndex)
        {
            switch (natureLockIndex)
            {
                case 0:
                    return new uint[] { 3, 6, 127, 255, 24, 0, 126, 0, 127, 255, 12 }; //Altaria
                case 1:
                    return new uint[] { 4, 1, 0, 126, 18, 0, 126, 12, 0, 126, 0, 127, 255, 6 }; //Arbok
                case 2:
                    return new uint[] { 0, 0 }; //Articuno 
                case 3:
                    return new uint[] { 0, 0 }; //Baltoy 3
                case 4:
                    return new uint[] { 0, 0 }; //Baltoy 1
                case 5:
                    return new uint[] { 2, 1, 127, 255, 0, 127, 255, 24 }; //Baltoy 2
                case 6:
                    return new uint[] { 3, 6, 0, 255, 12, 0, 126, 18, 0, 255, 0 }; //Banette
                case 7:
                    return new uint[] { 0, 0 }; //Beedrill
                case 8:
                    return new uint[] { 3, 6, 0, 126, 0, 127, 255, 6, 0, 190, 12 }; //Butterfree
                case 9:
                    return new uint[] { 0, 0 }; //Carvanha
                case 10:
                    return new uint[] { 2, 6, 127, 255, 24, 0, 126, 6 }; //Chansey
                case 11:
                    return new uint[] { 3, 1, 127, 255, 24, 127, 255, 0, 0, 190, 6 }; //Delcatty
                case 12:
                    return new uint[] { 1, 1, 0, 126, 18 }; //Dodrio
                case 13:
                    return new uint[] { 5, 1, 127, 255, 0, 0, 126, 12, 0, 126, 12, 127, 255, 18, 127, 255, 0 }; //Dragonite
                case 14:
                    return new uint[] { 4, 1, 127, 255, 12, 0, 126, 6, 127, 255, 18, 127, 255, 0 }; //Dugtrio
                case 15:
                    return new uint[] { 3, 1, 127, 255, 24, 0, 126, 18, 127, 255, 12 }; //Duskull
                case 16:
                    return new uint[] { 3, 1, 0, 126, 18, 0, 126, 6, 63, 255, 24 }; //Electabuzz
                case 17:
                    return new uint[] { 0, 0 }; //Exeggutor
                case 18:
                    return new uint[] { 3, 1, 127, 255, 24, 0, 126, 0, 127, 255, 12 }; //Farfetch'd  
                case 19:
                    return new uint[] { 3, 1, 0, 126, 18, 0, 126, 6, 127, 255, 24 }; //Golduck
                case 20:
                    return new uint[] { 2, 1, 127, 255, 18, 127, 255, 12 }; //Grimer
                case 21:
                    return new uint[] { 2, 6, 0, 126, 6, 127, 255, 24 }; //Growlithe
                case 22:
                    return new uint[] { 2, 1, 127, 255, 6, 0, 126, 12 }; //Gulpin 3
                case 23:
                    return new uint[] { 2, 1, 127, 255, 6, 0, 126, 12 }; //Gulpin 1
                case 24:
                    return new uint[] { 4, 1, 0, 126, 0, 0, 126, 0, 127, 255, 6, 0, 126, 12 }; //Gulpin 2
                case 25:
                    return new uint[] { 3, 1, 0, 126, 18, 0, 126, 6, 127, 255, 24 }; //Hitmonchan
                case 26:
                    return new uint[] { 4, 1, 0, 126, 24, 0, 255, 6, 0, 126, 12, 127, 255, 18 }; //Hitmonlee
                case 27:
                    return new uint[] { 0, 0 }; //Houndour 3
                case 28:
                    return new uint[] { 0, 0 }; //Houndour 1
                case 29:
                    return new uint[] { 0, 0 }; //To do houndour 2
                case 30:
                    return new uint[] { 4, 6, 127, 255, 24, 0, 126, 6, 0, 126, 12, 0, 126, 18 }; //Hypno
                case 31:
                    return new uint[] { 3, 1, 0, 255, 12, 0, 126, 18, 0, 255, 0 }; //Kangaskhan
                case 32:
                    return new uint[] { 4, 6, 127, 255, 24, 500, 500, 500, 500, 500, 500, 0, 126, 6 }; //Lapras
                case 33:
                    return new uint[] { 1, 1, 0, 126, 0 }; //Ledyba
                case 34:
                    return new uint[] { 2, 1, 0, 255, 6, 127, 255, 24 }; //Lickitung
                case 35:
                    return new uint[] { 0, 0 }; //Lugia
                case 36:
                    return new uint[] { 2, 1, 127, 255, 18, 0, 126, 0 }; //Lunatone
                case 37:
                    return new uint[] { 3, 6, 0, 126, 12, 127, 255, 6, 127, 255, 24 }; //Marcargo
                case 38:
                    return new uint[] { 3, 1, 0, 126, 0, 191, 255, 18, 127, 255, 18 }; //Magmar 
                case 39:
                    return new uint[] { 3, 1, 0, 126, 12, 127, 255, 0, 0, 255, 18 }; //Magneton
                case 40:
                    return new uint[] { 2, 1, 0, 126, 18, 127, 255, 6 }; //Makuhita
                case 41:
                    return new uint[] { 2, 1, 0, 126, 0, 127, 255, 24 }; //Makuhita Colo
                case 42:
                    return new uint[] { 1, 1, 0, 126, 6 }; //Manectric
                case 43:
                    return new uint[] { 0, 0 }; //Mareep 3
                case 44:
                    return new uint[] { 2, 1, 0, 126, 12, 127, 255, 24 }; //Mareep 1
                case 45:
                    return new uint[] { 3, 1, 0, 255, 0, 0, 126, 12, 127, 255, 24 }; //Mareep 2
                case 46:
                    return new uint[] { 4, 1, 127, 255, 24, 500, 500, 500, 500, 500, 500, 0, 126, 6 }; //Marowak
                case 47:
                    return new uint[] { 2, 1, 0, 126, 18, 127, 255, 6 }; //Mawile
                case 48:
                    return new uint[] { 3, 1, 0, 126, 18, 0, 126, 0, 63, 255, 6 }; //Meowth
                case 49:
                    return new uint[] { 0, 0 }; //Moltres
                case 50:
                    return new uint[] { 4, 6, 0, 126, 6, 127, 255, 24, 127, 255, 18, 127, 255, 18 }; //Mr. Mime
                case 51:
                    return new uint[] { 2, 1, 0, 126, 0, 127, 255, 24 }; //Natu
                case 52:
                    return new uint[] { 3, 1, 0, 126, 12, 127, 255, 18, 127, 255, 0 }; //Nosepass
                case 53:
                    return new uint[] { 3, 1, 0, 126, 24, 0, 255, 0, 127, 255, 6 }; //Numel
                case 54:
                    return new uint[] { 2, 1, 0, 126, 6, 127, 255, 24 }; //Paras
                case 55:
                    return new uint[] { 2, 1, 32, 255, 18, 127, 255, 12 }; //Pidgeotto
                case 56:
                    return new uint[] { 1, 1, 127, 255, 6 }; //Pineco
                case 57:
                    return new uint[] { 3, 6, 0, 126, 0, 191, 255, 18, 127, 255, 18 }; //Pinsir
                case 58:
                    return new uint[] { 4, 1, 0, 126, 6, 127, 255, 24, 127, 255, 18, 127, 255, 18 }; //Poliwrath
                case 59:
                    return new uint[] { 1, 1, 0, 126, 12 }; //Poochyena
                case 60:
                    return new uint[] { 4, 1, 127, 255, 24, 0, 126, 6, 0, 126, 12, 0, 126, 18 }; //Primeape
                case 61:
                    return new uint[] { 3, 1, 127, 255, 18, 0, 126, 6, 63, 255, 0 }; //Ralts
                case 62:
                    return new uint[] { 3, 1, 0, 126, 12, 127, 255, 6, 127, 255, 24 }; //Rapidash
                case 63:
                    return new uint[] { 3, 1, 127, 255, 18, 500, 500, 500, 0, 126, 18 }; //Raticate
                case 64:
                    return new uint[] { 0, 0 }; //Rhydon
                case 65:
                    return new uint[] { 2, 1, 127, 255, 18, 127, 255, 6 }; //Roselia
                case 66:
                    return new uint[] { 3, 6, 0, 126, 18, 0, 126, 6, 127, 255, 24 }; //Sableye
                case 67:
                    return new uint[] { 1, 6, 0, 126, 6 }; //Salamence
                case 68:
                    return new uint[] { 2, 1, 127, 255, 24, 0, 126, 6 }; //Scyther
                case 69:
                    return new uint[] { 0, 0 }; //To do seedot 3
                case 70:
                    return new uint[] { 5, 1, 127, 255, 12, 127, 255, 0, 0, 126, 12, 0, 126, 24, 127, 255, 6 }; //Seedot 1
                case 71:
                    return new uint[] { 5, 1, 127, 255, 6, 0, 126, 0, 0, 126, 0, 0, 126, 24, 127, 255, 6 }; //Seedot 2
                case 72:
                    return new uint[] { 3, 1, 0, 126, 18, 127, 255, 12, 127, 255, 6 }; //Seel
                case 73:
                    return new uint[] { 0, 0 }; //Shellder
                case 74:
                    return new uint[] { 2, 1, 0, 126, 0, 0, 126, 24 }; //Shroomish
                case 75:
                    return new uint[] { 3, 6, 0, 126, 18, 0, 126, 6, 63, 255, 24 }; //Snorlax
                case 76:
                    return new uint[] { 1, 1, 0, 126, 6 }; //Snorunt
                case 77:
                    return new uint[] { 3, 1, 0, 126, 0, 127, 255, 6, 0, 255, 24 }; //Solrock
                case 78:
                    return new uint[] { 2, 1, 0, 126, 6, 127, 255, 18 }; //Spearow
                case 79:
                    return new uint[] { 3, 1, 0, 255, 0, 0, 126, 12, 127, 255, 24 }; //Spheal 3
                case 80:
                    return new uint[] { 2, 1, 0, 126, 12, 127, 255, 24 }; //Spheal 1
                case 81:
                    return new uint[] { 3, 1, 0, 255, 0, 0, 126, 12, 127, 255, 24 }; //Spheal 2
                case 82:
                    return new uint[] { 2, 1, 127, 255, 6, 0, 126, 12 }; //Spinarak
                case 83:
                    return new uint[] { 5, 1, 127, 255, 18, 500, 500, 500, 0, 126, 0, 127, 255, 6, 0, 255, 24 }; //Starmie
                case 84:
                    return new uint[] { 0, 0 }; //Swellow
                case 85:
                    return new uint[] { 2, 1, 127, 255, 0, 0, 126, 18 }; //Swinub
                case 86:
                    return new uint[] { 3, 1, 0, 126, 0, 127, 255, 6, 0, 190, 12 }; //Tangela
                case 87:
                    return new uint[] { 0, 0 }; //Tauros
                case 88:
                    return new uint[] { 0, 0 }; //Teddiursa
                case 89:
                    return new uint[] { 0, 0 }; //Togepi
                case 90:
                    return new uint[] { 3, 1, 127, 255, 12, 0, 255, 24, 0, 126, 18 }; //Venomoth
                case 91:
                    return new uint[] { 3, 1, 0, 126, 12, 127, 255, 12, 127, 255, 0 }; //Voltorb
                case 92:
                    return new uint[] { 3, 1, 127, 255, 18, 0, 126, 6, 127, 255, 0 }; //Vulpix
                case 93:
                    return new uint[] { 3, 6, 127, 255, 12, 0, 255, 24, 0, 126, 18 }; //Weepinbell
                case 94:
                    return new uint[] { 0, 0 }; //Zangoose
                default:
                    return new uint[] { 0, 0 }; //Zapdos 
            }
        }

        public bool method1FirstShadow(uint seed)
        {
            reverse.Seed = seed;
            reverse.GetNext32BitNumber();

            //Build temp pid first to not waste time populating if first backwards nl fails
            uint pidOriginal = getPIDReverse();

            //Backwards nature lock check
            uint genderval = pidOriginal & 255;
            if (genderval < lockInfo[2] || genderval > lockInfo[3] || pidOriginal % 25 != lockInfo[4])
                return false;

            for (int x = 1; x <= count; x++)
            {
                reverse.GetNext32BitNumber(3);
                pid = getPIDReverse();
                if (lockInfo[2 + 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[2 + 3 * x] || genderval > lockInfo[3 + 3 * x] || pid % 25 != lockInfo[4 + 3 * x])
                        countBackTwo(x);
                }
            }

            forward.Seed = reverse.Seed;
            forward.GetNext32BitNumber();

            //Forwards nature lock check
            for (int x = 1; x <= count; x++)
            {
                forward.GetNext32BitNumber(3);
                pid = getPIDForward();
                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwo(x);
                }
            }

            return pidOriginal == pid;
        }

        public bool method1SecondShadowUnset(uint seed)
        {
            reverse.Seed = seed;
            reverse.GetNext32BitNumber(8);

            //Build temp pid first to not waste time populating if first nl fails
            uint pidOriginal = getPIDReverse();

            //Backwards nature lock check
            genderval = pidOriginal & 255;
            if (genderval < lockInfo[2] || genderval > lockInfo[3] || pidOriginal % 25 != lockInfo[4])
                return false;

            for (int x = 1; x <= count; x++)
            {
                reverse.GetNext32BitNumber(3);
                pid = getPIDReverse();
                if (lockInfo[2 + 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[2 + 3 * x] || genderval > lockInfo[3 + 3 * x] || pid % 25 != lockInfo[4 + 3 * x])
                        countBackTwo(x);
                }
            }

            forward.Seed = reverse.Seed;
            forward.GetNext32BitNumber();

            //Forwards nature lock check
            for (int x = 1; x <= count; x++)
            {
                forward.GetNext32BitNumber(3);
                pid = getPIDForward();
                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwo(x);
                }
            }

            return pidOriginal == pid;
        }

        public bool method1SecondShadowSet(uint seed)
        {
            reverse.Seed = seed;
            reverse.GetNext32BitNumber(6);

            //Build temp pid first to not waste time populating if first nl fails
            uint pidOriginal = getPIDReverse();

            //Backwards nature lock check
            genderval = pidOriginal & 255;
            if (genderval < lockInfo[2] || genderval > lockInfo[3] || pidOriginal % 25 != lockInfo[4])
                return false;

            for (int x = 1; x <= count; x++)
            {
                reverse.GetNext32BitNumber(3);
                pid = getPIDReverse();
                if (lockInfo[2 + 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[2 + 3 * x] || genderval > lockInfo[3 + 3 * x] || pid % 25 != lockInfo[4 + 3 * x])
                        countBackTwo(x);
                }
            }

            forward.Seed = reverse.Seed;
            forward.GetNext32BitNumber();

            //Forwards nature lock check
            for (int x = 1; x <= count; x++)
            {
                forward.GetNext32BitNumber(3);
                pid = getPIDForward();
                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwo(x);
                }
            }

            return pidOriginal == pid;
        }

        public bool method1SecondShadowShinySkip(uint seed)
        {
            reverse.Seed = seed;
            reverse.GetNext32BitNumber(8);

            uint pidOriginal, psv, psvtemp;
            bool shinyFlag = true;

            //Check how many advances from shiny skip and build initial pid for first nl
            pidOriginal = getPIDReverse();
            psv = ((pidOriginal & 0xFFFF) ^ (pidOriginal >> 16)) >> 3;
            while (shinyFlag)
            {
                pidOriginal = getPIDReverse();
                psvtemp = ((pidOriginal & 0xFFFF) ^ (pidOriginal >> 16)) >> 3;
                if (psvtemp != psv)
                    shinyFlag = false;
                else
                    psv = psvtemp;
            }

            //Backwards nature lock check
            genderval = pidOriginal & 255;
            if (genderval < lockInfo[2] || genderval > lockInfo[3] || pidOriginal % 25 != lockInfo[4])
                return false;

            for (int x = 1; x <= count; x++)
            {
                reverse.GetNext32BitNumber(3);
                pid = getPIDReverse();
                if (lockInfo[2 + 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[2 + 3 * x] || genderval > lockInfo[3 + 3 * x] || pid % 25 != lockInfo[4 + 3 * x])
                        countBackTwo(x);
                }
            }

            forward.Seed = reverse.Seed;
            forward.GetNext32BitNumber();

            //Forwards nature lock check
            for (int x = 1; x <= count; x++)
            {
                forward.GetNext32BitNumber(3);
                pid = getPIDForward();
                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwo(x);
                }
            }

            return pidOriginal == pid;
        }

        public void method2FirstShadow(bool sister, out uint seed, out uint pid, out uint iv1, out uint iv2)
        {
            forwardCounter = 5;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = getPIDForward2(sister);

                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwo2(sister, x);
                }
            }

            forwardCounter += 2;
            seed = sister ? rand[forwardCounter] ^ 0x80000000 : rand[forwardCounter];
            forwardCounter++;
            iv1 = sister ? (rand[forwardCounter] >> 16) ^ 0x8000 : rand[forwardCounter] >> 16;
            forwardCounter++;
            iv2 = sister ? (rand[forwardCounter] >> 16) ^ 0x8000 : rand[forwardCounter] >> 16;
            forwardCounter += 3;
            pid = getPIDForward2(sister);
        }

        public void method2SecondShadowSet(bool sister, out uint seed, out uint pid, out uint iv1, out uint iv2)
        {
            forwardCounter = 5;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = getPIDForward2(sister);

                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwo2(sister, x);
                }
            }

            forwardCounter += 7;
            seed = sister ? rand[forwardCounter] ^ 0x80000000 : rand[forwardCounter];
            forwardCounter++;
            iv1 = sister ? (rand[forwardCounter] >> 16) ^ 0x8000 : rand[forwardCounter] >> 16;
            forwardCounter++;
            iv2 = sister ? (rand[forwardCounter] >> 16) ^ 0x8000 : rand[forwardCounter] >> 16;
            forwardCounter += 3;
            pid = getPIDForward2(sister);
        }

        public void method2SecondShadowUnset(bool sister, out uint seed, out uint pid, out uint iv1, out uint iv2)
        {
            forwardCounter = 5;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = getPIDForward2(sister);

                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwo2(sister, x);
                }
            }

            forwardCounter += 9;
            seed = sister ? rand[forwardCounter] ^ 0x80000000 : rand[forwardCounter];
            forwardCounter++;
            iv1 = sister ? (rand[forwardCounter] >> 16) ^ 0x8000 : rand[forwardCounter] >> 16;
            forwardCounter++;
            iv2 = sister ? (rand[forwardCounter] >> 16) ^ 0x8000 : rand[forwardCounter] >> 16;
            forwardCounter += 3;
            pid = getPIDForward2(sister);
        }

        public void method2SecondShinySkip(bool sister, out uint seed, out uint pid, out uint iv1, out uint iv2)
        {
            forwardCounter = 4;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = getPIDForward2(sister);

                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwo2(sister, x);
                }
            }

            forwardCounter += 7;
            pid = getPIDForward2(sister);
            bool shiny = true;
            uint psv, psvtemp;
            psv = ((pid & 0xFFFF) ^ (pid >> 16)) >> 3;
            while (shiny)
            {
                forwardCounter += 2;
                pid = getPIDForward2(sister);
                psvtemp = ((pid & 0xFFFF) ^ (pid >> 16)) >> 3;
                if (psvtemp != psv)
                    shiny = false;
                else
                    psv = psvtemp;
            }

            forwardCounter += 2;
            seed = sister ? rand[forwardCounter] ^ 0x80000000 : rand[forwardCounter];
            forwardCounter++;
            iv1 = sister ? (rand[forwardCounter - 4] >> 16) ^ 0x8000 : rand[forwardCounter - 4] >> 16;
            forwardCounter++;
            iv2 = sister ? (rand[forwardCounter - 3] >> 16) ^ 0x8000 : rand[forwardCounter - 3] >> 16;
            forwardCounter += 3;
            pid = getPIDForward2(sister);
        }

        public void methodShadowFirstShadow(out uint pid, out uint iv1, out uint iv2)
        {
            forwardCounter = 5;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = getPIDShadow();

                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwoShadow(x);
                }
            }

            forwardCounter += 7;
            pid = getPIDShadow();
            iv1 = rand[forwardCounter - 4] >> 16;
            iv2 = rand[forwardCounter - 3] >> 16;
        }

        public void methodShadowSecondShadowSet(out uint pid, out uint iv1, out uint iv2)
        {
            forwardCounter = 5;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = getPIDShadow();

                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwoShadow(x);
                }
            }

            forwardCounter += 12;
            pid = getPIDShadow();
            iv1 = rand[forwardCounter - 4] >> 16;
            iv2 = rand[forwardCounter - 3] >> 16;
        }

        public void methodShadowSecondShadowUnset(out uint pid, out uint iv1, out uint iv2)
        {
            forwardCounter = 5;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = getPIDShadow();

                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwoShadow(x);
                }
            }

            forwardCounter += 14;
            pid = getPIDShadow();
            iv1 = rand[forwardCounter - 4] >> 16;
            iv2 = rand[forwardCounter - 3] >> 16;
        }

        public void methodShadowSecondShinySkip(out uint pid, out uint iv1, out uint iv2)
        {
            forwardCounter = 5;

            for (int x = 0; x < count2; x++)
            {
                forwardCounter += 5;
                pid = getPIDShadow();

                if (lockInfo[lastIndex + 1 - 3 * x] != 500)
                {
                    genderval = pid & 255;
                    if (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
                        countForwardTwoShadow(x);
                }
            }

            forwardCounter += 7;
            pid = getPIDShadow();
            bool shiny = true;
            uint psv, psvtemp;
            psv = ((pid & 0xFFFF) ^ (pid >> 16)) >> 3;
            while (shiny)
            {
                forwardCounter += 2;
                pid = getPIDShadow();
                psvtemp = ((pid & 0xFFFF) ^ (pid >> 16)) >> 3;
                if (psvtemp != psv)
                    shiny = false;
                else
                    psv = psvtemp;
            }

            forwardCounter += 7;
            pid = getPIDShadow();
            iv1 = rand[forwardCounter - 4] >> 16;
            iv2 = rand[forwardCounter - 3] >> 16;
        }

        public uint getType()
        {
            return lockInfo[1];
        }

        private uint getPIDReverse()
        {
            return reverse.GetNext16BitNumber() | (reverse.GetNext32BitNumber() & 0xFFFF0000);
        }

        private uint getPIDForward()
        {
            return (forward.GetNext32BitNumber() & 0xFFFF0000) | forward.GetNext16BitNumber();
        }

        private uint getPIDShadow()
        {
            return (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
        }

        private uint getPIDForward2(bool sister)
        {
            return sister ? ((rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16)) ^ 0x80008000 : (rand[forwardCounter - 1] & 0xFFFF0000) | (rand[forwardCounter] >> 16);
        }

        private void countBackTwo(int x)
        {
            pid = getPIDReverse();
            genderval = pid & 255;
            while (genderval < lockInfo[2 + 3 * x] || genderval > lockInfo[3 + 3 * x] || pid % 25 != lockInfo[4 + 3 * x])
            {
                pid = getPIDReverse();
                genderval = pid & 255;
            }
        }

        private void countForwardTwo(int x)
        {
            pid = getPIDForward();
            genderval = pid & 255;
            while (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
            {
                pid = getPIDForward();
                genderval = pid & 255;
            }
        }

        private void countForwardTwo2(bool sister, int x)
        {
            forwardCounter += 2;
            pid = getPIDForward2(sister);
            genderval = pid & 255;
            while (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
            {
                forwardCounter += 2;
                pid = getPIDForward2(sister);
                genderval = pid & 255;
            }
        }

        private void countForwardTwoShadow(int x)
        {
            forwardCounter += 2;
            pid = getPIDShadow();
            genderval = pid & 255;
            while (genderval < lockInfo[lastIndex + 1 - 3 * x] || genderval > lockInfo[lastIndex + 2 - 3 * x] || pid % 25 != lockInfo[lastIndex + 3 - 3 * x])
            {
                forwardCounter += 2;
                pid = getPIDShadow();
                genderval = pid & 255;
            }
        }
    }
}