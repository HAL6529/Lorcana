using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_194_JA_10 : CardInfo
{
    public CardInfo_194_JA_10()
    {
        this.cardNo = "194_JA_10";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "首なし騎士";
        this.cardName2 = "恐ろしい怨霊";
        this.power = 4;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.CristianRomero;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.TheAdventuresOfIchabodAndMrToad;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
