using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_12 : CardInfo
{
    public CardInfo_175_JA_12()
    {
        this.cardNo = "175_JA_12";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ファーガス";
        this.cardName2 = "ダンブロッホの王";
        this.power = 3;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.King };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.Brave;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
