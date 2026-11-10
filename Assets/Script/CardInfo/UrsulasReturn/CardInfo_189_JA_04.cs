using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_189_JA_04 : CardInfo
{
    public CardInfo_189_JA_04()
    {
        this.cardNo = "189_JA_04";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ÉÄÅ[ÉâÉì";
        this.cardName2 = "ïêçbêÌém";
        this.power = 3;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AmberKommavongsa;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
