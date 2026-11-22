using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_137_JA_10 : CardInfo
{
    public CardInfo_137_JA_10()
    {
        this.cardNo = "137_JA_10";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "ジュディ・ホップス";
        this.cardName2 = "事件捜査中";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.AndrewChesworth;
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Sapphire };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WinterSpellInTheWell;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
