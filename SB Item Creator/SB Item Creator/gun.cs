﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SB_Item_Creator
{
    class gun
    {

        public static string sl26,sl23,sl24,sl25,sl1, sl2, sl3, sl4, sl5, sl6, sl7, sl8, sl9, sl10, sl11, sl12, sl13, sl14, sl15, sl16, sl17, sl18, sl19, sl20,sl21,sl22;
        public static string @base;
        //public string
    
        public static void updatestrings()
        {
        sl1 = "{" + Environment.NewLine;
        sl2 = "  \"itemName\" : \""+Value.itemfilename+"\"," + Environment.NewLine ;
        sl3 = "  \"inventoryIcon\" : \"bubblegunIcon.png\"," + Environment.NewLine ;
        sl4 = "  \"dropCollision\" : [-8.0, -3.0, 8.0, 3.0]," + Environment.NewLine ;
        sl5 = "  \"maxStack\" : "+Value.maxstack+"," + Environment.NewLine ;
        sl6 = "  \"rarity\" : \""+Value.itemrarity+"\"," + Environment.NewLine ;
        sl7 = "  \"description\" : \""+Value.description+"\"," + Environment.NewLine;
        sl8 = "  \"shortdescription\" : \"" + Value.itemname + "\"," + Environment.NewLine;
        sl9 = "  \"image\" : \"bubblegun.png\"," + Environment.NewLine;
        sl10 = "  \"recoilTime\" : " + Value.recoiltime + "," + Environment.NewLine; //Might be used
        sl11 = "  \"handPosition\" : [-3.5, -1]," + Environment.NewLine;
        sl12 = "  \"firePosition\" : [20, 1.5]," + Environment.NewLine;
        sl13 = "  \"level\" : "+Value.itemlevel+","+Environment.NewLine; //Use?
        sl14 = "  \"fireOnRelease\" : false,"+Environment.NewLine;//Don't use | Bow's Only
        sl23 = "  \"walkWhileFiring\" : false," + Environment.NewLine;//Don't use | Bow's Only
        sl15 = "  \"fireTime\" : "+Value.firetime+"," + Environment.NewLine ;
        sl16 = "  \"twoHanded\" : "+Value.guntwohanded+"," + Environment.NewLine ;
        sl17 = "  \"projectileType\" : \""+Value.projtype+"\"," + Environment.NewLine ;
        sl18 = "  \"projectile\" : {" + Environment.NewLine ;
        sl19 = "    \"speed\" : "+Value.speed+"," + Environment.NewLine ;
        sl20 = "    \"color\" : [" + Form1.colorr + ", " + Form1.colorg + ", " + Form1.colorb + "]" + Environment.NewLine;
        sl21 = "  }" + Environment.NewLine;
        sl22 = "}";
        sl24 = Environment.NewLine+Environment.NewLine+"Level of Tier or blueprint: "+Value.blueprinttier;
        sl25 = "";
        sl26 = "";
        //@base = (sl1 + sl2 + sl3 + sl4 + sl5 + sl6 + sl7 + sl8 + sl9 + sl10 + sl11 + sl12 + sl13 + sl14 + sl15 + sl16 + sl17 + sl18 + sl19 + sl20+sl21+sl22);
        }
        public static void creation(bool recoil, bool level)
        {
            if (recoil == true && level != true)
            {
                @base = (sl1 + sl2 + sl3 + sl4 + sl5 + sl6 + sl7 + sl8 + sl9 + 
                    sl10 + sl11 + sl12 + sl15 + sl16 + sl17 + 
                    sl18 + sl19 + sl20 + sl21 + sl22);
            }
            else if (level == true && recoil != true)
            {
                @base = (sl1 + sl2 + sl3 + sl4 + sl5 + sl6 + sl7 + sl8 + sl9 + 
                    sl11 + sl12 + sl13 + sl15 + sl16 + sl17 +
                    sl18 + sl19 + sl20 + sl21 + sl22);
            }
            else if (recoil == true && level == true)
            {
                @base = (sl1 + sl2 + sl3 + sl4 + sl5 + sl6 + sl7 + sl8 + sl9 +
                    sl10 + sl11 + sl12 + sl13 + sl15 + sl16 + sl17 +
                    sl18 + sl19 + sl20 + sl21 + sl22);
            }
            else
            {
                @base = (sl1 + sl2 + sl3 + sl4 + sl5 + sl6 + sl7 + sl8 + sl9 +
                    sl11 + sl12 + sl15 + sl16 + sl17 +
                    sl18 + sl19 + sl20 + sl21 + sl22);
            }
        }
    }
}