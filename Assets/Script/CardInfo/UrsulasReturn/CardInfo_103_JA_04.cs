using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_103_JA_04 : CardInfo
{
    public CardInfo_103_JA_04()
    {
        this.cardNo = "103_JA_04";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ñÏèb";
        this.cardName2 = "éËïâÇ¢ÇÃèb";
        this.power = 2;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.IanMacDonald;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.BeautyAndTheBeast;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
