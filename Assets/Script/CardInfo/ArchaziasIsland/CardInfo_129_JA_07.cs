using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_129_JA_07 : CardInfo
{
    public CardInfo_129_JA_07()
    {
        this.cardNo = "129_JA_07";
        this.inkCost = 1;
        this.availableInk = true;
        this.cardName1 = "ÉgÉâÉìÉvï∫";
        this.cardName2 = "èóâ§ÇÃï∫ë‡";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.KamilMurzyn;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.ArchaziasIsland;
        this.title = EnumController.Title.AliceInWonderland;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
