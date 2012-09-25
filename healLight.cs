using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using openForgeRPGCore;
using openForgeRPG;

namespace openForgeRPG
{
    public class openForgeScript
    {
        public void Script(ScriptFunctions sf)
        {
            // C# code goes here
            int PCindex = sf.gm.indexOfPCtoLastUseItem;
            MessageBox.Show("Heal Light Wounds");
            int hp = sf.gm.playerList.PCList[PCindex].pc_hp;
            string name = sf.gm.playerList.PCList[PCindex].CharacterName;
            MessageBox.Show(name + "'s current hit points are " + hp.ToString());
            sf.gm.playerList.PCList[PCindex].pc_hp += 10;
            if (sf.gm.playerList.PCList[PCindex].pc_hp > sf.gm.playerList.PCList[PCindex].pc_hpMax)
            {
                sf.gm.playerList.PCList[PCindex].pc_hp = sf.gm.playerList.PCList[PCindex].pc_hpMax;
            }
            MessageBox.Show("now " + name + "'s current hit points are " + sf.gm.playerList.PCList[PCindex].pc_hp.ToString());
            sf.gm.deleteItemUsedScript = true;
        }
    }
}
